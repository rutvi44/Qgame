/* 
 * Name : RMistryQGame (Assignment2)
 * Revision History: 11/2/2023 Creted:Rutvi Mistry
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMistryQGame
{
    public partial class Design_Form : Form
    {
        // Declare class-level variables for selected tools, maze grid, and level change status.
        private PictureBox selectedToolPictureBox;
        private PictureBox[,] mazeGrid;
        private PictureBox selectedDoorPictureBox;
        private PictureBox selectedBoxPictureBox;
        private bool levelChanged = false;

        public Design_Form()
        {         
            InitializeComponent();
            InitializeToolPictureBoxes();
        }

        private void InitializeToolPictureBoxes()
        {
            // Add click event handlers for each tool PictureBox control.
            pcrBoXNone.Click += ToolPictureBox_Click;
            pcrBoxWall.Click += ToolPictureBox_Click;
            pcrBoxRedDoor.Click += ToolPictureBox_Click;
            pcrBoxGreendoor.Click += ToolPictureBox_Click;
            pcrGreenBox.Click += ToolPictureBox_Click;
            pcrRedBox.Click += ToolPictureBox_Click;

            // Set the initial selected tool to None.
            selectedToolPictureBox = pcrBoXNone;
            selectedToolPictureBox.BorderStyle = BorderStyle.Fixed3D;
        }

        //Event Handler for tool picture box
        private void ToolPictureBox_Click(object sender, EventArgs e)
        {

            PictureBox toolPictureBox = sender as PictureBox;

            if (toolPictureBox != null)
            {
                // Change the border style of the previously selected tool PictureBox to None.
                selectedToolPictureBox.BorderStyle = BorderStyle.Fixed3D;

                // Update the selected tool PictureBox.
                selectedToolPictureBox = toolPictureBox;

                // Change the border style of the new selected tool PictureBox to Fixed3D.
                selectedToolPictureBox.BorderStyle = BorderStyle.Fixed3D;

                // Differentiate between doors and boxes.
                selectedDoorPictureBox = (toolPictureBox == pcrBoxRedDoor || toolPictureBox == pcrBoxGreendoor) ? toolPictureBox : null;
                selectedBoxPictureBox = (toolPictureBox == pcrGreenBox || toolPictureBox == pcrRedBox) ? toolPictureBox : null;
            }

        }

        // Event handler for generating the maze grid.
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Check if the user has provided valid inputs for the number of rows and columns.
            if (!int.TryParse(txtRow.Text, out int numRows) || !int.TryParse(txtColumns.Text, out int numColumns))
            {
                MessageBox.Show("Please provide valid integer values for both rows and columns.", "Q game", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure that the number of rows and columns are positive integers.
            if (numRows <= 0 || numColumns <= 0)
            {
                MessageBox.Show("Number of rows and columns should be positive integers (greater than zero).", "Q game", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the level has changed and prompt the user to confirm starting a new level.
            if (levelChanged)
            {
                // Ask the user if they want to abandon the current level.
                if (!ConfirmNewLevel())
                {
                    // User wants to continue with the current level.
                    return; 
                }
            }

            // Clear the existing maze grid and create a new one.
            ClearMazeGrid();

            //Generating a new grid
            GenerateMazeGrid(numRows, numColumns);
            levelChanged = true;

        }

        // Add a method to confirm starting a new level.
        private bool ConfirmNewLevel()
        {
            // Prompt the user to confirm starting a new level, which may result in abandoning the current one.
            return MessageBox.Show("Do you want to create a new level?\nIf you do, the current level will be lost!", "Q game", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes;
        }

        // Add a method to clear the existing maze grid.
        private void ClearMazeGrid()
        {
            // Remove and dispose of all PictureBox controls in the existing maze grid.
            if (mazeGrid != null)
            {
                foreach (var pictureBox in mazeGrid)
                {
                    Controls.Remove(pictureBox);
                    pictureBox.Dispose();
                }
            }
            mazeGrid = null;
        }

        // Method to generate the maze grid with specified rows and columns enter by user.
        private void GenerateMazeGrid(int numRows, int numColumns)
        {
            // Calculate cell size and positioning for the maze grid in the middle of the form. 
            int cellSize = 70;
            int startX = (ClientSize.Width - numColumns * cellSize) / 2;
            int startY = (ClientSize.Height - numRows * cellSize) / 2;

            // Create and initialize the maze grid with PictureBox controls.
            mazeGrid = new PictureBox[numRows, numColumns];

            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numColumns; col++)
                {
                    mazeGrid[row, col] = new PictureBox
                    {
                        Size = new System.Drawing.Size(cellSize, cellSize),
                        Location = new System.Drawing.Point(startX + col * cellSize, startY + row * cellSize),
                        BorderStyle = BorderStyle.FixedSingle,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };

                    mazeGrid[row, col].Click += PictureBox_Click;

                    Controls.Add(mazeGrid[row, col]);
                }
            }
        }

        // Handle maze grid PictureBox click event.
        private void PictureBox_Click(object sender, EventArgs e)
        {            
            PictureBox mazePictureBox = sender as PictureBox;

            if (mazePictureBox != null)
            {
                if (selectedToolPictureBox == pcrBoXNone)
                {
                    // If the selected image is "None," clear the image of the mazePictureBox.
                    mazePictureBox.Image = null; 
                }
                else
                {
                    // Apply the selected image to the maze grid PictureBox.
                    mazePictureBox.Image = selectedToolPictureBox.Image;
                }
            }
        }

        // Event handler for saving the maze to a text file when the "Save" menu item is clicked.
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Create a SaveFileDialog for the user to choose the save location and file name.
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Maze Files (*.QGame)|*.QGame";

                // If the user selects a valid location and file name and clicks "OK" in the SaveFileDialog:
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Create a StreamWriter to write the maze data to the selected file.
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        // Write the number of rows and columns in the maze to the file.
                        writer.WriteLine(mazeGrid.GetLength(0));
                        writer.WriteLine(mazeGrid.GetLength(1));

                        // Initialize counters for the number of walls, doors, and boxes.
                        int walls = 0;
                        int reddoors = 0; //Red doors and green doors
                        int greendoors = 0;
                        int redboxes = 0; //Red boxes and green boxes
                        int greendoboxes = 0;

                        // Iterate through the maze grid to determine the content of each cell and save it to the file.
                        for (int row = 0; row < mazeGrid.GetLength(0); row++)
                        {
                            for (int col = 0; col < mazeGrid.GetLength(1); col++)
                            {
                                int content = 0;

                                // Check the image of the current cell to identify its content type.
                                if (mazeGrid[row, col].Image == pcrBoxWall.Image)
                                {
                                    content = 1; // Wall
                                    walls++;
                                }
                                else if (mazeGrid[row, col].Image == pcrBoxRedDoor.Image)
                                {
                                    content = 2; // Red_Door
                                    reddoors++;
                                }
                                else if (mazeGrid[row, col].Image == pcrBoxGreendoor.Image)
                                {
                                    content = 3; // Green_Door
                                    greendoors++;
                                }
                                else if (mazeGrid[row, col].Image == pcrRedBox.Image)
                                {
                                    content = 6; // Red_Box
                                    redboxes++;
                                }
                                else if (mazeGrid[row, col].Image == pcrGreenBox.Image)
                                {
                                    content = 7; // Green_Box
                                    greendoboxes++;
                                }
                                // Write the cell's position and content type to the file in the format "row,col,content".
                                writer.WriteLine($"{row}\n{col}\n{content}");
                            }
                        }

                        int totaldoors = reddoors + greendoors;
                        int totalboxes = redboxes + greendoboxes;


                        // Display a message to inform the user that the file was saved successfully and provide counts of each content type.
                        MessageBox.Show($"File saved successfully!\nNumber of Walls: {walls}\nNumber of Doors: {totaldoors}\nNumber of Boxes: {totalboxes}",
                            "QGame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        // Event handler for clsing the Design_form when the "Close" menu item is clicked.
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Closes the Design_Form
            this.Close(); 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Design_Form_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtRow_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

