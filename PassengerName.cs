using System.Globalization;

string[] passengerNames = new string[10];
char yesOrNo = 'y';
int choice;
Console.WriteLine("Enter Passenger Names:");
for (int i = 0; i < passengerNames.Length; i++)
{
    passengerNames[i] = Console.ReadLine();
}
do
{
    Console.WriteLine(@"
1. Alphabetic Order
2. Reverse Order
3. Search
4. Length of Names
5. Split at Space
6. Duplicate Entries

Enter your choice: (1-6)");
    choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Array.Sort(passengerNames);
            Console.WriteLine("Alphabetic Order of Passenger Names:");
            foreach (string passengerName in passengerNames)
            {
                Console.WriteLine(passengerName);
            }
            break;
        case 2:
            char[] reverseArray = new char[10];
            foreach (string passengerName in passengerNames)
            {
                Console.WriteLine(passengerName);
            }
            break;
        case 3:
            int flag = 0;
            int index = 0;
            Console.WriteLine("Enter the name to be searched:");
            string searchName = Console.ReadLine();
            for (int i = 0; i < passengerNames.Length; i++)
            {
                if (passengerNames[i] == searchName)
                {
                    flag++;
                    index = i;
                }
            }
            Console.WriteLine("{0} found at position {1}", searchName, (index + 1));
            break;
        case 4:
            int length = 0;
            int[] nameLengths = new int[passengerNames.Length];
            for (var i = 0; i < passengerNames.Length; i++)
            {
                length = 0;
                foreach (var j in passengerNames[i])
                    length++;
                Console.WriteLine("{0} = {1}", passengerNames[i], length);
            }
            break;
        case 5:
            string firstName = "";
            string lastName = "";
            string breakpoint = "";
            for (var i = 0; i < passengerNames.Length; i++)
            {
                foreach (char j in passengerNames[i])
                {
                    if (j != ' ')
                        breakpoint += j;
                    else
                    {
                        firstName = breakpoint;
                        breakpoint = "";
                    }
                }
                lastName = breakpoint;
                breakpoint = "";
                Console.WriteLine("{0} = {1}, {2}", passengerNames[i], firstName, lastName);
            }
            break;
        case 6:
            bool b = false;
            for (int i = 0; i < passengerNames.Length; i++)
            {
                for (int j = i + 1; j < passengerNames.Length; j++)
                {
                    if (passengerNames[i] == passengerNames[j])
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

