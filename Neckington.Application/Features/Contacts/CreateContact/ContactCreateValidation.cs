using FluentValidation;
using Neckington.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Application.Features.Contacts.CreateContact
{
    public class ContactCreateValidation: AbstractValidator<ContactDTO>
    {
        public ContactCreateValidation() 
        {
            RuleFor(contactDTO => contactDTO.FirstName).NotEmpty().WithMessage("FirstName is obligatory");
            RuleFor(contactDTO => contactDTO.LastName).NotEmpty().WithMessage("LastName is obligatory");
            RuleFor(contactDTO => contactDTO.UserEmail)
            .Must(UserEmail => UserEmail.Contains("@"))
            .NotNull().NotEmpty();
            RuleFor(contactDTO => contactDTO.Address)
            .Length(1, 60).NotEmpty();
            RuleFor(contactDTO => contactDTO.PhoneNumber).MaximumLength(10).WithMessage("Phone number is required.");

        }
    }
}
