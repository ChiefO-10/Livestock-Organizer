using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivestockOrganizer.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string AnimalNumber { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public string MotherNumber { get; set; }
        public string FatherNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string HerdNumber { get; set; }
        public string PlaceOfBirth  { get; set; }
        public string PassportSerial { get; set; }
        public string PassportDate { get; set; }

        public Animal()
        {

        }
        public Animal(LivestockDataAccess.Animal DBAnimal)
        {
            Id              = DBAnimal.Id;
            AnimalNumber    = String.IsNullOrEmpty(DBAnimal.AnimalNumber)   ? "Null" : DBAnimal.AnimalNumber;
            Country         = String.IsNullOrEmpty(DBAnimal.Country)        ? "Null" : DBAnimal.Country;
            Gender          = String.IsNullOrEmpty(DBAnimal.Gender)         ? "Null" : DBAnimal.Gender;
            MotherNumber    = String.IsNullOrEmpty(DBAnimal.MotherNumber)   ? "Null" : DBAnimal.MotherNumber;
            FatherNumber    = String.IsNullOrEmpty(DBAnimal.FatherNumber)   ? "Null" : DBAnimal.FatherNumber;
            DateOfBirth     = String.IsNullOrEmpty(DBAnimal.DateOfBirth)    ? "Null" : DBAnimal.DateOfBirth;
            HerdNumber      = String.IsNullOrEmpty(DBAnimal.HerdNumber)     ? "Null" : DBAnimal.HerdNumber;
            PlaceOfBirth    = String.IsNullOrEmpty(DBAnimal.PlaceOfBirth)   ? "Null" : DBAnimal.PlaceOfBirth;
            PassportSerial  = String.IsNullOrEmpty(DBAnimal.PassportSerial) ? "Null" : DBAnimal.PassportSerial;
            PassportDate    = String.IsNullOrEmpty(DBAnimal.PassportDate)   ? "Null" : DBAnimal.PassportDate;
        }
    }
}