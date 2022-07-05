// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using csharp_lista_indirizzi;


string path = "C:/Users/catan/source/repos/csharp-lista-indirizzi/addresses.csv";

List<Indirizzo> listaIndirizzi = new List<Indirizzo>();

StreamReader file = File.OpenText(path);

while (!file.EndOfStream)
{
    string line = file.ReadLine();
    string[] informazioni = line.Split(',');

    if (informazioni.Length == 6)
    {
        try
        {
            string name = informazioni[0];
            string surname = informazioni[1];
            string street = informazioni[2];
            string city = informazioni[3];
            string province = informazioni[4];
            string ZIP = informazioni[5];

            listaIndirizzi.Add(new Indirizzo(name, surname, street, city, province, ZIP));
            Console.WriteLine(line);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
    else
    {
        Console.WriteLine("Elementi inseriti non correttamente!");
    }


}



