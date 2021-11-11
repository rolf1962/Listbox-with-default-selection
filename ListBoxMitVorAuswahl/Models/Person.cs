using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Person
    {
        public string Nachname { get; set; }
        public string Vorname { get; set; }
        public DateTime Geburtsdatum { get; set; }

        public override string ToString()
        {
            return $"{Nachname}, {Vorname}, *{Geburtsdatum.ToShortDateString()}";
        }
    }
}
