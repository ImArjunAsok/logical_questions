double[] flightFares = new double [10];
char yesOrNo = 'y';
int choice;
Console.WriteLine("Enter Flight Fares in decimal format:");
for (int i = 0; i < flightFares.Length; i++)
{
    flightFares[i] = double.Parse(Console.ReadLine());
}
do
{
    Console.WriteLine(@"
1. Ascending Order
2. Descending Order
3. Search
4. Max and Min Fares
5. Duplicate Entries

Enter your choice: (1-5)");
    choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Array.Sort(flightFares);
            Console.WriteLine("Flight Fares in ascending order:");
            foreach (var fares in flightFares)
            {
                Console.WriteLine(fares);
            }
            break;
        case 2:
            for(int i = 0; i < flightFares.Length; i++)
            {
                for(int j = i+1; j < flightFares.Length; j++)
                {
                    if (flightFares[i] < flightFares[j])
                    {
                        double temp = flightFares[i];
                        flightFares[i] = flightFares[j];
                        flightFares[j] = temp;
                    }
                }
            }
            Console.WriteLine("Flight Fares in descending order:");
            foreach (var fares in flightFares)
            {
                Console.WriteLine(fares);
            }
            break;
        case 3:
            int flag = 0;
            int index = 0;
            Console.WriteLine("Enter the fare to be searched:");
            double searchFare = double.Parse(Console.ReadLine());
            for (int i = 0; i < flightFares.Length; i++)
            {
                if (flightFares[i] == searchFare)
                {
                    flag++;
                    index = i;
                }
            }
            Console.WriteLine("₹{0} found at position {1}", searchFare, (index + 1));
            break;
        case 4:
            double maxFare = 0.0;
            double minFare = flightFares[0];
            for(var i = 0; i < flightFares.Length; i++)
            {
                    if (flightFares[i] > maxFare)
                        maxFare = flightFares[i];
                    else if (flightFares[i] < minFare)
                    {
                        minFare = flightFares[i];
                    }               
            }
            Console.WriteLine("Max Fare: {0}", maxFare);
            Console.WriteLine("Min Fare: {0}", minFare);
            break;
        case 5:
            bool b = false;
            for (int i = 0; i < flightFares.Length; i++)
            {
                for (int j = i + 1; j < flightFares.Length; j++)
                {
                    if (flightFares[i] == flightFares[j])
                    {
                        b = true;
                        Console.WriteLine("Duplicate Elements found at Positions: {0} & {1}", (i + 1), (j + 1));
                    }
                }
            }
            if (b == false)
            {
                Console.WriteLine("No Duplicate Elements Found!");
            }
            break;
        default:
            Console.WriteLine("Wrong Choice!");
            break;
    }
    Console.WriteLine("Do you wish to continue?: (y/n)");
    yesOrNo = char.Parse(Console.ReadLine());
} while (yesOrNo == 'y');

