﻿using System.ComponentModel;

namespace TicketEase.Application.DTO
{
    public class AppUserDto
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }

        [DefaultValue(true)]
        public bool IsActive { get; set; }
    }
}
