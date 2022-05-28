﻿// See https://aka.ms/new-console-template for more information



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
                Console.WriteLine("Enter the option : \\n1)Creatingcontacts\n2)Edit Details\n3)Remove Contacts\n4)Adding multiple contacts\n5)Output Details\n6)Adding Unique Contacts\n7)Display unique contacts\n8)Search Person by city or State\n9Contacts by city using Dictionary\n10)Contacts by State using Dictionary\n11)count Person By city or state\n12)sorting by name ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        contact1.ContactDetails();
                        break;
                
                    case 2:
                        contact1.edit();
                        break;
                    case 3:
                        contact1.removeContact();
                        break;
                    case 4:
                        Console.WriteLine("Please enter number of contacts you want to add : ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        contact1.Addmultiplepersons(n);
                        break;
                
                    case 5:
                        contact1.output();
                        break;
                    case 6:
                        contact1.Adduniquecontacts();
                        break;
                    case 7:
                        contact1.DisplayUniqueContacts();
                        break;
                    case 8:
                        contact1.SearchByCityState();
                        break;
                 
                    case 9:
                        contact1.ContactsBycity_dictionary();
                        contact1.DisplayContactsByCities_Dictionary();
                        break;
                    case 10:
                        contact1.ContactsBystate_dictionary();
                        contact1.DisplayContactsByState_dictionary();
                        break;
                    case 11:
                        contact1.CountByCityState();
                        break;
                    case 12:
                        contact1.SortingDetailsByName();
                        break;
                 
                    default:
                        Console.WriteLine("Please choose correct option");
                        break;
                    

                }
            }

        }
    }
}


         
        

    

    
