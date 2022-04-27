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
                Console.WriteLine("Enter the option : \n1)Add Contact \n2)added contact");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        contact1.ContactDetails();
                        break;
                    case 2:
                        contact1.addedPerson();
                        break;
                    default:
                        Console.WriteLine("Please choose correct option");
                        break;
                }
            }

        }
    }
}


         
        

    

    
