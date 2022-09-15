using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCIS.Entity
{
    internal class Book
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; } = "DefaultName";
        public int AuthorId { get; set; } = 1;
        public float Price { get; set; } = 0f;

        public override string? ToString()
        {
            return new StringBuilder()
                .AppendLine($"Id: {Id}")
                .AppendLine($"Name: {Name}")
                .AppendLine($"AuthorId: {AuthorId}")
                .AppendLine($"Price: {Price}")
                .ToString();
        }
    }
}
