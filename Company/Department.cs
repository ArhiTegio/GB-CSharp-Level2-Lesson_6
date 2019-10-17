using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_CSharp_Level2_Lesson_5
{
    public class Department
    {
        string name = "";
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        long profit = 0;

        public Department(string name, long profit)
        {
            Name = name;
            Profit = profit;
        }

        public string Name { get => name; set => name = value; }
        public long Profit { get => profit; set => profit = value; }
        internal ObservableCollection<Employee> Employees { get => employees; set => employees = value; }

        public override string ToString() => $" {Name} Прибыль: {Profit}";
    }
}
