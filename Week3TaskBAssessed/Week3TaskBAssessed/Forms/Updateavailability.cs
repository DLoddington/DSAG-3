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
    public partial class Updateavailability : Form
    {
        public static Updateavailability instance;
        public Updateavailability()
        {
            InitializeComponent();
            instance = this;
            CenterToScreen();
        }

        private void UpdateStatusButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(IDTextBox.Text + " - are you sure you want to change the availability of this employee?", "Confirm employee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                Launch.instance.updateEmployeeAvail(IDTextBox.Text);
            else
                return;
        }
    }
}
