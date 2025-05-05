using cloud_backend;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var bookings = new List<Booking>
{
    new Booking(1, "Mr",     "John",      "Doe",    "johndoe@doe.com",           2, "2017-11-21", "2017-11-23"),
    new Booking(2, "Doctor", "Sadia",     "Begum",  "begum_sadia@sadia.org",     1, "2018-02-15", "2018-02-28"),
    new Booking(3, "Prince", "Henry",     "Wales",  "harry@wales.com",           5, "2018-03-01", "2018-04-09"),
    new Booking(4, "Dame",   "Judi",      "Dench",  "Judi@dench.co.uk",          6, "2017-12-25", "2018-01-03"),
    new Booking(5, "Madam",  "Anuradha",  "Selvam", "anu@selvam.net",            3, "2017-08-30", "2017-10-02")
};

app.MapGet("/", () => "Hello World!");
app.MapGet("/bookings", () => Results.Ok(bookings));
app.Run();
