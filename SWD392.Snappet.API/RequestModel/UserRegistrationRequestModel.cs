﻿namespace SWD392.Snappet.API.RequestModel
{
    public class UserRegistrationRequestModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string AccountType { get; set; }
    }
}