namespace Week3TaskBAssessed
{
    partial class Search
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
            this.form4header = new System.Windows.Forms.Label();
            this.SearchEmployeeButton = new System.Windows.Forms.Button();
            this.idlabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // form4header
            // 
            this.form4header.AutoSize = true;
            this.form4header.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form4header.Location = new System.Drawing.Point(25, 22);
            this.form4header.Name = "form4header";
            this.form4header.Size = new System.Drawing.Size(149, 16);
            this.form4header.TabIndex = 6;
            this.form4header.Text = "Search employee by ID";
            // 
            // SearchEmployeeButton
            // 
            this.SearchEmployeeButton.Location = new System.Drawing.Point(49, 107);
            this.SearchEmployeeButton.Name = "SearchEmployeeButton";
            this.SearchEmployeeButton.Size = new System.Drawing.Size(90, 23);
            this.SearchEmployeeButton.TabIndex = 11;
            this.SearchEmployeeButton.Text = "Search";
            this.SearchEmployeeButton.UseVisualStyleBackColor = true;
            this.SearchEmployeeButton.Click += new System.EventHandler(this.SearchEmployeeButton_Click);
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(35, 51);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(18, 13);
            this.idlabel.TabIndex = 10;
            this.idlabel.Text = "ID";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(38, 67);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(114, 20);
            this.IDTextBox.TabIndex = 12;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 167);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.SearchEmployeeButton);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.form4header);
            this.Name = "Search";
            this.Text = "Search Employees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form4header;
        private System.Windows.Forms.Button SearchEmployeeButton;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.TextBox IDTextBox;
    }
}