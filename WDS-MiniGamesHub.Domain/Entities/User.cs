﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WDS_MiniGamesHub.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public bool IsDeleted { get; set; }
    }
}
