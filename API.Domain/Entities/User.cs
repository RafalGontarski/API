﻿using System.ComponentModel.DataAnnotations;

namespace API.Domain.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? Company {  get; set; }
        public string? FirstName { get; set; }        
        public string? LastName { get; set; }        
        public string? Address { get; set; }        
        public string? PostalCode { get; set; }        
        public string? City { get; set; }        
        public string? Country { get; set; }        
        public string? Email { get; set; }
        public string? Password { get; set; }
        public IList<Role> Roles { get; set; } = [];

    }
}
