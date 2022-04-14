using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLab
{
    [Serializable]
    public class DataPerson
    {
        public DateTime Date { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public DataPerson(DateTime date, string name, string surname, string patronymic, string city, string country)
        {
            Date = date;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            City = city;
            Country = country;
        }
    }
}
