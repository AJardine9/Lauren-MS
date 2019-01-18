using MVCWorld.Client.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWorld.Client.Models
{
    public class Invitation
    {
        [StringValidator(ErrorMessage = "Only Alpha characters please")]
        [MaxLength(25)]
        //[DataType(DataType.EmailAddress)]
        public string Name { get; set; }

        [Range(0,5, ErrorMessage = "No more than 5")]
        public int Guests { get; set; }

        [Display(Name = "GlutenOption")]
        public string Menu { get; set; }

        //[RsvpValidation()]
        public bool Rsvp { get; set; }

        public string Message { get; set; }
    }
}
