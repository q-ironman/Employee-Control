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
    public partial class Form2 : Form
    {
        public int Operation { get; set; }
        EmployeeService myService = EmployeeService.CreateService();
        DateTime? endDate = null;
        bool isWorking = true;
        
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button_Save_Click(object sender, EventArgs e)
        {
            if(Operation == 0)
            {
                Employee newEmp = new Employee();
                newEmp.Name = textBox_Name.Text;
                newEmp.Surname = textBox_Surname.Text;
                newEmp.EndDate = endDate;
                newEmp.BirthDate = Picker_BirthDate.Value;
                newEmp.StartDate = Picker_StartDate.Value;
                newEmp.IsWorking = isWorking;
                newEmp.Reason = textBox_Reason.Text;
                newEmp.MoPhone = textBox_MobilePhone.Text;
                newEmp.Phone = textBox_Phone.Text;
                newEmp.City = textBox_City.Text;
                newEmp.PostalCode = textBox_PostalCode.Text;
                newEmp.Adress = textBox_Adress.Text;
                myService.Insert(newEmp);
                this.Close();
            }
            if(Operation == 1)
            {
                Employee updEmp = new Employee();
                updEmp.Name = textBox_Name.Text;
                updEmp.Surname = textBox_Surname.Text;
                updEmp.EndDate = endDate;
                updEmp.BirthDate = Picker_BirthDate.Value;
                updEmp.StartDate = Picker_StartDate.Value;
                updEmp.IsWorking = isWorking;
                updEmp.Reason = textBox_Reason.Text;
                updEmp.MoPhone = textBox_MobilePhone.Text;
                updEmp.Phone = textBox_Phone.Text;
                updEmp.City = textBox_City.Text;
                updEmp.PostalCode = textBox_PostalCode.Text;
                updEmp.Adress = textBox_Adress.Text;
                myService.Update(updEmp);
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Operation == 0)
                button_Save.Text = "Save";
            if (Operation == 1)
                button_Save.Text = "Save Edit";
        }

        private void Picker_EndDate_ValueChanged(object sender, EventArgs e)
        {
            endDate = Picker_EndDate.Value;
        }
    }
}
