//Encapsulation [v]
//Inheritance [v]
//Polymorphism [v] - it means that the method will not be chosen depending on the variable type
// but depending on the actual object type. To enable polymorphism you need virtual/override keywords.
//Abstraction [ ]

#region Ihneritance demo
//Phone phone = new Phone("123456789");
//phone.Call("987654321");

//WirelessPhone wirelessPhone = new WirelessPhone("111222333");
//wirelessPhone.Charge();
//wirelessPhone.Call("11111111111");
//wirelessPhone.ShowOwnNumber();
#endregion

#region Polymorphism demo

#endregion

Phone p1 = new Phone("123456789");
WirelessPhone p2 = new WirelessPhone("987654321");
WirelessPhone p3 = new WirelessPhone("111222333");
p3.Charge();

PhoneCollection phoneCollection = new PhoneCollection();
phoneCollection.AddPhone(p1);
phoneCollection.AddPhone(p2);
phoneCollection.AddPhone(p3);

phoneCollection.CallAll("999999999");

public class PhoneCollection
{
    private List<Phone> _phones = new List<Phone>();

    public void AddPhone(Phone phone) => _phones.Add(phone);

    public void CallAll(string otherNumber)
    {
        foreach (Phone phone in _phones)
        {
            phone.Call(otherNumber);
        }
    }
}

public class WirelessPhone : Phone
{
    private int _batteryLevel;

    public WirelessPhone(string ownNumber) : base(ownNumber) { }

    public override void Call(string otherNumber)
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

    public virtual void Call(string otherNumber)
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