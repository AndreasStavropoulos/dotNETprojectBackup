using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal enum Gender
    { male, female }

    internal class Customer
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public int YearOfBirth { get; set; }

        public Gender Gender { get; set; }

        public string BillingAddress { get; set; }

        public string EMail { get; set; }

        private static int startingIdnumber = 1;

        public Customer(string customername, int birthday, Gender gender, string billingaddress, string e_mail)
        {
            CustomerId = startingIdnumber;
            startingIdnumber++;
            CustomerName = customername;
            YearOfBirth = birthday;
            Gender = gender;
            BillingAddress = billingaddress;
            EMail = e_mail;
        }
    }
}
