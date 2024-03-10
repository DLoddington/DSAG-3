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
    public partial class Launch : Form
    {

        public static Dictionary<int, Employee> employees = new Dictionary<int, Employee>();
        public static Launch instance;

        public Launch()
        {
            InitializeComponent();
            instance = this;
            CenterToScreen();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            var newForm = new Add();
            newForm.ShowDialog();
        }

        private void RemoveEmployeeButton_Click(object sender, EventArgs e)
        {
            var newForm = new Remove();
            newForm.ShowDialog();
        }

        private void EmployeeSearchButton_Click(object sender, EventArgs e)
        {
            var newForm = new Search();
            newForm.ShowDialog();
        }

        private void UpdateStatusButton_Click(object sender, EventArgs e)
        {
            var newForm = new Updateavailability();
            newForm.ShowDialog();
        }

        private void DisplayEmployeesButton_Click(object sender, EventArgs e)
        {
            var newForm = new Displayemployees();
            newForm.ShowDialog();
        }
        private bool testIDAsInt(string id) // want to test if the ID entered is an int
        {
            try
            {
                Int32.Parse(id);
            }
            catch (FormatException e)
            {
                DialogResult dialogResult = MessageBox.Show("Employee ID needs to be a number with no letters, sybmols or spaces.", "ID number error", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK)
                { return false; }
            }
            return true;
        }

        private bool testIDExists(int id) //bool to test if the ID exists
        {
            if (employees.Keys.Contains<int>(id))
            {
                return true;
            }
            return false;
        }

        private void duplicateID(int id) //function for duplicate ID entry when we need non-duplicate
        {
            DialogResult dialogResult = MessageBox.Show("Employee ID needs to unique, please try again", "ID duplicate error", MessageBoxButtons.OK);
            if (dialogResult == DialogResult.OK)
            { return; }
        }

        private void nonDuplicateID(int id) //function for non-duplicate ID entry when we need duplicate
        {
            DialogResult dialogResult = MessageBox.Show("No Employee exists with that ID, please try again", "ID not found error", MessageBoxButtons.OK);
            if (dialogResult == DialogResult.OK)
            { return; }
        }

        internal void receiveNewEmployeeData(string id, string firstName, string surname)
        {
            if(testIDAsInt(id) == false) //test id can be parsed to int
                return; //boot out of function if cant be parsed
            int idAsInt = Int32.Parse(id); //parse string of id to int
            if (testIDExists(idAsInt) == true) //test id isnt a duplicate
            {
                duplicateID(idAsInt); //message box error if it is duplicate
                return; //boot out of function
            }
            Employee e1 = new Employee(idAsInt, (firstName + " " + surname)); //make employee with Id as int, and name as concatonation of first and surname
            employees[e1.Id] = e1; //make dictionary entry for employee with id as key for key value pair
            DialogResult Result = MessageBox.Show("Success! The new employee has been added.", "Employee add confirmation", MessageBoxButtons.OK); //confirmation message
            if (Result == DialogResult.OK)
                Add.instance.Close(); //close the add window we opened
        }

        internal void removeEmployee(string id)
        {
            if (testIDAsInt(id) == false)
                return;
            int idAsInt = Int32.Parse(id);
            if (testIDExists(idAsInt) == false) //this time test if the id CAN be found
            {
                nonDuplicateID(idAsInt); //message box error if it cant be found in dictionary
                return; //boot out of function
            }
            employees.Remove(idAsInt); //remove from dictionary, entry with key of the id that was input
            DialogResult Result = MessageBox.Show("Success! The employee has been removed", "Employee remove confirmation", MessageBoxButtons.OK);
            if (Result == DialogResult.OK)
                Remove.instance.Close(); 
        }

        private Employee returnEmployee(int id)
        {
            foreach (KeyValuePair<int,Employee> e in employees)
            {
                if(e.Value.Id == id)
                    return e.Value;
            }
            return null; //need to add, but wont ever be null as we have functions to check existance of Employee in dictionary already - so will be no null associated errors
        }

        internal void searchEmployee(string id)
        {
            if (testIDAsInt(id) == false)
                return;
            int idAsInt = Int32.Parse(id);
            if (testIDExists(idAsInt) == false) 
            {
                nonDuplicateID(idAsInt); 
                return;
            }
            Employee e = returnEmployee(idAsInt);
            DialogResult result = MessageBox.Show(e.GetSummary(), "Search result", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
                Search.instance.Close();
        }

        internal void displayEmployee(string id)
        {
            int idAsInt = Int32.Parse(id);
            Employee e = returnEmployee(idAsInt); 
            DialogResult result = MessageBox.Show(e.GetSummary(), "Search result", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
                return;
        }

        internal void updateEmployeeAvail(string id)
        {
            if (testIDAsInt(id) == false)
                return;
            int idAsInt = Int32.Parse(id);
            if (testIDExists(idAsInt) == false)
            {
                nonDuplicateID(idAsInt);
                return;
            }
            Employee e = returnEmployee(idAsInt);
            string oppAvail = availOpposite(e); //get the opposite of current availability for message box
            DialogResult result = MessageBox.Show("Change the status of " + e.Id + " to " + oppAvail + "?", "Search result", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (e.Avail == true)
                    e.Avail = false;
                else
                    e.Avail = true;
                DialogResult result2 = MessageBox.Show("Success! The employee status has been updated", "Update availability result", MessageBoxButtons.OK);
                if (result2 == DialogResult.OK)
                    Updateavailability.instance.Close();
            }
            else return;
        }

        private string availOpposite(Employee e)
        {
            if(e.Avail == true)
                return "unavailable";
            return "available";
        }

        private void exitprogrammebutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
