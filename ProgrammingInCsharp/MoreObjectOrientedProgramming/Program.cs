//Encapsulation [v]
//Inheritance [v]
//Polymorphism [ ]
//Abstraction [ ]

Phone phone = new Phone("123456789");
phone.Call("987654321");

WirelessPhone wirelessPhone = new WirelessPhone("111222333");
wirelessPhone.Charge();
wirelessPhone.Call("11111111111");
wirelessPhone.ShowOwnNumber();



public class WirelessPhone : Phone
{
    private int _batteryLevel;

    public WirelessPhone(string ownNumber) : base(ownNumber) { }

    public void Call(string otherNumber)
    {
        if (_batteryLevel > 0)
        {
            base.Call(otherNumber);
            _batteryLevel -= 10;
        }
        else
            Console.WriteLine("Piiiiiiiiiiiii");
    }

    public void Charge() => _batteryLevel = 100;

    public void ShowOwnNumber() => Console.WriteLine(_ownNumber);
}


public class Phone
{
    protected readonly string _ownNumber;

    private void _connectViaTelecom()
    {
        //this is some fancy, complicated low-level method responsible for actual connection
        Console.WriteLine("Connection established");
    }

    public Phone(string ownNumber) => _ownNumber = ownNumber;

    public void Call(string otherNumber)
    {
        if (_ownNumber == otherNumber)
            Console.WriteLine("Biip biip biip");
        else
        {
            Console.WriteLine($"Calling {otherNumber} from {_ownNumber}");
            _connectViaTelecom();
        }
    }
}