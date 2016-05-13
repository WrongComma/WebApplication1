using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InFundWebCode
{
    public class LoginUser
    {
        /// <summary>
        /// This allows the creation of a new account on the system:
        /// </summary>
        /// <param name="Username">The username they have entered</param>
        /// <param name="email">The (unencrypted) password</param>
        /// <param name="Password">Their contact address</param>
        /// <returns>Okay if no error or error message is diplayed</returns>
        public ErrorMessage CreateAccount(string Username, string email, string Password)
        {
            //Does this username already exist on the stytem? 
            if (UserExist(Username) == true)
            {
                //If it does, warn the user that they need to select a different username
                return ErrorMessage.UserExist;
            }

            //If it doesn't, check the email address - is there already a user with this email address?
            if (EmailExist(email) == true)
            {
                //If there is, warn the user they cannot create two accounts with the same email address, so they should reset their password
                return ErrorMessage.EmailExist;
            }
            //If there isn't, check that the email address is a valid one (use regular experssio)
            if (EmailValid(email) == false)
            {
                //If the address is not valid, tell the user to write the email address correctly
                return ErrorMessage.EmailNotValid;
            }
            //Is the password considered a strong password?

            if (PasswordStrong(Password) == false)
            {
                //If not, tell the user they should create a strong password and give hints as to how to do this
                return ErrorMessage.PasswordNotStrong;
            }
            //If everything okay, we need to create them in the system and then send an email to confirm that their account has been created
            string UserId = CreateAccountOnSystem(Username, email, Password);
            SendConfirmationEmail(email, UserId);
            // and we are finished!
            return ErrorMessage.Okay;
        }

        public string Login(string Username, string Password)
        {
            if ((Username == "Alessio") && (Password == "Password"))
                return "1";
            else
                return "";
        }



        protected bool UserExist(string Username)
        {
            //PLACEHOLDER - for now just return false - the username is not on the system
            return false;
        }


        protected bool EmailExist(string email)
        {
            //PLACEHOLDER - for now just return false - the email is not on the system
            return false;
        }

        protected bool EmailValid(string email)
        {
            //PLACEHOLDER - for now just return false - the email is valid
            return true;
        }

        protected bool PasswordStrong(string Password)
        {
            //PLACEHOLDER - for now just return false - the password is strong
            return true;
        }
        protected void SendConfirmationEmail(string email, string UserId)
        {
            // Placeholder for now:
        }
        protected string CreateAccountOnSystem(string Username, string email, string Password)
        {
        // Placeholder for now:
        return "1";
        }

        }
    /// <summary>
    /// This is used to return an error message or "okay" if no error occurs
    /// </summary>
    public enum ErrorMessage { Okay, UserExist, EmailExist, EmailNotValid, PasswordNotStrong }
}
	

