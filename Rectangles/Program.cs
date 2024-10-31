
// Crear una instancia de HotelBooking
HotelBooking booking = new HotelBooking("Juan Pérez", DateTime.Now, 5);

// Imprimir los detalles de la reserva
Console.WriteLine($"Guest Name: {booking.GuestName}");
Console.WriteLine($"Start Date: {booking.StartDate}");
Console.WriteLine($"End Date: {booking.EndDate}");

Console.ReadKey();
class HotelBooking
{
    public string GuestName;
    public DateTime StartDate;
    public DateTime EndDate;

    public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
    {
        GuestName = guestName;
        StartDate = startDate;
        EndDate = startDate.AddDays(lengthOfStayInDays);

    }
}


