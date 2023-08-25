// See https://aka.ms/new-console-template for more information

using References_Sawyer_Moira;

class program 
    {

     static void Main(string[] args)
     {
        Sedan myFirstSedan = new Sedan(0);
        IAtomobile myAutomobile = (IAtomobile)myFirstSedan;

        Sedan myOtherSedan = new Sedan(0);

        // Increases speed.
        myFirstSedan.IncreaseSpeed();
        Console.WriteLine(myFirstSedan.Speed);
        Console.WriteLine(myAutomobile.Speed);
        Console.WriteLine(myFirstSedan.Equals(myAutomobile));

        myOtherSedan.IncreaseSpeed();
        Console.WriteLine(myFirstSedan.Speed);
        Console.WriteLine(myOtherSedan.Speed);
        Console.WriteLine(myFirstSedan.Equals(myOtherSedan));

        Truck myTruck = new Truck(50, 500, "MyTrUcK");

        // Calls stringify method and describes automobiles.
        myFirstSedan.Stringify();
        //myAutomobile.Stringify();
        myOtherSedan.Stringify();
        myTruck.Stringify();
     }
  }