﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook
{
    public class CreateContacts
    {


        public List<Contact> People = new List<Contact>();
        public Dictionary<string, List<Contact>> dict = new Dictionary<string, List<Contact>>();


        public void ContactDetails()
        {
            Contact contact = new Contact();

            int Flag = 0;
            Console.WriteLine("Enter First Name : ");
            contact.firstName = Console.ReadLine();


            string FirstNameToBeAdded = contact.firstName;
            foreach (var data in People)
            {
                if (People.Exists(data => data.firstName == FirstNameToBeAdded))
                {
                    Flag++;
                    Console.WriteLine("This FirstName already Exist! Can't take the Duplicate Record ");
                    break;
                }

            }
            if (Flag == 0)
            {

                Console.WriteLine("Enter Last Name : ");
                contact.lastName = Console.ReadLine();

                Console.WriteLine("Enter Email : ");
                contact.email = Console.ReadLine();

                Console.WriteLine("Enter Phone Number : ");
                contact.phoneNumber = Console.ReadLine();

                Console.WriteLine("Enter Address : ");
                contact.address = Console.ReadLine();

                Console.WriteLine("Enter City : ");
                contact.city = Console.ReadLine();

                Console.WriteLine("Enter Zip : ");
                contact.zip = Console.ReadLine();

                Console.WriteLine("Enter State : ");
                contact.state = Console.ReadLine();

                Console.WriteLine("\n");


            }

            People.Add(contact);
        }


        public void edit()
        {
            Console.WriteLine("Enter the name to search : ");
            string name = Console.ReadLine();
            foreach (var data in People)
            {
                if (data.firstName != name)
                {
                    Console.WriteLine("This contact doesn't exists");
                }
                else if (data.firstName == name)
                {
                    Console.WriteLine("choose the option to change the data : \n1)FirstName\n2)LastName\n3)Email\n4)Phone Number\n5)Address\n6)City\n7)Zip\n8)State");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Please enter the First Name : ");
                            string firstName = Console.ReadLine();
                            data.firstName = firstName;
                            break;
                        case 2:
                            Console.WriteLine("Please enter the Last Name : ");
                            string lastName = Console.ReadLine();
                            data.lastName = lastName;
                            break;
                        case 3:
                            Console.WriteLine("Please enter the Email : ");
                            string Email = Console.ReadLine();
                            data.email = Email;
                            break;
                        case 4:
                            Console.WriteLine("Please enter the Phone Number : ");
                            string PhoneNumber = Console.ReadLine();
                            data.phoneNumber = PhoneNumber;
                            break;
                        case 5:
                            Console.WriteLine("Please enter the Address : ");
                            string address = Console.ReadLine();
                            data.address = address;
                            break;
                        case 6:
                            Console.WriteLine("Please enter the City : ");
                            string city = Console.ReadLine();
                            data.city = city;
                            break;
                        case 7:
                            Console.WriteLine("Please enter the State : ");
                            string State = Console.ReadLine();
                            data.state = State;
                            break;
                        case 9:
                            Console.WriteLine("Please enter the Zip Code : ");
                            string Zip = Console.ReadLine();
                            data.zip = Zip;
                            break;
                        default:
                            Console.WriteLine(" Wrong input,please choose from above options :");
                            break;
                    }

                }

            }

        }

        public void removeContact()
        {
            Console.WriteLine("Enter the name to search : ");
            string name = Console.ReadLine();
            foreach (var data in People)
            {
                if (data.firstName == name)
                {
                    Console.WriteLine("given name contact exists");
                    People.Remove(data);

                    Console.WriteLine("contact deleted successfully");
                    return;
                }
                else
                {
                    Console.WriteLine("given contact doesn't found");
                }

            }
        }

        public void Addmultiplepersons(int n)
        {
            while (n > 0)
            {
                ContactDetails();
                n--;
            }

        }

        public void Adduniquecontacts()
        {
            Console.WriteLine("Enter the Firstname in your contactlist");
            string name = Console.ReadLine();
            foreach (var data in People)
            {
                if (People.Contains(data))
                {
                    if (data.firstName == name)
                    {
                        Console.WriteLine("This contact exists please enter an unique name to store this data");
                        string uniquename = Console.ReadLine();
                        if (dict.ContainsKey(uniquename))
                        {
                            Console.WriteLine("This unique name already exists");
                        }
                        dict.Add(uniquename, People);
                        return;
                    }
                }
            }
            Console.WriteLine("This contactlist doesn't exist, please creat a contactlist");
            return;

        }


        public void DisplayUniqueContacts()
        {
            Console.WriteLine("Enter the Uniquename of your contacts");
            string name = Console.ReadLine();
            foreach (var contacts in dict)
            {
                //Console.WriteLine("The details of " + name + " are \n" + contacts.Value);
                if (contacts.Key.Contains(name))
                {
                    foreach (var contact in contacts.Value)
                    {
                        Console.WriteLine("The details of " + name + " are \n" + "Name: " + contact.firstName + " " + contact.lastName + "\n" + "Email: " + contact.email + "\n" +
                       "Phone Number: " + contact.phoneNumber + "\n" + "Address: " + contact.address + "city: " + contact.city + "Zip: " + contact.zip + "\n" + "state: " + contact.state);
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("this unique name doesn't exist");
                }
            }
            Console.WriteLine("This Uniquelist doesn't exist, please creat a Uniquelist");
        }


        public void output()
        {
            foreach (var data in People)
            {
                Console.WriteLine("Name of the Person : " + data.firstName + " " + data.lastName);
                Console.WriteLine("Email ID : " + data.email);
                Console.WriteLine("Mobile Number : " + data.phoneNumber);
                Console.WriteLine("Address : " + data.address);
                Console.WriteLine("City : " + data.city);
                Console.WriteLine("State : " + data.state);
                Console.WriteLine("Zip : " + data.zip);
                Console.WriteLine("\n");

            }
        }
        public void SearchByCityState()
        {
            Console.WriteLine("Please enter the name of City or State:");

            string WantedCityOrState = Console.ReadLine();
            foreach (var data in People)
            {
                string actualcity = data.city;
                string actualState = data.state;
                if (People.Exists(data => (actualcity == WantedCityOrState || actualState == WantedCityOrState)))
                {
                    Console.WriteLine("Name of the Person : " + data.firstName + " " + data.lastName);
                    Console.WriteLine("Email ID : " + data.email);
                    Console.WriteLine("Mobile Number : " + data.phoneNumber);
                    Console.WriteLine("Address : " + data.address);
                    Console.WriteLine("City : " + data.city);
                    Console.WriteLine("State : " + data.state);
                    Console.WriteLine("Zip : " + data.zip);
                    Console.WriteLine("\n");
                }
            }
        }
    }
}