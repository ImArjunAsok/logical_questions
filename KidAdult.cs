string DateOfBirth;
Console.WriteLine("Enter your Date of Birth (DD-MM-YYYY):");
DateOfBirth = Console.ReadLine();
string[] dobArray = DateOfBirth.Split("-");
//foreach (string dob in dobArray)
//Console.WriteLine(dob);
int years = 0;
string now = DateTime.Now.ToString("dd-MM-yyyy");
string[] nowArray = now.Split("-");
years = (int.Parse(nowArray[2]) - int.Parse(dobArray[2])) - 1;
if (int.Parse(nowArray[1]) > int.Parse(dobArray[1]))
    years++;
else if ((int.Parse(nowArray[1]) == int.Parse(dobArray[1])) && (int.Parse(nowArray[0]) >= int.Parse(dobArray[0])))
    years++;

if(years < 10)
{
    Console.WriteLine(@"
Age = {0}
KID", years);
}
else if (years >= 10 && years <=30)
{
    Console.WriteLine(@"
Age = {0}
YOUTH", years);
}
else if (years > 30 && years <=60)
{
    Console.WriteLine(@"
Age = {0}
ADULT", years);
}
else if (years >= 60)
{
    Console.WriteLine(@"
Age = {0}
OLDER", years);
}

