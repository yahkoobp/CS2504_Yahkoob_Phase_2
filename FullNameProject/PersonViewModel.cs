using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace FullNameProject
{
    public delegate void DWidnowClose();
    public class PersonViewModel : INotifyPropertyChanged
    {
        public DWidnowClose NewWindowClose;
        public DWidnowClose EditWindowClose;
        //
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        //        
        private PersonModel _person = null;
        public PersonModel Person
        {
            get => _person;
            set { _person = value; OnPropertyChanged(nameof(Person)); }
        }
        //
        private PersonModel _editablePerson = null;
        public PersonModel EditablePerson
        {
            get => _editablePerson;
            set { _editablePerson = value; OnPropertyChanged(nameof(EditablePerson)); }
        }
  
        public ICommand CreateCommand { get; }
        public ICommand UpdateCommand { get; }
        public ICommand DeleteCommand { get; }
        //
        public PersonViewModel()
        {
            this.Person = new PersonModel { FirstName = "Rishwin", LastName = "R Kanth" };
            this.EditablePerson = new PersonModel();
            UpdateCommand = new RelayCommand(Update);
        }
        public void Update()
        {
            if (this.EditablePerson == null)
            {
                return;
            }
            this.Person.FirstName = this.EditablePerson.FirstName;
            this.Person.LastName = this.EditablePerson.LastName;
            this.Person = Person;
            var result = MessageBox.Show(messageBoxText: "Updated Successfully",
                    caption: "Alert",
                    button: MessageBoxButton.OK,
                    icon: MessageBoxImage.Information);
            if (EditWindowClose != null)
            {
                EditWindowClose();
            }
        }
    }
}
