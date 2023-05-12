Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neighboursDog= new Dog("Good Girl");


Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}.");

myDog.Rename("Bad Boy");

while (myDog.LevelOfHappines != 5)
{
    myDog.Bark();
}

myDog.WagTail();
class Dog
{
    private string _name; //filled
    private int _levelOfHappines;

    //constructor
    public Dog(string name)
    {
        _name = name;
        _levelOfHappines = 0;
    }

    //getter
    public string Name
    {
        get { return _name; }
    }
    
    public int LevelOfHappines
    {
        get { return _levelOfHappines; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}.");
    }

    public void Bark()
    {
        Console.WriteLine("WOOF-WOOF!");
        _levelOfHappines++;

    }

    public void WagTail()
    {
        Console.WriteLine("WIGGLE-WIGGLE!");
    }
}
