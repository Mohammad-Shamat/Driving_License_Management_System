using System;


namespace DVLD___Driving_License_Management.Global_Classes
{
    public class ClsFormat
    {
        public static string DateToShort(DateTime Dt1)
        {

            return Dt1.ToString("dd/MMM/yyyy");
        }

    }
}
