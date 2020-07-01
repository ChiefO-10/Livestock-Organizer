using LivestockOrganizer.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
//using AnimalDA = LivestockDataAccess.Animal;

namespace LivestockOrganizer.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<Animal> _animals;

        public ObservableCollection<Animal> Animals
        {
            get { return _animals; }
            set
            {
                _animals = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            // Recodrds for tests
            //Animals = new ObservableCollection<Animal>
            //{
            //    new Animal {Id=1, AnimalNumber="2131",Country="Polska",Gender = "Female", MotherNumber="111", FatherNumber ="222", DateOfBirth = "02/02/2020",
            //        HerdNumber = "999999", PlaceOfBirth= "Balin",PassportSerial = "AXA2131", PassportDate = "02/02/2030"},

            //    new Animal {Id=1, AnimalNumber="2131",Country="Polska",Gender = "Female", MotherNumber="111",FatherNumber ="222", DateOfBirth = "02/02/2020",
            //        HerdNumber = "999999", PlaceOfBirth= "Balin",PassportSerial = "AXA2131", PassportDate = "02/02/2030"},

            //    new Animal {Id=1, AnimalNumber="2131",Country="Polska",Gender = "Female", MotherNumber="111",FatherNumber ="222", DateOfBirth = "02/02/2020",
            //        HerdNumber = "999999", PlaceOfBirth= "Balin",PassportSerial = "AXA2131", PassportDate = "02/02/2030"},

            //    new Animal {Id=1, AnimalNumber="2131",Country="Polska",Gender = "Female", MotherNumber="111",FatherNumber ="222", DateOfBirth = "02/02/2020",
            //        HerdNumber = "999999", PlaceOfBirth= "Balin",PassportSerial = "AXA2131", PassportDate = "02/02/2030"}
            //};

        }

        private ICommand _getLivestockListCommand;
        public ICommand GetLivestockListCommand
        {
            get
            {
                if (_getLivestockListCommand == null)
                {
                    _getLivestockListCommand = new RelayCommand(p => this.GetAnimalList());
                }
                return _getLivestockListCommand;
            }
        }

        private void GetAnimalList()
        {
            Animals = new ObservableCollection<Animal>();
            var animalAdapter = new LivestockDataAccess.AnimalAdapter();
            var dbAnimals = animalAdapter.GetAllAnimals("LivestockDB");
            foreach (var a in dbAnimals)
            {
                var animalObject = new Animal(a);

                Animals.Add(animalObject);
            }
        }

        private ICommand _addAnimalRecordCommand;
        private ICommand AddAnimalRecordCommand
        {
            get
            {
                if (_addAnimalRecordCommand == null)
                {
                    _addAnimalRecordCommand = new RelayCommand(p => AddAnimalRecord());
                }
                return _addAnimalRecordCommand;
            }
        }

        private void AddAnimalRecord()
        {
            throw new NotImplementedException();
        }
        private ICommand _getAnimalRecordByNumberCommand;
        private ICommand GetAnimalRecordByNumberCommand
        {
            get
            {
                if (_addAnimalRecordCommand == null)
                {
                    _addAnimalRecordCommand = new RelayCommand(p => GetAnimalRecordByNumber());
                }
                return _addAnimalRecordCommand;
            }
        }
        private void GetAnimalRecordByNumber()
        {
            Animals = new ObservableCollection<Animal>();
            var animalAdapter = new LivestockDataAccess.AnimalAdapter();
            var dbAnimals = animalAdapter.GetAnimalsByNumber("LivestockDB",);
            foreach (var a in dbAnimals)
            {
                var animalObject = new Animal(a);

                Animals.Add(animalObject);
            }
        }
    }
}
