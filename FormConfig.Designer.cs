namespace Lab
{
    partial class FormConfig
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
            this.labelTractor = new System.Windows.Forms.Label();
            this.labelExcavatorTractor = new System.Windows.Forms.Label();
            this.picturePanel = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelDarkGray = new System.Windows.Forms.Panel();
            this.panelTurquoise = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelBeige = new System.Windows.Forms.Panel();
            this.panelLightGray = new System.Windows.Forms.Panel();
            this.panelLightBlue = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.picturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTractor
            // 
            this.labelTractor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTractor.Location = new System.Drawing.Point(26, 39);
            this.labelTractor.Name = "labelTractor";
            this.labelTractor.Size = new System.Drawing.Size(117, 34);
            this.labelTractor.TabIndex = 2;
            this.labelTractor.Text = "Tractor";
            this.labelTractor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTractor_MouseDown);
            // 
            // labelExcavatorTractor
            // 
            this.labelExcavatorTractor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelExcavatorTractor.Location = new System.Drawing.Point(25, 85);
            this.labelExcavatorTractor.Name = "labelExcavatorTractor";
            this.labelExcavatorTractor.Size = new System.Drawing.Size(118, 44);
            this.labelExcavatorTractor.TabIndex = 3;
            this.labelExcavatorTractor.Text = "Excavator Tractor";
            this.labelExcavatorTractor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelExcavatorTractor_MouseDown);
            // 
            // picturePanel
            // 
            this.picturePanel.AllowDrop = true;
            this.picturePanel.Controls.Add(this.labelDopColor);
            this.picturePanel.Controls.Add(this.labelMainColor);
            this.picturePanel.Controls.Add(this.pictureBox);
            this.picturePanel.Location = new System.Drawing.Point(244, 39);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(217, 228);
            this.picturePanel.TabIndex = 4;
            this.picturePanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.picturePanel_DragDrop);
            this.picturePanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.picturePanel_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(39, 190);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(134, 29);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Dop color";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(39, 151);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(134, 29);
            this.labelMainColor.TabIndex = 1;
            this.labelMainColor.Text = "Main color";
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(26, 19);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(161, 115);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelWhite.Location = new System.Drawing.Point(515, 30);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(49, 43);
            this.panelWhite.TabIndex = 5;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelBlue.Location = new System.Drawing.Point(515, 79);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(49, 43);
            this.panelBlue.TabIndex = 6;
            // 
            // panelDarkGray
            // 
            this.panelDarkGray.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelDarkGray.Location = new System.Drawing.Point(515, 128);
            this.panelDarkGray.Name = "panelDarkGray";
            this.panelDarkGray.Size = new System.Drawing.Size(49, 43);
            this.panelDarkGray.TabIndex = 6;
            // 
            // panelTurquoise
            // 
            this.panelTurquoise.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTurquoise.Location = new System.Drawing.Point(515, 177);
            this.panelTurquoise.Name = "panelTurquoise";
            this.panelTurquoise.Size = new System.Drawing.Size(49, 43);
            this.panelTurquoise.TabIndex = 6;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelBlack.Location = new System.Drawing.Point(570, 31);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(49, 43);
            this.panelBlack.TabIndex = 6;
            // 
            // panelBeige
            // 
            this.panelBeige.BackColor = System.Drawing.SystemColors.Info;
            this.panelBeige.Location = new System.Drawing.Point(570, 80);
            this.panelBeige.Name = "panelBeige";
            this.panelBeige.Size = new System.Drawing.Size(49, 43);
            this.panelBeige.TabIndex = 6;
            // 
            // panelLightGray
            // 
            this.panelLightGray.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelLightGray.Location = new System.Drawing.Point(570, 128);
            this.panelLightGray.Name = "panelLightGray";
            this.panelLightGray.Size = new System.Drawing.Size(49, 43);
            this.panelLightGray.TabIndex = 6;
            // 
            // panelLightBlue
            // 
            this.panelLightBlue.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelLightBlue.Location = new System.Drawing.Point(570, 177);
            this.panelLightBlue.Name = "panelLightBlue";
            this.panelLightBlue.Size = new System.Drawing.Size(49, 43);
            this.panelLightBlue.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(30, 171);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 31);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(30, 208);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 32);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 296);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panelLightBlue);
            this.Controls.Add(this.panelLightGray);
            this.Controls.Add(this.panelBeige);
            this.Controls.Add(this.panelBlack);
            this.Controls.Add(this.panelTurquoise);
            this.Controls.Add(this.panelDarkGray);
            this.Controls.Add(this.panelBlue);
            this.Controls.Add(this.panelWhite);
            this.Controls.Add(this.picturePanel);
            this.Controls.Add(this.labelExcavatorTractor);
            this.Controls.Add(this.labelTractor);
            this.Name = "FormConfig";
            this.Text = "FormConfig";
            this.picturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTractor;
        private System.Windows.Forms.Label labelExcavatorTractor;
        private System.Windows.Forms.Panel picturePanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelDarkGray;
        private System.Windows.Forms.Panel panelTurquoise;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelBeige;
        private System.Windows.Forms.Panel panelLightGray;
        private System.Windows.Forms.Panel panelLightBlue;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}