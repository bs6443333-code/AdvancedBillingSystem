using System;
	
		
	class Program
	{
		static void Main()
		{
			B b = new Usage();

			decimal amt = b.Calc(100);
			amt = Discount.Apply(amt);

			Invoice i = new Invoice();
			i.Amount = amt;

			i.FinalizeInv();
			i.Pay();

			Console.WriteLine("Amount: " + i.Amount);
			Console.WriteLine("State: " + i.State);
		}
	}