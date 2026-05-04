using System;

class Program
{
    static void Main()
    {
        int usage = 100;
        int rate = 10;

        decimal amount = usage * rate;


        amount = amount * 0.9m;


        string state = "Draft";


        if (state == "Draft")
            state = "Finalized";


        if (state == "Finalized")
            state = "Paid";

        Console.WriteLine("Amount: " + amount);
        Console.WriteLine("State: " + state);
    }
}
