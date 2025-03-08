const int numberOfNumbers = 4;
var numbers = new List<int>();

for (var i = 0; i < numberOfNumbers; i++)
{
    Console.WriteLine($"Enter number {i + 1}");
    numbers.Add(int.Parse(Console.ReadLine()));
}

var sum = 0;
foreach (var number in numbers)
{
    sum += number;
}

var average = 1.0 * sum / numberOfNumbers;
Console.WriteLine($"The sum is {sum} and average is {average}");

//var numbers = new int[4];

//for (var i = 0; i < 4; i++)
//{
//    Console.WriteLine($"Enter number {i + 1}");
//    numbers[i] = int.Parse(Console.ReadLine());
//}

//var sum = 0;
//for (var i = 0; i < 4; i++)
//{
//    sum += numbers[i];
//}

//var average = sum / 4.0;
//Console.WriteLine($"The sum is {sum} and average is {average}");


//A very crappy way 
// var a = int.Parse(Console.ReadLine());
// var b = int.Parse(Console.ReadLine());
// var c = int.Parse(Console.ReadLine());
// var d = int.Parse(Console.ReadLine());
//
// var sum = a + b + c + d;
// var average = sum / 4.0;
//
// Console.WriteLine($"The sum is {sum} and average is {average}");

// Console.WriteLine("What is the radius?");
// var radiusString = Console.ReadLine();
// var radius = double.Parse(radiusString);
// var area = Math.PI * radius * radius;
// Console.WriteLine(area);

// Console.WriteLine("What is your name?");
// string name = Console.ReadLine();
// Console.WriteLine($"Hello {name}");

//string name = "Marcin";
//Console.WriteLine($"Hello {name}");

//string name = "Marcin";
//Console.WriteLine(string.Format("Hello {0}", name)); //it's old-school

// string name = "Marcin";
// Console.WriteLine("Hello " + name); //you should avoid string concatenation

// string name = "Marcin";
// Console.Write("Hello ");
// Console.WriteLine(name);

//string name = "Marcin";
//Console.WriteLine(name);

//Console.WriteLine("Hello");