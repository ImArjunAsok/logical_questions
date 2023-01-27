char YesOrNo = 'y';
do
{
    Console.WriteLine(@"
0 - Even Positions
1 - Odd Positions

Enter your choice to enter array elements:");
    int choice = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter array size:");
    int size = int.Parse(Console.ReadLine());
    int[] array = new int[size * 2];
    Console.WriteLine("Enter array elements:");
    for(int i = choice; i < size * 2;i=i+2)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Array:");
    for (var i = 0; i < size * 2; i++)
        Console.WriteLine(array[i]);
    Console.WriteLine("Do you wish to continue (y/n)?");
    YesOrNo = char.Parse(Console.ReadLine());
} while (YesOrNo == 'y');