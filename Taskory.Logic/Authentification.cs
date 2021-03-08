using System;
using Taskory.DAL.Models;

namespace Taskory.Logic
{
    public class Authentification
    {
        public static string GenerateTransmitionCode(User user)
        {

            //TODO Rework the codes
            int primary = user.ID * 3;
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
