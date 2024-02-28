using System;
using System.Linq;
using System.Collections.Generic;
using atm;

namespace program;

public static class Program 
{         
    public static void Main()
    {
        ATM atm = new ATM();
		string user = "";
		bool isVerified = false;
        Console.WriteLine("Hello, Would you Like to Register or Login to your atm?");	
		
		while(user != "e")
		{ 
            user = Console.ReadLine();
            if(user == "register" || user == "Register")
			{
                Console.WriteLine("What Would you Like you name to be set as?");
				atm.Name = Console.ReadLine();
				Console.WriteLine($"Registered as {atm.Name}");
				Console.WriteLine("How would you like to be your password set as?");
				atm.Password = Console.ReadLine();								
                if(atm.Password == atm.Password)
				{ 					    
					Console.WriteLine("Input login to login your account or 'e' to exit");
					user = Console.ReadLine();
			    }
            }
			if(user == "login" || user ==  "Login")
			{
                Console.WriteLine("Input your name's account");
				user = Console.ReadLine();
				
				if(user != atm.Name)
				{
                    Console.WriteLine($"{user} incorrect name, Try again");
					user = Console.ReadLine();							
                }
				else
                Console.WriteLine($"{user} has been verified. Input password");   		
                						
	   		 if(Console.ReadLine() != atm.Password)
				{
                    Console.WriteLine($"{user} incorrect password, Try again");
				    user = Console.ReadLine();				  
                }			    
				else
				{
                    Console.Clear();
                    Console.WriteLine($"{user} account successfully verified.");               								                  
					Console.WriteLine("===============================");
					Console.WriteLine($"|   {atm.Name} Account Info  q|");
					Console.WriteLine("| (1)Balance: 0    (2)Loan    |");
					Console.WriteLine("===============================");				
					atm.BalanceNLoan();					
                }								
            }
			if(user == "e")
			{
                Console.WriteLine("You Have the ATM");
				break;
            }
            break;
        }
	}
}
