namespace Week3TaskBAssessed
{
    partial class Displayemployees
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
            this.form6header = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeListBox = new System.Windows.Forms.ListBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // form6header
            // 
            this.form6header.AutoSize = true;
            this.form6header.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form6header.Location = new System.Drawing.Point(62, 25);
            this.form6header.Name = "form6header";
            this.form6header.Size = new System.Drawing.Size(142, 16);
            this.form6header.TabIndex = 6;
            this.form6header.Text = "Display all employees";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Click on an employee for more details";
            // 
            // EmployeeListBox
            // 
            this.EmployeeListBox.FormattingEnabled = true;
            this.EmployeeListBox.Location = new System.Drawing.Point(31, 86);
            this.EmployeeListBox.Name = "EmployeeListBox";
            this.EmployeeListBox.Size = new System.Drawing.Size(214, 212);
            this.EmployeeListBox.TabIndex = 10;
            this.EmployeeListBox.Click += new System.EventHandler(this.EmployeeListBox_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(101, 315);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 11;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // Displayemployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 370);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.EmployeeListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.form6header);
            this.Name = "Displayemployees";
            this.Text = "Display Employees";
            this.Load += new System.EventHandler(this.Displayemployees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form6header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox EmployeeListBox;
        private System.Windows.Forms.Button returnButton;
    }
}