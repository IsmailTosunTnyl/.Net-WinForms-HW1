using System.Windows.Forms;

namespace HW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Employee> employees = new List<Employee>();
        List<Customer> customers = new List<Customer>();

        public void clearTxtBox()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();

            int ID = Convert.ToInt32(textBox_ID.Text);
            string FirstName = textBox_fN.Text;
            string LastName = textBox_lN.Text;
            string Address = textBox_address.Text;

            cus.ID = ID;
            cus.FirstName = FirstName;
            cus.LastName = LastName;
            cus.Address = Address;
            
            customers.Add(cus);
            comboBox_custID.Items.Add(cus.ID);
            clearTxtBox();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].ID == Convert.ToInt32(comboBox_custID.Text))
                {
                    customers.RemoveAt(i);
                    comboBox_custID.Items.RemoveAt(i);
                }
            }
            listBox.Items.Clear();
            foreach (Employee emp in employees)
                listBox.Items.Add(emp.FirstName + " " + emp.LastName);

        }

        private void comboBox_custID_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].ID == Convert.ToInt32(comboBox_custID.Text))
                {
                    listBox.Items.Clear();
                    listBox.Items.Add(customers[i].FirstName + " " + customers[i].LastName);
                }
            }
            
        }

        private void comboBox_EmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (customers[i].ID == Convert.ToInt32(comboBox_EmpID.Text))
                {
                    listBox.Items.Clear();
                    listBox.Items.Add(customers[i].FirstName + " " + customers[i].LastName);
                }
            }
        }

        private void button_listCustomer_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            foreach (Customer cus in customers)
                listBox.Items.Add(cus.FirstName + " " + cus.LastName);
        }

        private void button_addEMP_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();

            int ID = Convert.ToInt32(textBox_ID.Text);
            string FirstName = textBox_fN.Text;
            string LastName = textBox_lN.Text;
            string Address = textBox_address.Text;

            emp.ID = ID;
            emp.FirstName = FirstName;
            emp.LastName = LastName;
            emp.Address = Address;

            employees.Add(emp);
            comboBox_EmpID.Items.Add(emp.ID);
            clearTxtBox();
        }

        private void button_listEMP_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            foreach (Employee emp in employees)
                listBox.Items.Add(emp.FirstName + " " + emp.LastName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].ID == Convert.ToInt32(comboBox_custID.Text))
                {
                    customers.RemoveAt(i);
                    comboBox_custID.Items.RemoveAt(i);
                }
            }

            listBox.Items.Clear();
            foreach (Customer cus in customers)
                listBox.Items.Add(cus.FirstName + " " + cus.LastName);
        }
    }
}