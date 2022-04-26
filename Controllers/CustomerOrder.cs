using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class CustomerOrder
    {
        
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        
        public char MiddleInitial { get; set; }

        [Required]
        public string Address1 { get; set; }
       
        public string Address2 { get; set; }

        public string ApartmentNumber { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        [RegularExpression(@"^\d{5}(-\{4})?$", ErrorMessage ="Invalid Zip")]
        public string ZipCode { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [CreditCard]
        public string CreditCard { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        public List<Pizza> Pizzas { get; set; }





    }
}
