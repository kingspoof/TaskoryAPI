using System;
using Taskory.DAL.Models;

namespace Taskory.Logic
{
    public class Authentification
    {
        public static string GenerateTransmitionCode(User user)
        {

            //TODO Rework the codes
            //secondary is userid multiplied with 79 for admin privilegies
            int primary = user.ID * 79;
            int secondary = 0;

            return $"{primary}-[1234]-{secondary}";
        }

        public static ReturnCodes CheckTransmitionCode(string transponderCode)
        {
            //TODO rewortk the authorisation

            return ReturnCodes.SA;
            
        }

        public static bool HasPermission(string transponderCode, ReturnCodes requiredPermission)
        {
            ReturnCodes userpermission = CheckTransmitionCode(transponderCode);



            


            return true;
        }
    }
}
