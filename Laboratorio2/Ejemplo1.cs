internal class Ejemplo1
{
    private static void Main(string[] args)
    {
        Client client = new Client();
        client.FirstName = "Nombre";
        client.LastName = "Apellido";
        client.Age = 15;
        client.Id = 1;

        Console.WriteLine(client.GetFullName());
    }
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}