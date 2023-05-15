using System.ComponentModel;

namespace Ispit.MVC.Models
{
    public class Student
    {

        [DisplayName("Šifra studenta:")]
        public int Id { get; set; }

        [DisplayName("Ime i prezime:")]
        public string Name { get; set; }

        [DisplayName("Starost:")]
        public int Age { get; set; }

        [DisplayName("Fakultet:")]
        public string Bio { get; set; }
    }
}
