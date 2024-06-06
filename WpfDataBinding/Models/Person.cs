using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDataBinding.Models
{
    enum SexCd
    {
        Male,
        Female
    }
    class Person
    {
        public string Name { get; set; }
        public string Firstname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public SexCd SexCd { get; set; }
        public Person()
        {
        }

        public Person( string name, string firstname, DateTime dateOfBirth, SexCd sexCd)
        {
            this.Name = name;
            this.Firstname = firstname;
            this.DateOfBirth = dateOfBirth;
            this.SexCd = sexCd;
        }


        public override string ToString()
        {
            return $"{this.Firstname} {this.Name}";
        }
    }
}
