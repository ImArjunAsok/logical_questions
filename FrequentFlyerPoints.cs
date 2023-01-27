Console.WriteLine("Enter the passenger name: ");
string PassengerName = Console.ReadLine();
Console.WriteLine("Enter the distance travelled (in miles): ");
int DistanceTravelled = int.Parse(Console.ReadLine());
int FrequentFlyerPoint = 0;
if (DistanceTravelled > 10000 && DistanceTravelled <= 20000)
    FrequentFlyerPoint += 10;
else if (DistanceTravelled > 20000 && DistanceTravelled <= 50000)
    FrequentFlyerPoint += 20;
else if (DistanceTravelled > 50000 && DistanceTravelled <= 100000)
    FrequentFlyerPoint += 30;
else if (DistanceTravelled > 100000)
    FrequentFlyerPoint += 50;

Console.WriteLine(@"
Name : {0}
Distance Travelled: {1}
Frequent Flyer Points: {2}", PassengerName, DistanceTravelled, FrequentFlyerPoint);