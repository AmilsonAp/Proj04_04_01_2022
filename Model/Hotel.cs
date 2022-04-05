using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Hotel
    {
        public List<Client> Client { get; set; }
        public List<Employes> Employes { get; set; }

        public string getClient()
        {
            string clients = "";
            foreach (var client in Client)
            {
                clients += "\nId: " + client.Id + " \nNome: " + client.Nome + "\nTelefone: " + client.Telefone + "\n"; 
            }
            return clients;
        }
        public string getEmployes()
        {
            string employees = "";
            foreach (var employes in Employes)
            {
                employees += "\nId: " + employes.Id + " \nNome: " + employes.Nome + "\n";
            }
            return employees;
        }
    }
}
