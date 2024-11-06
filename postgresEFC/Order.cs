using System;


namespace postgresEFC
{
    public class Order
    {
        public required  int Id { get; set; }
        public required int UserId { get; set; }
        public required DateTime OrderDate { get; set; }
        public required User User { get; set; }
    }
}