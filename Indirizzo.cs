namespace csharp_lista_indirizzi
{
    internal class Indirizzo
    {
        private string name;
        private string surname;
        private string street;
        private string city;
        private string province;
        private string ZIP;

        public Indirizzo(string name, string surname, string street, string city, string province, string ZIP)
        {
            ControlloElementi(name);
            this.name = name;
            ControlloElementi(surname);
            this.surname = surname;
            ControlloElementi(street);
            this.street = street;
            ControlloElementi(city);
            this.city = city;
            ControlloElementi(province);
            this.province = province;
            ControlloElementi(ZIP);
            this.ZIP = ZIP;
        }
        // Getters
        public string GetName()
        {
            return name;
        }
        public string GetSurname()
        {
            return surname;
        }
        public string GetStreet()
        {
            return street;
        }
        public string GetCity()
        {
            return city;
        }
        public string GetProvince()
        {
            return province;
        }
        public string GetZIP()
        {
            return ZIP;
        }

        // Setter
        public void SetZIP(string ZIP)
        {
            bool canConvert = int.TryParse(ZIP, out int val);
            if (canConvert == true && ZIP.Length == 5)
            {
                this.ZIP = ZIP;
            }
            else
            {
                throw new Exception("Non hai inserito numeri");
            }
        }

        // Controllo se sono le stringhe null
        private static void ControlloElementi(string controllo)
        {
            if (controllo == "")
            {
                throw new Exception("Elemento non inserito");
            }
        }
    }
}
