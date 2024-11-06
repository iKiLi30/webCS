using System;


namespace postgresEFC
{
    public class User
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required string Email { get; set; }
        
    }
}