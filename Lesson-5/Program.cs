﻿using System;

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
            Console.WriteLine($"Title:{title}; \n Name:{Name};  Balance:{Balance.ToString("C")}");
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
            Console.WriteLine($"Title:{title}; \n Name:{Name};  Balance:{Balance.ToString("C")}");
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

            BankAccountStruct copyStructAccount = structAccount;
            BankAccountClass copyClassAccount = classAccount;


            Add100(structAccount);
            structAccount.ShowDetails("Original Struct Account");
            Add100(classAccount);
            copyStructAccount.ShowDetails("Original Class Account");

            structAccount.Balance = Add100(structAccount.Balance);
            classAccount.Balance = Add100(classAccount.Balance);


            Console.WriteLine();
            classAccount.ShowDetails("Original Struct Account");
            copyClassAccount.ShowDetails("Original Class Account");

            copyStructAccount.AddMonthlyInterest();
            copyClassAccount.AddMonthlyInterest();
            Console.WriteLine("-----------------------------");
            structAccount.ShowDetails("Original Struct Account");
            copyStructAccount.ShowDetails("Original Class Account");
            Console.WriteLine();
            classAccount.ShowDetails("Original Struct Account");
            copyClassAccount.ShowDetails("Original Class Account");

            Console.ReadLine();

            
        }

        static void Add100(BankAccountStruct structAccount)
        {
            structAccount.Balance += 10000000;
        }
        static void Add100(BankAccountClass classAccount)
        {
            classAccount.Balance += 10000000;
        }
        static float Add100(float balance)
        {
            return balance += 10000000;
        }
    }
}
