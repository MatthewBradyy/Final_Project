namespace Final_Project
{
    partial class Lab_display
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
            this.lbl_LabName = new System.Windows.Forms.Label();
            this.lbl_LabNumber = new System.Windows.Forms.Label();
            this.lbl_discription = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_LabName
            // 
            this.lbl_LabName.AutoSize = true;
            this.lbl_LabName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LabName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LabName.Location = new System.Drawing.Point(13, 13);
            this.lbl_LabName.Name = "lbl_LabName";
            this.lbl_LabName.Size = new System.Drawing.Size(312, 69);
            this.lbl_LabName.TabIndex = 0;
            this.lbl_LabName.Text = "Lab Name";
            // 
            // lbl_LabNumber
            // 
            this.lbl_LabNumber.AutoSize = true;
            this.lbl_LabNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LabNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LabNumber.Location = new System.Drawing.Point(58, 82);
            this.lbl_LabNumber.Name = "lbl_LabNumber";
            this.lbl_LabNumber.Size = new System.Drawing.Size(134, 29);
            this.lbl_LabNumber.TabIndex = 1;
            this.lbl_LabNumber.Text = "lab number";
            // 
            // lbl_discription
            // 
            this.lbl_discription.AutoSize = true;
            this.lbl_discription.BackColor = System.Drawing.Color.Transparent;
            this.lbl_discription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discription.Location = new System.Drawing.Point(13, 125);
            this.lbl_discription.Name = "lbl_discription";
            this.lbl_discription.Size = new System.Drawing.Size(90, 20);
            this.lbl_discription.TabIndex = 2;
            this.lbl_discription.Text = "Discription";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Run Program";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(392, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 58);
            this.button2.TabIndex = 4;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(226, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 58);
            this.button3.TabIndex = 4;
            this.button3.Text = "Code";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Lab_display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(587, 366);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_discription);
            this.Controls.Add(this.lbl_LabNumber);
            this.Controls.Add(this.lbl_LabName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lab_display";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab_display";
            this.Load += new System.EventHandler(this.Lab_display_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_LabName;
        private System.Windows.Forms.Label lbl_LabNumber;
        private System.Windows.Forms.Label lbl_discription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}