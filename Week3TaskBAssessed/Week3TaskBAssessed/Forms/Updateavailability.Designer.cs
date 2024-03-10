namespace Week3TaskBAssessed
{
    partial class Updateavailability
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
            this.form5header = new System.Windows.Forms.Label();
            this.UpdateStatusButton = new System.Windows.Forms.Button();
            this.identrylabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // form5header
            // 
            this.form5header.AutoSize = true;
            this.form5header.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form5header.Location = new System.Drawing.Point(33, 20);
            this.form5header.Name = "form5header";
            this.form5header.Size = new System.Drawing.Size(155, 16);
            this.form5header.TabIndex = 6;
            this.form5header.Text = "Update employee status";
            // 
            // UpdateStatusButton
            // 
            this.UpdateStatusButton.Location = new System.Drawing.Point(53, 113);
            this.UpdateStatusButton.Name = "UpdateStatusButton";
            this.UpdateStatusButton.Size = new System.Drawing.Size(98, 23);
            this.UpdateStatusButton.TabIndex = 11;
            this.UpdateStatusButton.Text = "Update status";
            this.UpdateStatusButton.UseVisualStyleBackColor = true;
            this.UpdateStatusButton.Click += new System.EventHandler(this.UpdateStatusButton_Click);
            // 
            // identrylabel
            // 
            this.identrylabel.AutoSize = true;
            this.identrylabel.Location = new System.Drawing.Point(35, 61);
            this.identrylabel.Name = "identrylabel";
            this.identrylabel.Size = new System.Drawing.Size(18, 13);
            this.identrylabel.TabIndex = 10;
            this.identrylabel.Text = "ID";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(38, 77);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(140, 20);
            this.IDTextBox.TabIndex = 12;
            // 
            // Updateavailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 171);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.UpdateStatusButton);
            this.Controls.Add(this.identrylabel);
            this.Controls.Add(this.form5header);
            this.Name = "Updateavailability";
            this.Text = "Update Employee Availability";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form5header;
        private System.Windows.Forms.Button UpdateStatusButton;
        private System.Windows.Forms.Label identrylabel;
        private System.Windows.Forms.TextBox IDTextBox;
    }
}