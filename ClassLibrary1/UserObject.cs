using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InFundWebCode
{
    public class UserObject
    {
        string UserID;
        public UserObject(string userID)
        {
            UserID = userID;
        }

        public string GetCurrentBorrowerProfilePhoto()
        {
            return "img/Colosseum.png";
        }

        public string GetCurrentBorrowerProfileName()
        {
            return "Alessio";
        }

        public string GetCurrentBorrowerStatus()
        {
            return "Profile Creation";
        }
    }
}
