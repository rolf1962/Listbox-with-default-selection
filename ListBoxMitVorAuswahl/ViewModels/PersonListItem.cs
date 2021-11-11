using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.ViewModels
{
    public class PersonListItem
    {
        public Person Person { get; set; }
        public bool Tatverdaechtig { get; set; }
        public bool Ausgewaehlt { get; set; }

        public override string ToString()
        {
            string tatverdaechtig = Tatverdaechtig ? "(tatverdächtig)" : string.Empty;
            return $"{Person} {tatverdaechtig}";
        }
    }
}
