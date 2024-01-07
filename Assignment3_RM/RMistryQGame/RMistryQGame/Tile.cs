/* 
 * Name : RMistryQGame (Assignment3)
 * Revision History: 11/21/2023 Creted:Rutvi Mistry
 */
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RMistryQGame
{
    public class Tile : PictureBox
    {
        // Properties for the row, column, tile type, and selection state of the tile
        public int Row { get; set; }
        public int Column { get; set; }
        public TileType TileType { get; set; }
        public bool IsSelected { get; set; }

        // Event to be triggered when the box on the tile is clicked
        public event EventHandler BoxClicked;

        // Override the OnClick method to handle box click events
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            BoxClicked?.Invoke(this, EventArgs.Empty);
        }

        // Constructor for the Tile class
        public Tile(int row, int col, TileType type)
        {
            Row = row;
            Column = col;
            TileType = type;
            IsSelected = false;
            InitializeTile();
            
        }

        // Method to initialize the tile by setting its image based on the tile type
        private void InitializeTile()
        {
            // Set the image based on the tile type
            SetImageBasedOnType();
        }

        // Method to set the image of the tile based on its type
        private void SetImageBasedOnType()
        {
            // Switch statement to handle different tile types
            switch (TileType)
            {
                // No image for None type
                // Set the image to represent a wall, greendoor, greenbox, reddoor and redbox

                case TileType.None:                  
                    break;
                case TileType.Wall:
                    Image = Properties.Resources.Wall;
                    break;
                case TileType.RedDoor:
                    SetDoorImage();
                    break;
                case TileType.GreenDoor:
                    SetDoorImage();
                    break;
                case TileType.RedBox:
                    SetBoxImage();
                    break;
                case TileType.GreenBox:
                    SetBoxImage();
                    break;
            }
        }

        // Method to set the image for a door based on its type
        private void SetDoorImage()
        {
            // Switch statement to handle different door types by setting reddoor and greendoor images 
            switch (TileType)
            {
                case TileType.RedDoor:
                    Image = Properties.Resources.Red_Door;
                    break;
                case TileType.GreenDoor:
                    Image = Properties.Resources.Green_Door;
                    break;
            }
        }

        // Method to set the image for a box based on its type
        public void SetBoxImage()
        {
            // Switch statement to handle different box types bt setting redbox and greenbox images
            switch (TileType)
            {
                case TileType.RedBox:
                    Image = Properties.Resources.Red_Box;
                    break;
                case TileType.GreenBox:
                    Image = Properties.Resources.Green_Box; 
                    break;
            }
        }
    }

    // Enum to represent different tile types
    public enum TileType
    {
        None = 0,
        Wall = 1,
        RedDoor = 2,
        GreenDoor = 3,
        RedBox = 6,
        GreenBox = 7
    }

    
}
