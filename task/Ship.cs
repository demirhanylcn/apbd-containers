namespace task;

public class Ship
{
    public string Name { get; set; }

    private double _maxWeight;

    public double MaxWeight
    {
        get { return _maxWeight / 1000; }
        set { _maxWeight = value; }
    }

    public string Serial { get; set; }
    public double MaxSpeed { get; set; }
    public int ContainerLimit { get; set; }
    private List<Container> containers { get; set; }
    public double currentWeight { get; set; }

    public Ship(string name, double maxWeight, string serial, double maxShipSpeed, int containerLimit)
    {
        Name = name;
        MaxSpeed = maxShipSpeed * 0.5;
        MaxWeight = maxWeight;
        Serial = serial;
        ContainerLimit = containerLimit;
        containers = new List<Container>();
    }


    public void getContainerContext()
    {
        string context = "";
        foreach (Container each in containers)
        {
            context += each + "\n";
        }
    }

    public void loadContainer(Container container)
    {
        if (containers.Count + 1 > ContainerLimit)
        {
            Console.WriteLine("Ship is already full.");
        }
        else if (currentWeight + container.CurrentWeight > _maxWeight)
        {
            Console.WriteLine("it is exceeding max weight. can not do it.");
        }
        else
        {
            containers.Add(container);
        }
    }

    public void removeContainer()
    {
        Console.WriteLine("which container you wish to remove?");
        for (int i = 0; i < containers.Count; i++)
        {
            Console.WriteLine("[" + i + "]" + containers[i]);
        }

        int userInput = int.Parse(Console.ReadLine());
        if (userInput < containers.Count && userInput >= 0)
        {
            containers.RemoveAt(userInput);
        }
        else
        {
            Console.WriteLine("index it out of bounds.");
        }
    }

    public void unloadContainers()
    {
        containers.Clear();
    }

    public void changeContainer(Container container)
    {
        if (currentWeight + container.CurrentWeight > _maxWeight)
        {
            throw new Exception("it is exceeding max weight. can not do it.");
        }

        Console.WriteLine("which container you wish to change with?");
        for (int i = 0; i < containers.Count; i++)
        {
            Console.WriteLine("[" + i + "]" + containers[i]);
        }

        int userInput = int.Parse(Console.ReadLine());
        if (userInput < containers.Count && userInput >= 0)
        {
            containers[userInput] = container;
        }
        else
        {
            Console.WriteLine("index it out of bounds.");
        }
    }

    public void transferContainer(Ship anotherShip)
    {
        if (anotherShip.containers.Count + 1 > anotherShip.ContainerLimit)
        {
            Console.WriteLine("another ship doesnt have enough space.");
        }
        else
        {
            Console.WriteLine("which container you wish to transfer?");
            for (int i = 0; i < containers.Count; i++)
            {
                Console.WriteLine("[" + i + "]" + containers[i]);
            }

            int userInput = int.Parse(Console.ReadLine());
            if (userInput < containers.Count && userInput >= 0) ;
            if (anotherShip.currentWeight + containers[userInput].CurrentWeight > _maxWeight)
            {
                throw new Exception("it is exceeding max weight. can not do it.");
            }
            anotherShip.containers.Add(containers[userInput]);
            containers.RemoveAt(userInput);
        }
    }
}