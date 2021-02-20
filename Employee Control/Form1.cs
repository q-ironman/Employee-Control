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
        public DataTable myData = new DataTable();
        List<Employee> myEmployees = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_working.SelectedItem = comboBox_working.Items[0];
            
            myData.Columns.Add("Id");
            myData.Columns.Add("First Name");
            myData.Columns.Add("Last Name");
            myData.Columns.Add("Birth Date");
            myData.Columns.Add("Start Date");
            myData.Columns.Add("End Date");
            myData.Columns.Add("Reason");
            myData.Columns.Add("Mobile Phone");
            myData.Columns.Add("Phone");
            myData.Columns.Add("Adress");
            myData.Columns.Add("Postal Code");
            myEmployees.Add(new Employee() { Name = "Şevket", Surname = "Şahbaz", BirthDate = "01/01/1990", StartDate = "05/08/2010",
                IsWorking = true,
                Reason = "acbf",
                MoPhone = "5404560236",
                Phone = 4425368,
                City = "Ettelbruck Ettelbréck",
                Country = "Luxemburg",
                PostalCode = 5600,
                Adress = "Boulevard de la Fraternité"
            });
            Employee osman = new Employee();
            osman.Name = "Osman"; osman.Surname = "Ceylan"; osman.BirthDate = "02/02/2000"; osman.StartDate = "09/07/2015";
            osman.IsWorking = true; osman.Reason = "klsfskf"; osman.MoPhone = "5605879631"; osman.Phone = 4426897; osman.City = "Afyon";
            osman.Country = "Turkey"; osman.PostalCode = 3600; osman.Adress = "İncili Mahallesi Fatih caddesi";
            myData.Rows.Add(myEmployees[0].EmployeeId, myEmployees[0].Name, myEmployees[0].Surname, myEmployees[0].BirthDate, myEmployees[0].StartDate, myEmployees[0].EndDate, myEmployees[0].Reason, myEmployees[0].MoPhone, myEmployees[0].Phone, myEmployees[0].Adress, myEmployees[0].PostalCode);
            myData.Rows.Add(osman.EmployeeId, osman.Name, osman.Surname, osman.BirthDate, osman.StartDate, osman.EndDate, osman.Reason, osman.MoPhone, osman.Phone, osman.Adress, osman.PostalCode);

            dataGridView_employee.DataSource = myData;




        }

        private void comboBox_working_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
