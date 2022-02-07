using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Control
{
    public partial class Form1 : Form
    {
            
        EmployeeService frm1Service = EmployeeService.CreateService();
        Form2 myForm2 = new Form2();
        private List<Employee> myEmployees = new List<Employee>();
        private List<Employee> myEmployeesNew = new List<Employee>();
        private List<Employee> searchRsltEmps;

        bool? isWorkingSearch = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_working.SelectedItem = comboBox_working.Items[0];        
        }

        private void comboBox_working_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_working.SelectedIndex == 0)
                isWorkingSearch = null;
            if (comboBox_working.SelectedIndex == 1)
                isWorkingSearch = true;
            if (comboBox_working.SelectedIndex == 2)
                isWorkingSearch = false;
        }

        private void button_Addnew_Click(object sender, EventArgs e)
        {
            myForm2.Operation = 0;
            myForm2.ShowDialog();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            SearchingEmployee srchEmployee = new SearchingEmployee();
            srchEmployee.SearchName = textBox_Name.Text;
            srchEmployee.SearchLastname = textBox_Surname.Text;
            srchEmployee.SearchIsWorking = isWorkingSearch;
            searchRsltEmps=frm1Service.Search(srchEmployee);
            dataGridView_employee.DataSource = searchRsltEmps;
        }

        private void dataGridView_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(dataGridView_employee.Columns[e.ColumnIndex].Name == "Edit")
            {              
                myForm2.Operation = 1;
                myForm2.ShowDialog();
            }
            if (dataGridView_employee.Columns[e.ColumnIndex].Name == "Delete")
            {
                int del_index;
                del_index = dataGridView_employee.CurrentCell.RowIndex;
                myEmployeesNew =frm1Service.Delete(searchRsltEmps[del_index].EmployeeId);
                dataGridView_employee.DataSource = myEmployeesNew;
                
            }
        }
    }
}
