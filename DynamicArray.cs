Console.WriteLine();
List<int> FlightNumbers = new List<int>();
int number;
char YesOrNo = 'y';
do
{
    Console.WriteLine("Enter flight number to be added: ");
    number = int.Parse(Console.ReadLine());
    FlightNumbers.Add(number);
    Console.WriteLine("Array till now:");
    foreach(int i in FlightNumbers)
        Console.Write("{0}  ",i);
    Console.WriteLine("\nDo you wish to continue? (y/n):");
    YesOrNo = char.Parse(Console.ReadLine());
} while (YesOrNo == 'y');
