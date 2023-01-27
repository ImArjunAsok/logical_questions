Console.WriteLine("Enter the number of passengers: ");
int n = int.Parse(Console.ReadLine());
double[] FlightFares = new double[n];
Console.WriteLine("Enter the flight flares: ");
for(int i = 0; i < n;i++)
{
    FlightFares[i] = double.Parse(Console.ReadLine());
}
string[] Destinations = new string[n];
Console.WriteLine("Enter the destinations: ");
for(int i = 0; i < n; i++)
{
    Destinations[i] = Console.ReadLine();
}
Console.WriteLine("Flight Fares in order:");
foreach(double fare in FlightFares)
{
    Console.Write("{0}  ", fare);
}
Console.WriteLine("\nDestination in order:");
foreach (string dest in Destinations)
{
    Console.Write("{0}  ", dest);
}
Console.WriteLine("\nEnter the nth element to be searched: ");
int element = int.Parse(Console.ReadLine())-1;
Console.WriteLine("\nFlight Fare: {0}", FlightFares[element]);
Console.WriteLine("\nDestination: {0}", Destinations[element]);




