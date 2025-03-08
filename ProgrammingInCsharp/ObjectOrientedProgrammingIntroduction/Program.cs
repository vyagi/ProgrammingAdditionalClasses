var s1 = new Person("James Bond", 180, 100, new DateTime(1950, 10, 18));
var s2 = new Person("John Wick", 190, 60, new DateTime(1960, 11, 10));

Console.WriteLine(s1.Weight);
Console.WriteLine(s1.Height);
Console.WriteLine(s1.Name);
Console.WriteLine(s1.BirthDate);

Console.WriteLine(s1.Bmi());
Console.WriteLine(s2.Bmi());

Console.WriteLine(s1.IsBmiCorrect());
Console.WriteLine(s2.IsBmiCorrect());

s1.Weight = 75;
Console.WriteLine(s1.IsBmiCorrect());

class Person
{
    private int _weight;
    private readonly int _height;
    private readonly string _name;
    private readonly DateTime _birthDate;

    public int Weight
    {
        get => _weight;

        set
        {
            if (value <= 30 || value > 180)
                throw new ArgumentException("Weight is out of range (30-180)");

            _weight = value;
        }
    }

    public int Height => _height;

    public string Name => _name;

    public DateTime BirthDate => _birthDate;

    public Person(string name, int height, int weight, DateTime birthDate)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be null or empty");

        if (height <= 130 || height > 250)
            throw new ArgumentException("Height is out of range (130-250)");

        if (weight <= 30 || weight > 180)
            throw new ArgumentException("Weight is out of range (30-180)");

        if (DateTime.Now.Year - birthDate.Year < 15)
            throw new ArgumentException("The person is too young");

        _name = name;
        _height = height;
        _weight = weight;
        _birthDate = birthDate;
    }

    public double Bmi() => _weight / (_height * _height / 10000.0);

    public bool IsBmiCorrect() => Bmi() >= 18.5 && Bmi() <= 24.9;
}