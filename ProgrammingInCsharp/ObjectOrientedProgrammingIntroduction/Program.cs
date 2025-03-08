//This is no longer possible, after we added a constructor to the Person class

// var s1 = new Person();
// var s2 = new Person();
//
// s1.name = "James Bond";
// s1.height = 180;
// s1.weight = 80;
// s1.birthDate = new DateTime(1950, 10, 18);
//
// s2.name = "John Wick";
// s2.height = 190;
// s2.weight = 60;
// s2.birthDate = new DateTime(1960, 11, 10);

var s1 = new Person("James Bond", 180, 80, new DateTime(1950, 10, 18));
var s2 = new Person("John Wick", 190, 60, new DateTime(1960, 11, 10));

Console.WriteLine(s1.weight);
Console.WriteLine(s1.height);
Console.WriteLine(s1.name);
Console.WriteLine(s1.birthDate);

Console.WriteLine(s1.Bmi());
Console.WriteLine(s2.Bmi());

Console.WriteLine(s1.IsBmiCorrect());
Console.WriteLine(s2.IsBmiCorrect());

var s3 = new Person("Ethan Hawk", 170, 75, new DateTime(1970, 12, 20));
Console.WriteLine(s3.Bmi());

s3.name = null;
s3.height = 0;
s3.weight = 0;
s3.birthDate = new DateTime(2005, 1, 1);
Console.WriteLine(s3.Bmi());

class Person
{
    //These things are called fields, by default they are private
    private int weight;
    private int height;
    private string name;
    private DateTime birthDate;

    //Now let's add a constructor
    public Person(string name, int height, int weight, DateTime birthDate)
    {
        //very often in your constructor you ensure that the data is correct
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be null or empty");

        if (height <= 130 || height > 250)
            throw new ArgumentException("Height is out of range (130-250)");

        if (weight <= 30 || weight > 180)
            throw new ArgumentException("Weight is out of range (30-180)");

        if (DateTime.Now.Year - birthDate.Year < 15)
            throw new ArgumentException("The person is too young");

        this.name = name;
        this.height = height;
        this.weight = weight;
        this.birthDate = birthDate;
    }

    //This is a method:
    public double Bmi()
    {
        return weight / (height * height / 10000.0);
    }

    public bool IsBmiCorrect()
    {
        return Bmi() >= 18.5 && Bmi() <= 24.9;
    }
}