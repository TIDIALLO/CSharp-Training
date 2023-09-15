using testDelegate;
using testEvent;
using testEventDelegate;
/*
static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
{
Console.WriteLine(title);
foreach (Person p in people)
{
if (filter(p))
{
Console.WriteLine("{0}, {1} years old" ,p.Name, p.Age);
}
}
}*/
//======================= FILTERS +=========================
/*static bool IsMinor(Person p)
{
    return p.Age < 18;
}
static bool IsAdult(Person p)
{
    return p.Age >= 18;
}

Person p1 = new Person( "Pape",15);
Person p2 = new Person("Binta", 14);
Person p3 = new Person("Aly", 23);
Person p4 = new Person("Modou", 21);

List<Person> persons = new List<Person>() { p1, p2, p3, p4};
DisplayPeople("Skids", persons, IsMinor);


public delegate bool FilterDelegate(Person p);*/

//==================================================================================

// test event
/*var buttonMaster = new ButttonMaster();
buttonMaster.ButtonPressed += (sender, eventArgs) =>
{
    Console.WriteLine($"Button was {eventArgs.KeyCode} Pressed");
};

Start:

var keyCode = Console.ReadKey(true).KeyChar;
buttonMaster.OnButtonPressed(keyCode);

goto Start;*/

//==================================================================================
//==================================================================================

//                   EventHandler Delegate

Counter c = new Counter(new Random().Next(10));
c.ThresholdReached += c_ThresholdReached;

Console.WriteLine("press 'a' key to increase total");
while (Console.ReadKey(true).KeyChar == 'a')
{
    Console.WriteLine("adding one");
    c.Add(1);
}


static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)
{
    Console.WriteLine("The threshold of {0} was reached at {1}.", e.Threshold, e.TimeReached);
    Environment.Exit(0);
}