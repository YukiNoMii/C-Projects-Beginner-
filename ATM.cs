using System;
using System.Linq;
using System.Collections.Generic;

namespace atm;

public class ATM 
{ 	
      public string input;
      private string name;
	  public string Name
	  {
          get { return name; }
		  set{
              name = value;
			  
			  if(int.TryParse(name, out int nameNum))
			  {
                  Console.WriteLine("You can't put numbers on your name");
				  Name = Console.ReadLine();				  
              }
          }
      }
	  private string password;
	  public string Password
	  {
          get { return password; }
		  
	 	 set
	 	 {
              password = value;
			  
			  int passwordLength = password.Length;
		      bool getLength = false;   
			  while(!getLength)
			  {
                  if(int.TryParse(password, out int passwordNum) && passwordLength > 7 || passwordLength > 7)
				  {
                    value = passwordNum.ToString();
					Console.WriteLine("Your Password has been set");
					getLength = true;
					
                  }
				  if(int.TryParse(password, out passwordNum) && passwordLength < 8 || passwordLength < 8)
				  {
                     Console.WriteLine("Your password needs to have 8 characters");
					 Password = Console.ReadLine();
                     break;
	              }
              }			  
		  }			  
      }
	  private int balance;
	  public int Balance
	  {
          get {return balance;}
		  
		  set{
              balance = value;
			  
			  if(value > 1000)
			  {
                  Console.WriteLine("You can't put more than 1000 in your balance,");
              }
          }
      }
	  
	  private int loanBalance;
	  public int LoanBalance
	  {
          get{return loanBalance;}
		  
		  set{
              loanBalance = value;
			  
			  if(value > 1000 || loanBalance > 1000)
			  {
                  Console.WriteLine("You can't get more than 1000 in loan,");
              }              
			  else
			  {
                  loanBalance = value;
              }
          }
      }
	  
	  public void BalanceNLoan()
	  {
         input = Console.ReadLine();
         while(input != "e")
		 {	          
           if(input == "1")
		   {
               GetBalance();
           }
		   else if(input == "2")
		   {
               GetLoan();
           }
		 }
      }
	  private void GetBalance()
	  {	
          if(input == "1")
		  {
              Console.WriteLine("Your Account's Balance:");
			  Console.WriteLine(LoanBalance);
			  input = Console.ReadLine();
          }		
      }
	  
	  private void GetLoan()
	  {	          
          Console.WriteLine("How many dollars do you wanna loan?");
		  string user = Console.ReadLine();
		  if(int.TryParse(user, out int getLoan))
		  {
              if(getLoan > 1000)
			  {
                  Console.WriteLine("You can't loan more than 1000.");
              }
			  else
			  {
                  Console.WriteLine($"{getLoan} have been added to your balance. ");
				   LoanBalance = getLoan;
				  Console.WriteLine(LoanBalance);
				  Console.WriteLine("Input Number 1 to see your balance or enter 'e' to exit");
				  input = Console.ReadLine();
				  if(input == "1")
				  {
                      GetBalance();
                  }
                  else
				  {
                      Console.WriteLine("ATM has been closed.");
                  }				
              }
          }
      }
}
