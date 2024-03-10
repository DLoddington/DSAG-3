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
    public partial class Remove : Form
    {
        public static Remove instance;
        public Remove()
        {
            InitializeComponent();
            instance = this;
            CenterToScreen();
        }

        private void RemoveEmployeeButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(IDTextBox.Text + " - are you sure you want to remove this employee?", "Confirm employee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                Launch.instance.removeEmployee(IDTextBox.Text);
            else
                return;
        }
    }
}
