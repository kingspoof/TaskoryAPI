using System;
using Taskory.DAL.Models;
using Taskory.DAL;
using System.Linq;

namespace Taskory.Logic
{
    public class Authentification
    {
        public static string GenerateTransmitionCode(User user, int OID)
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            //TODO Rework the codes
            //secondary is userid multiplied with 79 for admin privilegies
            int primary = user.ID * 79;
            int secondary = OID;
            return $"{primary}-[1234]-{secondary}";
        }

        public static ReturnCodes CheckTransmitionCode(string transponderCode)
        {
            return ReturnCodes.SA;
        }

        public static bool HasPermission(string transponderCode, ReturnCodes requiredPermission)
        {
            ReturnCodes userpermission = CheckTransmitionCode(transponderCode);
            return true;
        }
    }
}
