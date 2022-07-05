using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    internal class Indirizzo
    {
        private string name;
        private string surname;
        private string street;
        private string city;
        private string province;
        private readonly int ZIP;

        public Indirizzo(string name, string surname, string street, string city, string province, int ZIP)
        {
            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;
            this.ZIP = ZIP;
        }
    }
}
