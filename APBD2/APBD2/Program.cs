using APBD2.Containers;
using APBD2.Methods;
using APBD2.Vehicles;

public class Program
{
    public static void Main(string[] args)
    {
        List<ContainerShip> ships = [];
        List<Container> containers = [];
        
        while (true)
        {
            Console.WriteLine("Lista kontenerowców: ");
            Console.WriteLine((ships.Count > 0 ? ships : "brak"));
            Console.WriteLine("Lista kontenerów: " );
            Console.WriteLine((containers.Count > 0 ? containers : "brak"));

            Console.WriteLine("Możliwe akcje:");
            Console.WriteLine("1. Dodaj kontenerowiec");
            Console.WriteLine("2. Usun kontenerowiec");
            Console.WriteLine("3. Dodaj kontener");

            string? userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Podaj maksymalną prędkość: ");
                    string maxSpeed = Console.ReadLine();

                    Console.WriteLine("Podaj maksymalną ilość konenerów: ");
                    string maxConCount = Console.ReadLine();

                    Console.WriteLine("Podaj maksymalną masę kontenerów: ");
                    string maxConWeight = Console.ReadLine();
                    
                    ships.Add(new ContainerShip(double.Parse(maxSpeed), int.Parse(maxConCount), double.Parse(maxConWeight)));
                    break;
                case "2":
                    int counter = 0;
                    foreach (ContainerShip sh in ships)
                    {
                        Console.WriteLine(++counter + ". sh");
                    }

                    Console.WriteLine("Podaj, który kontenerowiec chcesz usunąć: ");
                    string indexToDelete = Console.ReadLine();

                    ships.Remove(ships[int.Parse(indexToDelete)]);
                    break;
                case "3":
                    

                    break;
                    
                
            }
        }
    }
}