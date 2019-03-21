using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp2.DbOPS;



namespace WindowsFormsApp2
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void select_Click(object sender, EventArgs e)
        {

            string textid = textBox1.Text;
            CustomerOps customer = new CustomerOps();
            List<Customer> lista = new List<Customer>();
            lista.Add(customer.GetCustomerByID(textid));
            dataGridView1.DataSource = lista;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            string textid = textBox1.Text;
            CustomerOps customer = new CustomerOps();
            customer.AddCustomer(textid);
        }

        private void update_Click(object sender, EventArgs e)
        {
            string textid = textBox1.Text;
            string name = textBox2.Text;
            CustomerOps customer = new CustomerOps();
            customer.UpdateCustomerName(textid, name);
        }
    }
}
