using System;

class Ali
{
    public static void Main()
    {
        Costumer C1 = new Costumer();
        C1.ID = 101;
        C1.Name = "John Lorusso";
        C1.Salary = 5000;

        Costumer C2 = new Costumer();
        C2.ID = 102;
        C2.Name = "Ibrahim Arabaki";
        C2.Salary = 6000;

        Costumer C3 = new Costumer();
        C3.ID = 103;
        C3.Name = "UFO";
        C3.Salary = 7000;

        Console.WriteLine("Using an Array");
        Console.WriteLine("----------------------------------------------------------------");

        Costumer[] CA1 = new Costumer[3];
        CA1[0] = C1;
        CA1[1] = C2;
        CA1[2] = C3;

        Dictionary <int, Costumer> DC1 = CA1.ToDictionary (Cust => Cust.ID, Cust => Cust);

        foreach (KeyValuePair <int, Costumer> kvp in DC1)
        {
            Console.WriteLine("Key = {0}", kvp.Key);

            Costumer Cust = kvp.Value;
            Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}", Cust.ID, Cust.Name, Cust.Salary);

            Console.WriteLine("----------------------------------------------------------------");
        }

        Console.WriteLine("Using List");
        Console.WriteLine("----------------------------------------------------------------");

        List<Costumer> CA2 = new List<Costumer>();
        CA2.Add(C1);
        CA2.Add(C2);
        CA2.Add(C3);

        Dictionary <int, Costumer> DC2 = CA1.ToDictionary (Cust => Cust.ID, Cust => Cust);

        foreach (KeyValuePair <int, Costumer> kvp in DC2)
        {
            Console.WriteLine("Key = {0}", kvp.Key);

            Costumer Cust = kvp.Value;
            Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}", Cust.ID, Cust.Name, Cust.Salary);

            Console.WriteLine("----------------------------------------------------------------");
        }
    }
}

public class Costumer
{
    public int ID {get; set; }
    public string Name {get; set; }
    public int Salary {get; set; }
}