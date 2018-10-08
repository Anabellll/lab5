using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Models
{//here we are making a person class, where we want these foloowing information  of a person.
    public class Person
    {

        public string PersonId { get; set; }

        //setting avlidation in order to take valid inputs from user.
        [Required(ErrorMessage = "please enter your First Name")]
        [StringLength(15 ,MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "please enter your Middle Name")]
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "please enter your Last Name")]
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "please enter your Date of birth")]
        [DataType(DataType.Date)]
        public string DateOfBirth { get; set; }


        public string AddedOn { get; set; }
        public string AddedBy { get; set; }

        [Required(ErrorMessage = "please enter your Home address")]
        public string HomeAddress { get; set; }

        [Required(ErrorMessage = "please enter your HomeCity")]
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string HomeCity { get; set; }

        [Required(ErrorMessage = "please enter your facebookId")]
        [RegularExpression(".+\\@.+", ErrorMessage = " Invalid Format, Kindly enter ID in valid format")]
        public string FaceBookAccountId { get; set; }

        [Required(ErrorMessage = "please enter your LinkedinId")]
        [RegularExpression(".+\\@.+", ErrorMessage = " Invalid Format, Kindly enter ID in valid format")]
        public string LinkedId { get; set; }


        public string UpdateOn { get; set; }
        public string ImagePath { get; set; }

        [Required(ErrorMessage = "please enter your TwitterId")]
        [RegularExpression(".+\\@.+", ErrorMessage = " Invalid Format, Kindly enter ID in valid format")]
        public string TwitterId { get; set; }

        [Required(ErrorMessage = "please enter your GmailId")]
        [RegularExpression(".+\\@.+", ErrorMessage = " Invalid Format, Kindly enter ID in valid format")]
        public string EmailId { get; set; }

    }

    public class Contact
    {
        public string ContactId { get; set; }

        [Required(ErrorMessage = "please enter your Contact Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        public string ContactNumber { get; set; }


        public string Type { get; set; }
        public string PersonId { get; set; }
    }
}