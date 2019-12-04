namespace Lab4
{
    partial class FormParking
    {
        private System.ComponentModel.IContainer components = null;
        
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonSetTractor = new System.Windows.Forms.Button();
            this.buttonSetExcavatorTractor = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakeTractor = new System.Windows.Forms.PictureBox();
            this.buttonTakeTractor = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeTractor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(2, 12);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1329, 753);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonSetTractor
            // 
            this.buttonSetTractor.Location = new System.Drawing.Point(1353, 313);
            this.buttonSetTractor.Name = "buttonSetTractor";
            this.buttonSetTractor.Size = new System.Drawing.Size(133, 45);
            this.buttonSetTractor.TabIndex = 1;
            this.buttonSetTractor.Text = "Set Tractor";
            this.buttonSetTractor.UseVisualStyleBackColor = true;
            this.buttonSetTractor.Click += new System.EventHandler(this.buttonSetTractor_Click);
            // 
            // buttonSetExcavatorTractor
            // 
            this.buttonSetExcavatorTractor.Location = new System.Drawing.Point(1353, 375);
            this.buttonSetExcavatorTractor.Name = "buttonSetExcavatorTractor";
            this.buttonSetExcavatorTractor.Size = new System.Drawing.Size(129, 57);
            this.buttonSetExcavatorTractor.TabIndex = 2;
            this.buttonSetExcavatorTractor.Text = "Set Excavator Tractor";
            this.buttonSetExcavatorTractor.UseVisualStyleBackColor = true;
            this.buttonSetExcavatorTractor.Click += new System.EventHandler(this.buttonSetExcavatorTractor_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.pictureBoxTakeTractor);
            this.groupBox.Controls.Add(this.buttonTakeTractor);
            this.groupBox.Controls.Add(this.maskedTextBox);
            this.groupBox.Controls.Add(this.labelPosition);
            this.groupBox.Location = new System.Drawing.Point(1353, 500);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(152, 265);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Take Tractor";
            // 
            // pictureBoxTakeTractor
            // 
            this.pictureBoxTakeTractor.Location = new System.Drawing.Point(10, 137);
            this.pictureBoxTakeTractor.Name = "pictureBoxTakeTractor";
            this.pictureBoxTakeTractor.Size = new System.Drawing.Size(133, 117);
            this.pictureBoxTakeTractor.TabIndex = 3;
            this.pictureBoxTakeTractor.TabStop = false;
            // 
            // buttonTakeTractor
            // 
            this.buttonTakeTractor.Location = new System.Drawing.Point(10, 73);
            this.buttonTakeTractor.Name = "buttonTakeTractor";
            this.buttonTakeTractor.Size = new System.Drawing.Size(133, 49);
            this.buttonTakeTractor.TabIndex = 2;
            this.buttonTakeTractor.Text = "Take Tractor";
            this.buttonTakeTractor.UseVisualStyleBackColor = true;
            this.buttonTakeTractor.Click += new System.EventHandler(this.buttonTakeTractor_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(81, 31);
            this.maskedTextBox.Mask = "00";
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(39, 26);
            this.maskedTextBox.TabIndex = 1;
            this.maskedTextBox.ValidatingType = typeof(int);
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(6, 34);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(69, 20);
            this.labelPosition.TabIndex = 0;
            this.labelPosition.Text = "Position:";
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.ItemHeight = 20;
            this.listBoxLevels.Location = new System.Drawing.Point(1353, 13);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(120, 244);
            this.listBoxLevels.TabIndex = 4;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 798);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonSetExcavatorTractor);
            this.Controls.Add(this.buttonSetTractor);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeTractor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonSetTractor;
        private System.Windows.Forms.Button buttonSetExcavatorTractor;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Button buttonTakeTractor;
        private System.Windows.Forms.PictureBox pictureBoxTakeTractor;
        private System.Windows.Forms.ListBox listBoxLevels;
    }
}