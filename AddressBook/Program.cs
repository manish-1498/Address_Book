using System;

namespace AddressBook
{
    class Program
    {
        /// <summary>
        /// Displaying firstname,Lastname,Address,State,City,Pincode,Phonenumber,MailId
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            AddressDetails addressdetails = new AddressDetails("Manish","Pradhan","BNDM","Odisha","Rourkela",770032,7978353896, "manishyoyomp@gmail.com");
            addressdetails.Contact();
        }
    }
}
