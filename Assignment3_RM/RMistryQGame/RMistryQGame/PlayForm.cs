/* 
 * Name : RMistryQGame
 * Revision History: 11/21/2023 Creted:Rutvi Mistry
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Common;

namespace RMistryQGame
{
    public partial class PlayForm : Form
    {
        // Declare private variables for the game
        private Tile[,] tiles;
        private int moves = 0;
        private int remainingBoxes = 0;
        public const int INIT_LEFT = 65;
        public const int INIT_TOP = 65;
        public const int WIDTH = 65;
        public const int HEIGHT = 65;
        private int numberRows;
        private int numberColumns;
        private bool boxMoved = false;

        // Constructor for the PlayForm
        public PlayForm()
        {
            InitializeComponent();
            this.Load += PlayForm_Load;
        }

        // Event handler for the "closeToolStripMenuItem" click event
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        // Event handler for the "loadGameToolStripMenuItem" click event
        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear the current game state
            ClearGame();

            // Open a file dialog to select a game file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Read all lines from the selected file
                    string[] startingLines = File.ReadAllLines(openFileDialog.FileName);

                    // Check if there are at least 2 lines and parse the number of rows and columns
                    if (startingLines.Length >= 2 && int.TryParse(startingLines[0], out numberRows) && int.TryParse(startingLines[1], out numberColumns))
                    {
                        // Initialize the tiles array and remainingBoxes count
                        tiles = new Tile[numberRows, numberColumns];
                        remainingBoxes = 0;

                        // Loop through the lines to parse tile information
                        for (int i = 2; i < startingLines.Length; i += 3)
                        {
                            // Check if there are enough lines for a tile
                            if (i + 2 < startingLines.Length)
                            {
                                // Parse row, column, and tile type from the lines
                                if (int.TryParse(startingLines[i], out int row) &&
                                    int.TryParse(startingLines[i + 1], out int col) &&
                                    Enum.TryParse(startingLines[i + 2], out TileType tileType))
                                {

                                    // Check if the position is within bounds
                                    if (IsWithinBounds(row, col))
                                    {
                                        // Create a new Tile, set its properties, and add it to the form
                                        Tile tile = new Tile(row, col, tileType);
                                        tile.Left = INIT_LEFT + WIDTH * col;
                                        tile.Top = INIT_TOP + HEIGHT * row;
                                        tile.Size = new Size(WIDTH, HEIGHT);
                                        tile.SizeMode = PictureBoxSizeMode.StretchImage;

                                        // Attach an event handler for box click
                                        tile.BoxClicked += BoxClicked;

                                        // Update the tiles array and add the tile to the form controls
                                        tiles[row, col] = tile;
                                        Controls.Add(tile);

                                        // Update remainingBoxes count for box and green box types
                                        if (tileType == TileType.RedBox || tileType == TileType.GreenBox)
                                        {
                                            remainingBoxes++;
                                        }
                                    }
                                    else
                                    {
                                        // Show an error message for invalid position

                                        MessageBox.Show("Invalid positions of images in the level", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                                else
                                {
                                    // Show an error message for invalid position

                                    MessageBox.Show("Level format is not correct", "Q Game", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            else
                            {
                                // Show an error message for invalid position

                                MessageBox.Show("Level format is not correct", "Q Game", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        // Reset moves count, update UI, and enable controls

                        moves = 0;

                        txtMoves.Text = "0";
                        UpdateRemainingBoxes();
                        SetControlsEnabled(true);
                    }
                    else
                    {
                        // Show an error message for invalid level format

                        MessageBox.Show("Level format is not correct", "Q Game", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Show an error message for general exceptions

                    MessageBox.Show($"An error occurred: {ex.Message}", "Q Game", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to update the remaining boxes count in the UI
        private void UpdateRemainingBoxes()
        {
            txtRemainingBoxes.Text = remainingBoxes.ToString();
        }

        // Event handler for the BoxClicked event of a Tile
        private void BoxClicked(object sender, EventArgs e)
        {
            // Get the clicked tile
            Tile clickedTile = sender as Tile;

            // Deselect all tiles
            foreach (Tile tile in tiles)
            {
                if (tile != null)
                {
                    tile.IsSelected = false;
                }
            }

            // Select the clicked tile
            clickedTile.IsSelected = true;
        }

        // Method to move the selected box in the specified direction
        private void ShiftBox(Direction direction)
        {
            // Find the currently selected box
            Tile selectedBox = FindSelectedBox();

            // Check if a box is selected and if it is a valid box type
            if (selectedBox != null && (selectedBox.TileType == TileType.RedBox || selectedBox.TileType == TileType.GreenBox))
            {
                // Initialize new row and column based on the selected box's position
                int newRow = selectedBox.Row;
                int newCol = selectedBox.Column;

                // Initialize row and column changes based on the specified direction
                int rowChange = 0;
                int colChange = 0;

                switch (direction)
                {
                    case Direction.Up:
                        rowChange = -1;
                        break;
                    case Direction.Down:
                        rowChange = 1;
                        break;
                    case Direction.Left:
                        colChange = -1;
                        break;
                    case Direction.Right:
                        colChange = 1;
                        break;
                }

                // Move the box while within bounds
                while (IsWithinBounds(newRow + rowChange, newCol + colChange))
                {
                    // Update the new row and column
                    newRow += rowChange;
                    newCol += colChange;

                    // Get the tile at the new position
                    Tile targetTile = tiles[newRow, newCol];

                    // Check if the target position is empty
                    if (targetTile == null)
                    {
                        // Move the box to the new position and set boxMoved to true
                        MoveBoxToPosition(selectedBox, newRow, newCol);
                        boxMoved = true; 
                    }
                    else
                    {
                        // Check the target tile type for possible actions

                        if (targetTile.TileType == TileType.Wall || targetTile.TileType == TileType.RedBox || targetTile.TileType == TileType.GreenBox)
                        {
                            // Stop moving if the target is a wall or another box
                            break;
                        }
                        else if (targetTile.TileType == TileType.RedDoor || targetTile.TileType == TileType.GreenDoor)
                        {
                            // Handle box reaching a door
                            if ((targetTile.TileType == TileType.RedDoor && selectedBox.TileType == TileType.RedBox) ||
                                (targetTile.TileType == TileType.GreenDoor && selectedBox.TileType == TileType.GreenBox))
                            {
                                RemoveBox(selectedBox);
                            }
                            break;
                        }
                        else
                        {
                            // Move the box to the new position and set boxMoved to true
                            MoveBoxToPosition(selectedBox, newRow, newCol);
                            boxMoved = true; 
                        }
                    }
                }
                // Update moves count if a box was moved
                if (boxMoved)
                {
                    UpdateMoves();
                }
            }
            else
            {
                // Show a warning message if no valid box is selected
                MessageBox.Show("Please select a red or green box before moving.", "Q Game", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Reset boxMoved
            boxMoved = false;
            // Check if all boxes are removed and show a congratulations message
            if (AreAllBoxesRemoved())
            {
                MessageBox.Show("Congratulations! \nYou've cleared the level.", "Q Game", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ClearGame();
            }
        }

        // Method to find the currently selected box
        private Tile FindSelectedBox()
        {
            foreach (Tile tile in tiles)
            {
                if (tile != null && tile.IsSelected)
                {
                    return tile;
                }
            }
            return null;
        }

        // Method to check if a given position is within the game bounds
        private bool IsWithinBounds(int row, int col)
        {
            return row >= 0 && row < numberRows && col >= 0 && col < numberColumns;
        }

        // Method to move a box to a new position and update game state
        private void MoveBoxToPosition(Tile box, int newRow, int newCol)
        {
            // Clear the old position
            tiles[box.Row, box.Column] = null;

            // Get the target tile at the new position
            Tile targetTile = tiles[newRow, newCol];

            // Check the target tile type for actions
            if (targetTile != null)
            {
                switch (targetTile.TileType)
                {
                    case TileType.None:
                        // Move the box to the new position and update its display
                        box.Row = newRow;
                        box.Column = newCol;
                        tiles[newRow, newCol] = box;
                        UpdateBoxPosition(box);
                        break;
                    case TileType.Wall:
                        // Do nothing if the target is a wall
                        break;
                    case TileType.RedDoor:
                    case TileType.GreenDoor:
                        // Handle box reaching a door
                        if (targetTile.TileType == box.TileType)
                        {
                            RemoveBox(box);
                        }
                        else
                        {
                            // Move the box to the new position and update its display
                            box.Row = newRow;
                            box.Column = newCol;
                            tiles[newRow, newCol] = box;
                            UpdateBoxPosition(box);
                        }
                        break;
                    default:
                        // Do nothing for other tile types
                        break;
                }
            }
            else
            {
                // Move the box to the new position and update its display
                box.Row = newRow;
                box.Column = newCol;
                tiles[newRow, newCol] = box;
                UpdateBoxPosition(box);
            }
            // Bring the box to the front for proper display order
            box.BringToFront();
        }

      
        // Method to update the display position of a box
        private void UpdateBoxPosition(Tile box)
        {
            box.Left = INIT_LEFT + WIDTH * box.Column;
            box.Top = INIT_TOP + HEIGHT * box.Row;
        }

        // Method to remove a box from the game
        private void RemoveBox(Tile box)
        {
            // Remove the box from the form controls and clear its position in the tiles array
            Controls.Remove(box);
            tiles[box.Row, box.Column] = null;

            // Update remaining boxes count and display
            if (box.TileType == TileType.RedBox || box.TileType == TileType.GreenBox)
            {
                remainingBoxes--;
                UpdateRemainingBoxes();
            }
        }

        // Method to check if all boxes are removed from the game
        private bool AreAllBoxesRemoved()
        {
            foreach (Tile tile in tiles)
            {
                if (tile != null && (tile.TileType == TileType.RedBox || tile.TileType == TileType.GreenBox))
                {
                    return false;
                }
            }
            return true;
        }

        // Method to update the moves count in the UI
        private void UpdateMoves()
        {
            moves++;
            txtMoves.Text = moves.ToString();
        }

        // Enumeration for movement directions
        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

        // Method to reset the game state and UI
        private void ClearGame()
        {
            // Reset moves and remaining boxes counts
            moves = 0;
            remainingBoxes = 0;

            // Set tiles array to null
            tiles = null;

            // List to store controls to be removed from the form
            List<Control> controlsToRemove = new List<Control>();

            // Loop through form controls
            foreach (Control control in Controls)
            {
                // Check if the control is not a menu strip or a group box
                if (!(control is MenuStrip || control is GroupBox))
                {
                    // Add the control to the removal list
                    controlsToRemove.Add(control);
                }
                else if (control is GroupBox groupBox)
                {
                    // Loop through controls in the group box
                    foreach (Control groupBoxControl in groupBox.Controls)
                    {
                        // Reset text for textboxes and disable buttons
                        if (groupBoxControl is TextBox textBox)
                        {
                            textBox.Text = "0";
                        }
                        else if (groupBoxControl is Button button)
                        {
                            button.Enabled = false;
                        }
                    }
                }
            }
            // Remove controls from the form
            foreach (Control controlToRemove in controlsToRemove)
            {
                Controls.Remove(controlToRemove);
            }
            // Disable movement buttons
            SetControlsEnabled(false);
        }

        // Event handler for the "Up" button click
        private void btnUp_Click(object sender, EventArgs e)
        {
			ShiftBox(Direction.Up);
        }

        // Event handler for the "Left" button click
        private void btnLeft_Click(object sender, EventArgs e)
        {
			ShiftBox(Direction.Left);
        }

        // Event handler for the "Down" button click
        private void btnDown_Click(object sender, EventArgs e)
        {
            ShiftBox(Direction.Down);
        }

        // Event handler for the "Right" button click
        private void btnRight_Click(object sender, EventArgs e)
        {
            ShiftBox(Direction.Right);
        }

        // Event handler for the form load
        private void PlayForm_Load(object sender, EventArgs e)
        {
            // Disable movement buttons on form load
            SetControlsEnabled(false);
        }

        // Method to enable or disable movement buttons
        private void SetControlsEnabled(bool enabled)
        {
            btnUp.Enabled = enabled;
            btnLeft.Enabled = enabled;
            btnDown.Enabled = enabled;
            btnRight.Enabled = enabled;
        }
    }
}
