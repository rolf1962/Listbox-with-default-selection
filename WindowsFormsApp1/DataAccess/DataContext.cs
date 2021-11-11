using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.DataAccess
{
    public abstract class DataContext
    {
        public List<Person> Personen { get; protected set; }
    }
}
