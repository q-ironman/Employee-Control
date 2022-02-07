using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Control
{
    class SearchingEmployee
    {
        string _searchName;
        string _searchLastName;
        bool? _searchIsWorking;
        public string SearchName { get { return _searchName; } set { _searchName = value; } }
        public string SearchLastname { get { return _searchLastName; } set { _searchLastName = value; } }
        public bool? SearchIsWorking { get { return _searchIsWorking; } set { _searchIsWorking=value; } }
    }
}
