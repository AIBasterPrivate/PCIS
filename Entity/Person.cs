using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCIS.Entity
{
    internal class Person
    {
        public int Id { get; set; } = 1;
        public string Firstname { get; set; } = "DefaultFirstName";
        public string Lastname { get; set; } = "DefaultLastName";
        public string Fathername { get; set; } = "DefaultFatherName";
        public string Adress { get; set; } = "DefaultAdress";
        public DateTime Birthday { get; set; } = DateTime.MinValue;
        public string PhoneNumber { get; set; } = "+10234567890";

        public override string? ToString()
        {
            return new StringBuilder()
                .AppendLine($"Id: {Id}")
                .AppendLine($"Firstname: {Firstname}")
                .AppendLine($"Lastname: {Lastname}")
                .AppendLine($"Fathername: {Fathername}")
                .AppendLine($"Adress: {Adress}")
                .AppendLine($"BirthDay: {Birthday}")
                .AppendLine($"PhoneNumber: {PhoneNumber}")
                .ToString();
        }
    }
}
