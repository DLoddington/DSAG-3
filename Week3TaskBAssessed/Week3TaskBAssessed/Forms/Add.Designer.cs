namespace Week3TaskBAssessed
{
    partial class Add
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
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.form2header = new System.Windows.Forms.Label();
            this.firstnameentrylabel = new System.Windows.Forms.Label();
            this.identrylabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.surnameentrylabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(64, 169);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(113, 23);
            this.AddEmployeeButton.TabIndex = 0;
            this.AddEmployeeButton.Text = "Add";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(64, 63);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(113, 20);
            this.IDTextBox.TabIndex = 1;
            // 
            // form2header
            // 
            this.form2header.AutoSize = true;
            this.form2header.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form2header.Location = new System.Drawing.Point(61, 19);
            this.form2header.Name = "form2header";
            this.form2header.Size = new System.Drawing.Size(116, 16);
            this.form2header.TabIndex = 2;
            this.form2header.Text = "Add an Employee";
            // 
            // firstnameentrylabel
            // 
            this.firstnameentrylabel.AutoSize = true;
            this.firstnameentrylabel.Location = new System.Drawing.Point(12, 97);
            this.firstnameentrylabel.Name = "firstnameentrylabel";
            this.firstnameentrylabel.Size = new System.Drawing.Size(55, 13);
            this.firstnameentrylabel.TabIndex = 3;
            this.firstnameentrylabel.Text = "First name";
            // 
            // identrylabel
            // 
            this.identrylabel.AutoSize = true;
            this.identrylabel.Location = new System.Drawing.Point(61, 47);
            this.identrylabel.Name = "identrylabel";
            this.identrylabel.Size = new System.Drawing.Size(18, 13);
            this.identrylabel.TabIndex = 4;
            this.identrylabel.Text = "ID";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(12, 113);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(98, 20);
            this.FirstNameTextBox.TabIndex = 5;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(131, 113);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(113, 20);
            this.SurnameTextBox.TabIndex = 6;
            // 
            // surnameentrylabel
            // 
            this.surnameentrylabel.AutoSize = true;
            this.surnameentrylabel.Location = new System.Drawing.Point(128, 97);
            this.surnameentrylabel.Name = "surnameentrylabel";
            this.surnameentrylabel.Size = new System.Drawing.Size(49, 13);
            this.surnameentrylabel.TabIndex = 7;
            this.surnameentrylabel.Text = "Surname";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 204);
            this.Controls.Add(this.surnameentrylabel);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.identrylabel);
            this.Controls.Add(this.firstnameentrylabel);
            this.Controls.Add(this.form2header);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.AddEmployeeButton);
            this.Name = "Add";
            this.Text = "Add Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Label form2header;
        private System.Windows.Forms.Label firstnameentrylabel;
        private System.Windows.Forms.Label identrylabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label surnameentrylabel;
        private System.Windows.Forms.TextBox IDTextBox;
    }
}