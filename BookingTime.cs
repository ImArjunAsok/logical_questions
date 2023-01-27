int newFare = 0;
Console.WriteLine("Enter flight fare:");
int flightFare = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Booking Time in 24 hours format (HH:MM) :");
string bookingTime = Console.ReadLine();
string[] hoursMins = bookingTime.Split(':');
if (int.Parse(hoursMins[0]) >= 06 && int.Parse(hoursMins[0]) < 09)
    newFare = flightFare + (flightFare / 100) * 10;
else if (int.Parse(hoursMins[0]) >= 09 && int.Parse(hoursMins[0]) < 17)
    newFare = flightFare + (flightFare / 100) * 20;
else if (int.Parse(hoursMins[0]) >= 17 && int.Parse(hoursMins[0]) < 23)
    newFare = flightFare + (flightFare / 100) * 7;
else if (int.Parse(hoursMins[0]) == 23 || (int.Parse(hoursMins[0]) >= 00 && int.Parse(hoursMins[0]) < 06))
    newFare = flightFare + (flightFare / 100) * 5;
Console.WriteLine("New Fare = {0}", newFare);