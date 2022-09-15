using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCIS.Entity
{
    internal class Author
    {
        public int Id { get; set; } = 1;
        public string Firstname { get; set; } = "DefaultFirstName";
        public string Lastname { get; set; } = "DefaultLastName";

        public override string? ToString()
        {
            return new StringBuilder()
                .AppendLine($"Id: {Id}")
                .AppendLine($"Firstname: {Firstname}")
                .AppendLine($"Lastname: {Lastname}")
                .ToString();
        }
    }
}
