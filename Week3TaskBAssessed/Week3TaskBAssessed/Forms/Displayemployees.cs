using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week3TaskBAssessed.Classes;

namespace Week3TaskBAssessed
{
    public partial class Displayemployees : Form
    {
        public static Displayemployees instance;
        
        public Displayemployees()
        {
            InitializeComponent();
            instance = this;
            CenterToScreen();
        }

        private void Displayemployees_Load(object sender, EventArgs e)
        {
            showList();
        }

        private void EmployeeListBox_Click(object sender, EventArgs e)
        {
            if (EmployeeListBox.SelectedItem != null)
            {
                string key = EmployeeListBox.SelectedItem.ToString();
                Launch.instance.displayEmployee(key);
            }
        }

        private void showList()
        {
            foreach (KeyValuePair<int, Employee> n in Launch.employees)
                EmployeeListBox.Items.Add(n.Value.Id);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
