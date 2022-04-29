// See https://aka.ms/new-console-template for more information



using System;


namespace Addressbook
{
    class program
    {
        static void Main(string[] args)
        {

            CreateContacts contact1 = new CreateContacts();
            while (true)
            {
                Console.WriteLine("Enter the option : \n1)create Contact \n2)added contact\n3)edit contacts\n4" +
                    ")remove contact\n5)add multiple contacts\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        contact1.ContactDetails();
                        break;
                    case 2:
                        contact1.addedPerson();
                        break;
                    case 3:
                        contact1.edit();
                        break;
                    case 4:
                        contact1.removeContact();
                        break;
                    case 5:
                        Console.WriteLine("Please enter number of contacts you want to add : ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        contact1.AddMultipleContacts(n);
                        break;
                    default:
                        Console.WriteLine("Please choose correct option");
                        break;
                    

                }
            }

        }
    }
}


         
        

    

    
