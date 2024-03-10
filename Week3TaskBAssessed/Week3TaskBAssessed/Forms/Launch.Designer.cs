namespace Week3TaskBAssessed
{
    partial class Launch
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
            this.RemoveEmployeeButton = new System.Windows.Forms.Button();
            this.EmployeeSearchButton = new System.Windows.Forms.Button();
            this.UpdateStatusButton = new System.Windows.Forms.Button();
            this.DisplayEmployeesButton = new System.Windows.Forms.Button();
            this.form1header = new System.Windows.Forms.Label();
            this.form1SubHeader = new System.Windows.Forms.Label();
            this.exitprogrammebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(122, 117);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(137, 23);
            this.AddEmployeeButton.TabIndex = 0;
            this.AddEmployeeButton.Text = "Add an Employee";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // RemoveEmployeeButton
            // 
            this.RemoveEmployeeButton.Location = new System.Drawing.Point(122, 159);
            this.RemoveEmployeeButton.Name = "RemoveEmployeeButton";
            this.RemoveEmployeeButton.Size = new System.Drawing.Size(137, 23);
            this.RemoveEmployeeButton.TabIndex = 1;
            this.RemoveEmployeeButton.Text = "Remove an Employee";
            this.RemoveEmployeeButton.UseVisualStyleBackColor = true;
            this.RemoveEmployeeButton.Click += new System.EventHandler(this.RemoveEmployeeButton_Click);
            // 
            // EmployeeSearchButton
            // 
            this.EmployeeSearchButton.Location = new System.Drawing.Point(122, 203);
            this.EmployeeSearchButton.Name = "EmployeeSearchButton";
            this.EmployeeSearchButton.Size = new System.Drawing.Size(137, 23);
            this.EmployeeSearchButton.TabIndex = 2;
            this.EmployeeSearchButton.Text = "Search Employee by ID";
            this.EmployeeSearchButton.UseVisualStyleBackColor = true;
            this.EmployeeSearchButton.Click += new System.EventHandler(this.EmployeeSearchButton_Click);
            // 
            // UpdateStatusButton
            // 
            this.UpdateStatusButton.Location = new System.Drawing.Point(122, 247);
            this.UpdateStatusButton.Name = "UpdateStatusButton";
            this.UpdateStatusButton.Size = new System.Drawing.Size(137, 23);
            this.UpdateStatusButton.TabIndex = 3;
            this.UpdateStatusButton.Text = "Update Employee Status";
            this.UpdateStatusButton.UseVisualStyleBackColor = true;
            this.UpdateStatusButton.Click += new System.EventHandler(this.UpdateStatusButton_Click);
            // 
            // DisplayEmployeesButton
            // 
            this.DisplayEmployeesButton.Location = new System.Drawing.Point(122, 290);
            this.DisplayEmployeesButton.Name = "DisplayEmployeesButton";
            this.DisplayEmployeesButton.Size = new System.Drawing.Size(137, 23);
            this.DisplayEmployeesButton.TabIndex = 4;
            this.DisplayEmployeesButton.Text = "Display all Employees";
            this.DisplayEmployeesButton.UseVisualStyleBackColor = true;
            this.DisplayEmployeesButton.Click += new System.EventHandler(this.DisplayEmployeesButton_Click);
            // 
            // form1header
            // 
            this.form1header.AutoSize = true;
            this.form1header.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form1header.Location = new System.Drawing.Point(81, 44);
            this.form1header.Name = "form1header";
            this.form1header.Size = new System.Drawing.Size(227, 16);
            this.form1header.TabIndex = 5;
            this.form1header.Text = "Welcome to the Employee database";
            // 
            // form1SubHeader
            // 
            this.form1SubHeader.AutoSize = true;
            this.form1SubHeader.Location = new System.Drawing.Point(96, 81);
            this.form1SubHeader.Name = "form1SubHeader";
            this.form1SubHeader.Size = new System.Drawing.Size(192, 13);
            this.form1SubHeader.TabIndex = 6;
            this.form1SubHeader.Text = "Please select from the following options";
            // 
            // exitprogrammebutton
            // 
            this.exitprogrammebutton.Location = new System.Drawing.Point(122, 332);
            this.exitprogrammebutton.Name = "exitprogrammebutton";
            this.exitprogrammebutton.Size = new System.Drawing.Size(137, 23);
            this.exitprogrammebutton.TabIndex = 7;
            this.exitprogrammebutton.Text = "Exit Programme";
            this.exitprogrammebutton.UseVisualStyleBackColor = true;
            this.exitprogrammebutton.Click += new System.EventHandler(this.exitprogrammebutton_Click);
            // 
            // Launch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 388);
            this.Controls.Add(this.exitprogrammebutton);
            this.Controls.Add(this.form1SubHeader);
            this.Controls.Add(this.form1header);
            this.Controls.Add(this.DisplayEmployeesButton);
            this.Controls.Add(this.UpdateStatusButton);
            this.Controls.Add(this.EmployeeSearchButton);
            this.Controls.Add(this.RemoveEmployeeButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Name = "Launch";
            this.Text = "Launch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button RemoveEmployeeButton;
        private System.Windows.Forms.Button EmployeeSearchButton;
        private System.Windows.Forms.Button UpdateStatusButton;
        private System.Windows.Forms.Button DisplayEmployeesButton;
        private System.Windows.Forms.Label form1header;
        private System.Windows.Forms.Label form1SubHeader;
        private System.Windows.Forms.Button exitprogrammebutton;
    }
}

