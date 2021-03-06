﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using ECash;

namespace ECash
{
    class AtmTransaction
    {
        private string CustomerInput(string response)
        {
            Regex regex = new Regex(@"\b(N|NO|Y|YES|)\b");
            if (regex.Match(response).Success)

            //if (response == "N" ||  response == "NO" || response == "Y" || response == "YES") //customer already has an account lets pull their information
                {
                    return response;

                }
            else
            {
                System.Console.WriteLine("Invalid Entry! Please enter yes or no for your selection. Are you an existing customer?: ");
                response = System.Console.ReadLine();
                response.ToUpper();
                response = CustomerInput(response);
                return response;

            }
             
        }

        static void Main()
        {
            string first_name;
            string last_name;
            string addressOne;
            string addressTwo;
            string tel;
            string customerStatus;
            
            Customer customer = new Customer();
            AtmTransaction transaction = new AtmTransaction();
            System.Console.WriteLine("Are you an exisiting customer?: ");
            customerStatus = System.Console.ReadLine();
            
            //Check if customer answered with correct response

            customerStatus = transaction.CustomerInput(customerStatus.ToUpper());
            if (customerStatus == "N" || customerStatus == "NO")
            {
                System.Console.WriteLine("Please enter your first name ");
                first_name = System.Console.ReadLine();
                System.Console.WriteLine("Please enter your last name");
                last_name = System.Console.ReadLine();
                System.Console.WriteLine("Please enter your address");
                addressOne = System.Console.ReadLine();
                System.Console.WriteLine("Please enter your city and province");
                addressTwo = System.Console.ReadLine();
                System.Console.WriteLine("Please enter your phone number");
                tel = System.Console.ReadLine();
                customer.SetCustomerInfo(first_name, last_name, addressOne, "", tel);
            }
           
                
                    

                
            
            
            


        }

    }
     
}
