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
    public partial class Search : Form
    {
        public static Search instance;
        public Search()
        {
            InitializeComponent();
            instance = this;
            CenterToScreen();
        }

        private void SearchEmployeeButton_Click(object sender, EventArgs e)
        {
            Launch.instance.searchEmployee(IDTextBox.Text);
        }
    }
}
