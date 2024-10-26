using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Wallet_ConsoleApp
{
	internal class User
	{
		class Create
		{
			
			public string Name { get; }
			public int AccountNumber { get; }
			public Wallet Wallet { get; }

			int acc_no = 0;

			public Create(string Name, int Initialamount)
			{
				
		        this.Name = Name;
				AccountNumber = acc_no+1;
			    Wallet = new Wallet(Initialamount);
			}
		}

		class Wallet
		{
			public decimal Balance { get; set; }

			public List<decimal> Tranctions { get; set; }
            public Wallet(int Initialamount)
            {
				Balance = Initialamount;
				Tranctions = new List<decimal>();
            }

			public void AddAmount(decimal amt)
			{
				Balance += amt;
				Tranctions.Add(amt);
			}

			public bool TransferAmt(decimal tamt, Wallet rwallet)
			{
				if (Balance< tamt)
				{
					Console.WriteLine("Insufficient Amount");
					return false;
				}
				else
				{
					Balance -= tamt;
					Tranctions.Add(tamt);
					rwallet.AddAmount(tamt);
					return true;
				}
			}
			public List<decimal> GetTranHistory()
			{
				return Tranctions;
			}

        }
	}
}
