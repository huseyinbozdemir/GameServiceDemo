using System;
using System.Collections.Generic;
using System.Text;

namespace GameServiceDemo
{
    class MernisValidateService : ValidateService
    {
        public void ValidatePerson(Person person)
        {
            if (person.Name.Length > 1 && person.LastName.Length > 1 && person.IdentificationNumber.Length == 11 && person.YearOfBith > 1900)
            {
                Console.WriteLine(person.Name + " " + person.LastName + " mernis doğrulamasından geçti.");
            }
            else
            {
                throw new Exception(person.Name + " " + person.LastName + " mernis doğrulamasından geçemedi.");

            }
        }
    }
}
