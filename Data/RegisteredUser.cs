using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubMembershipApplication.FieldValidators;
using ClubMembershipApplication.Models;

namespace ClubMembershipApplication.Data
{
    public class RegisteredUser : IRegister

    {
        public bool EmailExists(string emailAddress)
        {
            bool emailExists = false;
            using (var dbContext = new ClubMembershipDbContext())
            {
                emailExists = dbContext.Users.Any(u => u.EmailAddress.ToLower().Trim() == emailAddress.ToLower().Trim());
            }
            return emailExists;
        }

        public bool Register(string[] fields)
        {
            using (var dbContext = new ClubMembershipDbContext())
            {
                User user = new User
                {
                    EmailAddress = fields[(int)FieldConstants.UserRegistrationField.EmailAddress],
                    FirstName = fields[(int)FieldConstants.UserRegistrationField.FirstName],
                    LastName = fields[(int)FieldConstants.UserRegistrationField.LastName],
                    Password = fields[(int)FieldConstants.UserRegistrationField.Password],
                    DateOfBirth = DateTime.Parse(fields[(int)FieldConstants.UserRegistrationField.DateOfBirth]),
                    PhoneNumnber = fields[(int)FieldConstants.UserRegistrationField.PhoneNumber],
                    AddressCity = fields[(int)FieldConstants.UserRegistrationField.AddressCity],
                    AddressFirstLine = fields[(int)FieldConstants.UserRegistrationField.AddressFirstLine],
                    AddressSecondLine = fields[(int)FieldConstants.UserRegistrationField.AddressSecondLine],
                    PostCode = fields[(int)FieldConstants.UserRegistrationField.PostCode]

                };

                dbContext.Users.Add(user);
                dbContext.SaveChanges();

            }
            return true;

        }
    }
}
