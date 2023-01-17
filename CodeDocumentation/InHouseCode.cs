using AttributeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeDocumentation
{
    internal class InHouseCode
    {



        [Document("This class represents a bank account", Input = "string accountNumber, double balance", Output = "none")]
        class BankAccount
        {
            private string _accountNumber;
            private double _balance;

            [Document("This constructor initializes a new bank account", Input = "string accountNumber, double balance", Output = "none")]
            public BankAccount(string accountNumber, double balance)
            {
                _accountNumber = accountNumber;
                _balance = balance;
            }

            [Document("This method deposits a specified amount of money into the account", Input = "double amount", Output = "none")]
            public void Deposit(double amount)
            {
                _balance += amount;
            }

            [Document("This method withdraws a specified amount of money from the account", Input = "double amount", Output = "bool indicating success or failure of the withdrawal")]
            public bool Withdraw(double amount)
            {
                if (_balance < amount)
                {
                    return false;
                }
                _balance -= amount;
                return true;
            }

            [Document("This method gets the current balance of the account", Input = "none", Output = "double representing the current balance")]
            public double GetBalance()
            {
                return _balance;
            }
        }

        [Document("These are the types of account available in our crypto bank")]
        public enum AccountTypes {
            Savings,
            Current,
            Domicillary


        }

        


        //class DocumentHelper
        //{
            public static void GetDocs()
            {
                var assembly = Assembly.GetExecutingAssembly();

                Console.WriteLine("Assembly name: " + assembly.FullName);
                Console.WriteLine();

                var types = assembly.GetTypes();
                foreach (var type in types)
                {
                    var documentAttribute = (DocumentAttribute)type.GetCustomAttribute(typeof(DocumentAttribute));
                    if (documentAttribute != null && type.IsClass)
                    {
                        Console.WriteLine("Class: " + type.Name);
                        Console.WriteLine("Description: " + documentAttribute.Description);
                        Console.WriteLine();
                    }
             
                 

                // Display constructors
                var constructors = type.GetConstructors();
                    foreach (var constructor in constructors)
                    {
                        var documentattribute = (DocumentAttribute)constructor.GetCustomAttribute(typeof(DocumentAttribute));
                        if (documentattribute != null)
                        {
                            Console.WriteLine("\t Constructor: " + constructor.Name);
                            Console.WriteLine("\t Description: " + documentattribute.Description);
                            Console.WriteLine("\t Input: " + documentattribute.Input);
                            Console.WriteLine("\t Output: " + documentattribute.Output);
                        }
                    }

                    // Display properties
                    var properties = type.GetProperties();
                    foreach (var property in properties)
                    {
                        var documentattribute = (DocumentAttribute)property.GetCustomAttribute(typeof(DocumentAttribute));
                        if (documentattribute != null)
                        {
                            Console.WriteLine("\t Property: " + property.Name);
                            Console.WriteLine("\t Description: " + documentattribute.Description);
                        }
                    }

                    // Display methods
                    var methods = type.GetMethods();
                    foreach (var method in methods)
                    {
                        var documentattribute = (DocumentAttribute)method.GetCustomAttribute(typeof(DocumentAttribute));
                        if (documentattribute != null)
                        {
                            Console.WriteLine("\t Method: " + method.Name);
                            Console.WriteLine("\t Description: " + documentattribute.Description);
                            Console.WriteLine("\t Input: " + documentattribute.Input);
                            Console.WriteLine("\t Output: " + documentattribute.Output);
                        }
                    }

                    Console.WriteLine();
                }
            }
        }


    }
//}
