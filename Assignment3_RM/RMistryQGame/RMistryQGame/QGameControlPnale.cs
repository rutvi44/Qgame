/* 
 * Name : RMistryQGame (Assignment2)
 * Revision History: 11/2/2023 Creted:Rutvi Mistry
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

namespace RMistryQGame
{
    public partial class QGameControlPanel : Form
    {
        public QGameControlPanel()
        {
            InitializeComponent();
        }
        
        //Event Handler for opening design_form when Design Button is clicked.
        private void btnDesign_Click(object sender, EventArgs e)
        {
            // When the "Design" button is clicked, open the Design_Form

            Design_Form designForm = new Design_Form();
            designForm.Show();
        }

        //Event Handler for Exit button to exit this whole application.
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayForm playForm = new PlayForm();
            playForm.Show();
        }
    }
}
