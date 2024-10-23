using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    internal class Register
    {
        //__________Atributes/Constructor/GettersAndSetters
        #region
        private int lastUserId = 0;
        private int userId;
        private String userName;
        private String userEmail;
        private String userPassword;
    
        public Register(int userId, string userName, string userEmail, string userPassword)
        {
            this.UserId = userId;
            this.UserName = userName;
            this.UserEmail = userEmail;
            this.UserPassword = userPassword;
        }

        public int LastUserId { get => lastUserId; set => lastUserId = value; }
        public int UserId { get => userId; set => userId = value; }
        public string UserName { get => userName; set => userName = value; }
        public string UserEmail { get => userEmail; set => userEmail = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        #endregion

        //__________Methods
        #region
        public bool RegisterUser(string userName, string userEmail, string userPassword)
        {
            char ansRegister;
            // Validation
            do
            {
                if (string.IsNullOrEmpty(userName))
                {
                    Console.WriteLine("The user name can not be empty!");
                    return false;
                }

                if (!ValidateEmail(userEmail))
                {
                    Console.WriteLine("E-mail invalid.");
                    return false;
                }

                if (!ValidatePassword(userPassword))
                {
                    Console.WriteLine("The password can not have less than 6 caracters! ");
                    return false;
                }
                Console.WriteLine("Would you like to register? (Y or anything ele to No)");
                ansRegister = Console.ReadLine().ToUpper();
            } while (ansRegister == "Y");

            //If all the validations are right
            this.LastUserId++;
            this.UserId = LastUserId;
            this.UserName = userName;
            this.UserEmail = userEmail;
            this.UserPassword = userPassword;

            Console.WriteLine("User successfully registered!");
            return true;
        }
        #endregion
    }
    internal class Service
    {
        private int id;
    }
}
