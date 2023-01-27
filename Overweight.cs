try
{
    Console.WriteLine("Enter the number of passengers:");
    int PassengerCount = int.Parse(Console.ReadLine());
    Overweight[] overweights = new Overweight[PassengerCount];
    for (int i = 0; i < PassengerCount; i++)
    {
        overweights[i] = new Overweight();
        Console.WriteLine("Enter the boarding pass number for Passenger {0}:", i + 1);
        overweights[i].BoardingPass = Console.ReadLine();
        Console.WriteLine("Enter the total weight for Passenger {0}:", i + 1);
        overweights[i].TotalWeight = int.Parse(Console.ReadLine());
        if (overweights[i].IsOverweight() == true)
        {
            overweights[i].OverweightCost = (overweights[i].TotalWeight - 23) * 15;
        }
    }
    var Sorted = overweights.OrderByDescending(ob => ob.OverweightCost).ToArray();
    for (int i = 0; i < PassengerCount; i++)
    {
        Console.WriteLine("Boarding Pass = {0}", Sorted[i].BoardingPass);
        Console.WriteLine("Total Weight = {0}", Sorted[i].TotalWeight);
        Console.WriteLine("Overweight Cost = ${0}", Sorted[i].OverweightCost);
    }
}
catch (NullReferenceException e)
{
    Console.WriteLine(e.Message);
}

class Overweight
{
    public string? BoardingPass;
    public int TotalWeight;
    public int OverweightCost = 0;
    public Boolean IsOverweight()
    {
        int? Over = 23 - TotalWeight;
        if (Over < 0)
            return true;
        else
            return false;
    }
}