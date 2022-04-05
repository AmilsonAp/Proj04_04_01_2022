namespace Model
{
    public abstract class Person: IPerson
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public string PrintTelephone()
        {
            return Telefone;
        }

        public override string ToString()
        {
            return "Id: " + Id +
                " \nNome: " + Nome +
                " \nTelefone: " + Telefone;
        }

        public virtual int GetNumberOfCaracters(string text)
        {
            return text.Length;
        }
    }
}