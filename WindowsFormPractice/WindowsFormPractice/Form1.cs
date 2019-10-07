using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormPractice
{
    public partial class Form1 : Form
    {
        List<Details> people = new List<Details>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Details newPerson = new Details();
            newPerson.Fname = txtFirstName.Text;
            newPerson.Lname = txtLastName.Text;
            newPerson.Age = int.Parse(txtAge.Text);
            people.Add(newPerson);

            txtAge.Text = null;
            txtFirstName.Text = null;
            txtLastName.Text = null;
            lblOutput.Text = "Record created";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Displaying all records";
            lstDisplay.Items.Clear();
            foreach(var x in people)
            {
                lstDisplay.Items.Add(x.DisplayName());
                lstDisplay.Items.Add($"Age: {x.Age}");
                lstDisplay.Items.Add("---------------------------------");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = null;
            txtLastName.Text = null;
            txtAge.Text = null;
            lblOutput.Text = "Enter Details Below";
            lstDisplay.Items.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            people.Clear();
            lstDisplay.Items.Clear();
            lblOutput.Text = "Records deleted";
        }
    }
}
