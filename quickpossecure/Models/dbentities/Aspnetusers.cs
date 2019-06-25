﻿using System;
using System.Collections.Generic;

namespace quickpossecure.Models.dbentities
{
    public partial class Aspnetusers
    {
        public Aspnetusers()
        {
            Aspnetuserclaims = new HashSet<Aspnetuserclaims>();
            Aspnetuserlogins = new HashSet<Aspnetuserlogins>();
            Aspnetuserroles = new HashSet<Aspnetuserroles>();
            Closing = new HashSet<Closing>();
            FinanceTransaction = new HashSet<FinanceTransaction>();
        }

        public string Id { get; set; }
        public int AccessFailedCount { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public bool LockoutEnabled { get; set; }
        public DateTime? LockoutEnd { get; set; }
        public string NormalizedEmail { get; set; }
        public string NormalizedUserName { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public string SecurityStamp { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public string UserName { get; set; }

        public ICollection<Aspnetuserclaims> Aspnetuserclaims { get; set; }
        public ICollection<Aspnetuserlogins> Aspnetuserlogins { get; set; }
        public ICollection<Aspnetuserroles> Aspnetuserroles { get; set; }
        public ICollection<Closing> Closing { get; set; }
        public ICollection<FinanceTransaction> FinanceTransaction { get; set; }
    }
}
