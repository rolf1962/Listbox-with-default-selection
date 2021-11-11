using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.DataAccess
{
    public class TestContext : DataContext
    {
        public TestContext()
        {
            Personen = new List<Person>(new Person[]
            {
                new Person()
                {
                    Nachname="Mustermann",
                    Vorname="Manfred",
                    Geburtsdatum=new DateTime(1956,2,24)
                },
                new Person()
                {
                    Nachname="Mustermann",
                    Vorname="Ilse",
                    Geburtsdatum=new DateTime(1959,3,3)
                },
                new Person()
                {
                    Nachname="Testmann",
                    Vorname="Klaus",
                    Geburtsdatum=new DateTime(1987,4,14)
                },
                new Person()
                {
                    Nachname="Testmann",
                    Vorname="Helga",
                    Geburtsdatum=new DateTime(1986,1,21)
                },
            });
        }
    }
}
