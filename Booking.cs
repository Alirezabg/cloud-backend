namespace cloud_backend
{
    public record Booking(
    int Id,
    string Title,
    string FirstName,
    string Surname,
    string Email,
    int RoomId,
    string CheckInDate,
    string CheckOutDate
);
}
