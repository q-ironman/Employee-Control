using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Control
{
    class Employee
    {
        int i = -1;
        string _id;
        string _name;
        string _surname;
        string _birthDate;
        string _startDate;
        string _endDate;
        string _reason;
        string _moPhone;
        int _phone;
        string _adress;
        string _city;
        int _postalCode;
        string _country;
        bool _isWorking;
        public bool IsWorking { get { return this._isWorking; } set { this._isWorking = value; } }
        public string Name { get { return this._name; } set { this._name = value; } }
        public string Surname { get { return this._surname; } set { this._surname = value; } }
        public string BirthDate { get { return this._birthDate; } set { this._birthDate = value; } }
        public string StartDate { get { return this._startDate; } set { this._startDate = value; } }
        public string EndDate { get { return this._endDate; }

            set
            {
                if (this._isWorking)
                    this._endDate = "---";
                else
                {
                    this._endDate = value;
                }
            }
        }
        public string MoPhone
        {
            get { return this._moPhone; }
            set
            {
                this._moPhone = "+90" + value;
            }
        }
        public int Phone { get { return this._phone; } set { this._phone = value; } }
        public string Country { get { return this._country; } set { this._country = value; } }
        public string City { get { return this._city; } set { this._city = value; } }
        public string Adress 
        {
            get
            {
                return this._adress;
            }
            set
            {
                this._adress = value + this._city + "/" + this._country;
            }
        }
        public int PostalCode { get { return this._postalCode; } set { this._postalCode = value; } }        
        public string EmployeeId 
        {
            get
            {
                return this._postalCode.ToString() + (this._phone % 1000).ToString();
            }
            set
            {
                this._id = this._postalCode.ToString() + this._phone.ToString();
            }
        }
        public string Reason { get { return this._reason; } set { this._reason = value; } }
        

    }
}
