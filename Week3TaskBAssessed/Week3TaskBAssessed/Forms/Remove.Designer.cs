namespace Week3TaskBAssessed
{
    partial class Remove
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
            this.form3header = new System.Windows.Forms.Label();
            this.identrylabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.RemoveEmployeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // form3header
            // 
            this.form3header.AutoSize = true;
            this.form3header.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form3header.Location = new System.Drawing.Point(27, 26);
            this.form3header.Name = "form3header";
            this.form3header.Size = new System.Drawing.Size(143, 16);
            this.form3header.TabIndex = 3;
            this.form3header.Text = "Remove an Employee";
            // 
            // identrylabel
            // 
            this.identrylabel.AutoSize = true;
            this.identrylabel.Location = new System.Drawing.Point(27, 53);
            this.identrylabel.Name = "identrylabel";
            this.identrylabel.Size = new System.Drawing.Size(18, 13);
            this.identrylabel.TabIndex = 6;
            this.identrylabel.Text = "ID";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(30, 69);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(140, 20);
            this.IDTextBox.TabIndex = 5;
            // 
            // RemoveEmployeeButton
            // 
            this.RemoveEmployeeButton.Location = new System.Drawing.Point(46, 104);
            this.RemoveEmployeeButton.Name = "RemoveEmployeeButton";
            this.RemoveEmployeeButton.Size = new System.Drawing.Size(105, 23);
            this.RemoveEmployeeButton.TabIndex = 8;
            this.RemoveEmployeeButton.Text = "Remove";
            this.RemoveEmployeeButton.UseVisualStyleBackColor = true;
            this.RemoveEmployeeButton.Click += new System.EventHandler(this.RemoveEmployeeButton_Click);
            // 
            // Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 156);
            this.Controls.Add(this.RemoveEmployeeButton);
            this.Controls.Add(this.identrylabel);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.form3header);
            this.Name = "Remove";
            this.Text = "Remove Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form3header;
        private System.Windows.Forms.Label identrylabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Button RemoveEmployeeButton;
    }
}