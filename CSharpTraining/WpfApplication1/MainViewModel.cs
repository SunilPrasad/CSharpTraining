using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public List<Person> Persons { get; set; }
        public List<Student> Students { get; set; }

        public MainViewModel()
        {
            Persons = new List<Person>();
            Students = new List<Student>();

            Students.Add(new Student("StudentA"));
            Students.Add(new Student("StudentB"));
            Students.Add(new Student("StudentC"));
            Students.Add(new Student("StudentD"));

            Persons.Add(new Person("PersonA"));
            Persons.Add(new Person("PersonB"));
            Persons.Add(new Person("PersonC"));
            Persons.Add(new Person("PersonD"));
        }

        private Person _selectedPerson;
        public Person SelectedPerson
        {
            get
            {
                return _selectedPerson;
            }
            set
            {
                if (_selectedPerson == value) return;
                _selectedPerson = value;
                OnPropertyChanged("SelectedPerson");
                SelectedStudent = null;
            }
        }

        private Student _selectedStudent;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int _selectedStudentIndex;
        public int SelectedStudentIndex
        {
            get
            {
                return _selectedStudentIndex;
            }
            set
            {
                if (_selectedStudentIndex == value) return;
                _selectedStudentIndex = value;
                OnPropertyChanged("SelectedStudentIndex");

            }
        }

        private int _selectedPersonIndex;
        public int SelectedPersonIndex
        {
            get
            {
                return _selectedPersonIndex;
            }
            set
            {
                if (_selectedPersonIndex == value) return;
                _selectedPersonIndex = value;
                OnPropertyChanged("SelectedPersonIndex");
                
            }
        }

        public Student SelectedStudent
        {
            get
            {
                return _selectedStudent;
            }
            set
            {
                if (_selectedStudent == value) return;
                SelectedPerson = null;
                _selectedStudent = value;
                OnPropertyChanged("SelectedStudent");
            }
        }
    }


    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }

    public class Student
    {
        public Student(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
