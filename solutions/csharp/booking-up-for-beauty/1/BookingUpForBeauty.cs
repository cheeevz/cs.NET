using System;
using System.Globalization;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        if (DateTime.TryParse(
                appointmentDateDescription,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime result))
        {
            return result;
        }

        throw new FormatException($"Unable to parse '{appointmentDateDescription}' as a valid appointment date/time.");
    }
    

    public static bool HasPassed(DateTime appointmentDate)
    {
        return appointmentDate < DateTime.Now;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        return appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;
    }

    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate:M/d/yyyy} {appointmentDate:h:mm:ss tt}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Now.Year, 9, 15);
    }
}
