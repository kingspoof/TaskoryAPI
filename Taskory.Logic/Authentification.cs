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

        public static ReturnCodes CheckTransmitionCode(DTO dto)
        {
            //TODO rewortk the authorisation
            string[] parts = dto.TransmitionCode.Split("-");
            if (parts.Length == 3)
            {
                int primary = Convert.ToInt32(parts[0]);
                DateTime SentAt = Convert.ToDateTime(parts[1]);
                int secondary = Convert.ToInt32(parts[2]);

                if (primary > 0 && primary < 4 && SentAt > DateTime.Now.AddMinutes(-5))
                    if (primary == (secondary / dto.TransmitionUser))
                        return (ReturnCodes)primary;
                
            }

            return (ReturnCodes)1;
            
        }
    }
}
