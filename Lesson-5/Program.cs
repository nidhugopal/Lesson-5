using System;

namespace Lesson_5
{
    struct BankAccountStruct
    {
        //struct is stored by valaue
        public string Name { get; set; }
        public float Balance { get; set; }

        public BankAccountStruct(string name, float balance)
        {
            Name = name;
            Balance=balance;
        }

        public void AddMonthlyInterest()
        {
            Balance *= (1f + .056f / 12f);
        }

        public void ShowDetails(string title)
        {
            Console.WriteLine($"Title:{title}; \n Name:{Name}; \n Balance:{Balance.ToString("C")}");
        }
    }

    class BankAccountClass
    {
        //struct is stored by valaue
        public string Name { get; set; }
        public float Balance { get; set; }

        public BankAccountClass(string name, float balance)
        {
            Name = name;
            Balance = balance;
        }

        public void AddMonthlyInterest()
        {
            Balance *= (1f + .056f / 12f);
        }

        public void ShowDetails(string title)
        {
            Console.WriteLine($"Title:{title}; \n Name:{Name}; \n Balance:{Balance}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            const string NAME = "Object Name";
            const float BALANCE = 597878.032f;
            
            BankAccountStruct structAccount = new BankAccountStruct(NAME, BALANCE);

            BankAccountClass classAccount = new BankAccountClass(NAME, BALANCE);

            structAccount.AddMonthlyInterest();
            classAccount.AddMonthlyInterest();
            structAccount.ShowDetails("Original Struct Account");
            classAccount.ShowDetails("Original Class Account");
            Console.ReadLine();

            
        }
    }
}
