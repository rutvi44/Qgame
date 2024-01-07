namespace RMistryQGame
{
    partial class Design_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRows = new System.Windows.Forms.Label();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.lblColumns = new System.Windows.Forms.Label();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pcrBoXNone = new System.Windows.Forms.PictureBox();
            this.grpToolBox = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pcrRedBox = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pcrGreenBox = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pcrBoxRedDoor = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pcrBoxGreendoor = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pcrBoxWall = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrBoXNone)).BeginInit();
            this.grpToolBox.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrRedBox)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrGreenBox)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrBoxRedDoor)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrBoxGreendoor)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrBoxWall)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(753, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(6, 31);
            this.lblRows.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(40, 13);
            this.lblRows.TabIndex = 1;
            this.lblRows.Text = "Rows: ";
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(54, 30);
            this.txtRow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(103, 20);
            this.txtRow.TabIndex = 2;
            this.txtRow.TextChanged += new System.EventHandler(this.txtRow_TextChanged);
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(255, 32);
            this.lblColumns.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(53, 13);
            this.lblColumns.TabIndex = 3;
            this.lblColumns.Text = "Columns: ";
            // 
            // txtColumns
            // 
            this.txtColumns.Location = new System.Drawing.Point(327, 31);
            this.txtColumns.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(103, 20);
            this.txtColumns.TabIndex = 4;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(485, 27);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(131, 24);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pcrBoXNone);
            this.groupBox1.Location = new System.Drawing.Point(17, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(115, 68);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "None";
            // 
            // pcrBoXNone
            // 
            this.pcrBoXNone.Image = global::RMistryQGame.Properties.Resources.None;
            this.pcrBoXNone.Location = new System.Drawing.Point(10, 16);
            this.pcrBoXNone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcrBoXNone.Name = "pcrBoXNone";
            this.pcrBoXNone.Size = new System.Drawing.Size(41, 42);
            this.pcrBoXNone.TabIndex = 6;
            this.pcrBoXNone.TabStop = false;
            // 
            // grpToolBox
            // 
            this.grpToolBox.Controls.Add(this.groupBox6);
            this.grpToolBox.Controls.Add(this.groupBox5);
            this.grpToolBox.Controls.Add(this.groupBox4);
            this.grpToolBox.Controls.Add(this.groupBox3);
            this.grpToolBox.Controls.Add(this.groupBox2);
            this.grpToolBox.Controls.Add(this.label2);
            this.grpToolBox.Controls.Add(this.groupBox1);
            this.grpToolBox.Location = new System.Drawing.Point(13, 57);
            this.grpToolBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpToolBox.Name = "grpToolBox";
            this.grpToolBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpToolBox.Size = new System.Drawing.Size(151, 484);
            this.grpToolBox.TabIndex = 8;
            this.grpToolBox.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.pcrRedBox);
            this.groupBox6.Location = new System.Drawing.Point(14, 404);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Size = new System.Drawing.Size(119, 68);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Red Box";
            // 
            // pcrRedBox
            // 
            this.pcrRedBox.Image = global::RMistryQGame.Properties.Resources.Red_Box;
            this.pcrRedBox.Location = new System.Drawing.Point(10, 16);
            this.pcrRedBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcrRedBox.Name = "pcrRedBox";
            this.pcrRedBox.Size = new System.Drawing.Size(41, 42);
            this.pcrRedBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrRedBox.TabIndex = 6;
            this.pcrRedBox.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.pcrGreenBox);
            this.groupBox5.Location = new System.Drawing.Point(14, 332);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(119, 68);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Green Box";
            // 
            // pcrGreenBox
            // 
            this.pcrGreenBox.Image = global::RMistryQGame.Properties.Resources.Green_Box;
            this.pcrGreenBox.Location = new System.Drawing.Point(10, 16);
            this.pcrGreenBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcrGreenBox.Name = "pcrGreenBox";
            this.pcrGreenBox.Size = new System.Drawing.Size(41, 42);
            this.pcrGreenBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrGreenBox.TabIndex = 6;
            this.pcrGreenBox.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.pcrBoxRedDoor);
            this.groupBox4.Location = new System.Drawing.Point(17, 259);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(119, 68);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Red door";
            // 
            // pcrBoxRedDoor
            // 
            this.pcrBoxRedDoor.Image = global::RMistryQGame.Properties.Resources.Red_Door;
            this.pcrBoxRedDoor.Location = new System.Drawing.Point(10, 16);
            this.pcrBoxRedDoor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcrBoxRedDoor.Name = "pcrBoxRedDoor";
            this.pcrBoxRedDoor.Size = new System.Drawing.Size(41, 42);
            this.pcrBoxRedDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrBoxRedDoor.TabIndex = 6;
            this.pcrBoxRedDoor.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.pcrBoxGreendoor);
            this.groupBox3.Location = new System.Drawing.Point(17, 187);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(119, 68);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Green door";
            // 
            // pcrBoxGreendoor
            // 
            this.pcrBoxGreendoor.Image = global::RMistryQGame.Properties.Resources.Green_Door;
            this.pcrBoxGreendoor.Location = new System.Drawing.Point(10, 16);
            this.pcrBoxGreendoor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcrBoxGreendoor.Name = "pcrBoxGreendoor";
            this.pcrBoxGreendoor.Size = new System.Drawing.Size(41, 42);
            this.pcrBoxGreendoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrBoxGreendoor.TabIndex = 6;
            this.pcrBoxGreendoor.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pcrBoxWall);
            this.groupBox2.Location = new System.Drawing.Point(17, 115);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(115, 68);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wall";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pcrBoxWall
            // 
            this.pcrBoxWall.Image = global::RMistryQGame.Properties.Resources.Wall;
            this.pcrBoxWall.Location = new System.Drawing.Point(10, 16);
            this.pcrBoxWall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcrBoxWall.Name = "pcrBoxWall";
            this.pcrBoxWall.Size = new System.Drawing.Size(41, 42);
            this.pcrBoxWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrBoxWall.TabIndex = 6;
            this.pcrBoxWall.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tool Box";
            // 
            // Design_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 560);
            this.Controls.Add(this.grpToolBox);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtColumns);
            this.Controls.Add(this.lblColumns);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Design_Form";
            this.Text = "Design Form";
            this.Load += new System.EventHandler(this.Design_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrBoXNone)).EndInit();
            this.grpToolBox.ResumeLayout(false);
            this.grpToolBox.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrRedBox)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrGreenBox)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrBoxRedDoor)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrBoxGreendoor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrBoxWall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox pcrBoXNone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpToolBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pcrBoxWall;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pcrBoxGreendoor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pcrBoxRedDoor;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pcrGreenBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pcrRedBox;
    }
}