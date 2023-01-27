Console.WriteLine( "Enter the boarding pass numbers:");
string[] BoardingPass = new string[10];
for (int i = 0; i < 10; i++)
    BoardingPass[i] = Console.ReadLine();

Queue<string> CounterQueue1 = new Queue<string>(3);
Queue<string> CounterQueue2 = new Queue<string>(3);
Queue<string> CounterQueue3 = new Queue<string>(3);
Random randomCounter = new Random();
CounterQueue1.Enqueue(BoardingPass[0]);
CounterQueue1.Enqueue(BoardingPass[3]);
CounterQueue1.Enqueue(BoardingPass[6]);
CounterQueue2.Enqueue(BoardingPass[1]); 
CounterQueue2.Enqueue(BoardingPass[4]);
CounterQueue2.Enqueue(BoardingPass[7]);
CounterQueue3.Enqueue(BoardingPass[2]);
CounterQueue3.Enqueue(BoardingPass[5]);
CounterQueue3.Enqueue(BoardingPass[8]);

Console.WriteLine("Queues before first exit: ");
Console.Write("Counter A: ");
Console.WriteLine(string.Join("=>", CounterQueue1));
Console.Write("Counter B: ");
Console.WriteLine(string.Join("=>", CounterQueue2));
Console.Write("Counter C: ");
Console.WriteLine(string.Join("=>", CounterQueue3));

int CounterNumber = randomCounter.Next(2);
switch(CounterNumber)
{
    case 0:
        CounterQueue1.Dequeue();
        CounterQueue1.Enqueue(BoardingPass[9]);
        break;
    case 1:
        CounterQueue2.Dequeue();
        CounterQueue2.Enqueue(BoardingPass[9]);
        break;
    case 2:
        CounterQueue3.Dequeue();
        CounterQueue3.Enqueue(BoardingPass[9]);
        break;
    default:
        Console.WriteLine("Error");
        break;
}
Console.WriteLine("Queues after first exit: ");
Console.Write("Counter A: ");
Console.WriteLine(string.Join("=>", CounterQueue1));
Console.Write("Counter B: ");
Console.WriteLine(string.Join("=>", CounterQueue2));
Console.Write("Counter C: ");
Console.WriteLine(string.Join("=>", CounterQueue3));