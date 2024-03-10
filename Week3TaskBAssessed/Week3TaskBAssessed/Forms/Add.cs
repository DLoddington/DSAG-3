using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3TaskBAssessed
{
    public partial class Add : Form
    {
        public static Add instance;
        public Add()
        {
            InitializeComponent();
            instance = this;
            CenterToScreen();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(IDTextBox.Text + " - " + FirstNameTextBox.Text + " " + SurnameTextBox.Text + ": is this correct?", "Confirm employee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                Launch.instance.receiveNewEmployeeData(IDTextBox.Text, FirstNameTextBox.Text, SurnameTextBox.Text);
            else
                return;
        }
    }
}
