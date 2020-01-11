using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicShare.Models
{
    public class Customer
    {
#nullable enable
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(200)]
        public string? Address { get; set; }

        [Phone]
        public string? Phone { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [RegularExpression("[a-zA-Z]{2}[0-9]{2}[a-zA-Z0-9]{4}[0-9]{7}([a-zA-Z0-9]?){0,16}", ErrorMessage = "Invalid IBAN number.")]
        public string? BankAccount { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateEdited { get; set; }

        [Url]
        public string? ImageUrl { get; set; }

        public ApplicationUser? Owner { get; set; }
#nullable disable

    }
}
