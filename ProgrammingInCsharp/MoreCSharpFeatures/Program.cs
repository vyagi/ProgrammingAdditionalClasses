var p1 = new Pair<int>(1, 2);
var p2 = new Pair<string>("a", "b");
var p3 = new Pair<DateTime>(DateTime.Now, DateTime.Today);

var listPhones = new List<Phone>();
var l1 = new List<string>();
var l2 = new List<int>();

l1.Add("James Bond");
l2.Add(5);

foreach (var x in l1)
{
    Console.WriteLine(x.Length);
}

foreach (var x in l2)
{
    Console.WriteLine(x + 10);
}

public class Pair<T>
{
    public T First;
    public T Second;

    public Pair(T first, T second)
    {
        First = first;
        Second = second;
    }
}
public class Phone{}