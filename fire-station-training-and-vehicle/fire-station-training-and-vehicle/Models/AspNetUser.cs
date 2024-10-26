﻿using System;
using System.Collections.Generic;

namespace fire_station_training_and_vehicle.Models
{
    public partial class AspNetUser
    {
        public AspNetUser()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaim>();
            AspNetUserLogins = new HashSet<AspNetUserLogin>();
            AspNetUserTokens = new HashSet<AspNetUserToken>();
            AssignedEvents = new HashSet<AssignedEvent>();
            AssignedTasks = new HashSet<AssignedTask>();
            Documents = new HashSet<Document>();
            VehicleReports = new HashSet<VehicleReport>();
            Roles = new HashSet<AspNetRole>();
        }

        public string Id { get; set; } = null!;
        public string? UserName { get; set; }
        public string? NormalizedUserName { get; set; }
        public string? Email { get; set; }
        public string? NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string? PasswordHash { get; set; }
        public string? SecurityStamp { get; set; }
        public string? ConcurrencyStamp { get; set; }
        public string? PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? IsPasswordChanged { get; set; }
        public string? Address { get; set; }
        public int StationId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Station Station { get; set; } = null!;
        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual ICollection<AssignedEvent> AssignedEvents { get; set; }
        public virtual ICollection<AssignedTask> AssignedTasks { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<VehicleReport> VehicleReports { get; set; }

        public virtual ICollection<AspNetRole> Roles { get; set; }
    }
}
