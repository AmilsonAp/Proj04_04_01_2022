// See https://aka.ms/new-console-template for more information
using Model;

Client c1 = new Client()
{
    Id = 1,
    Nome = "Amilson",
    Telefone = "(16) 99798-2688"
};

Client c2 = new Client()
{
    Id = 2,
    Nome = "Ailton",
    Telefone = "(16) 99798-0000"
};

Employes e1 = new Employes()
{
    Id = 1,
    Nome = "José",
    Telefone = "(16) 9778-2121"
};

Employes e2 = new Employes()
{
    Id = 2,
    Nome = "Carmem",
    Telefone = "(16) 9817-1221"
};

List<Client> clients = new List<Client>();
List<Employes> employes = new List<Employes>();

clients.Add(c1);
clients.Add(c2);
employes.Add(e1);
employes.Add(e2);

Hotel hotel = new Hotel()
{
    Client = clients,
    Employes = employes
};

Console.WriteLine(hotel.getClient());
Console.WriteLine(hotel.getEmployes());