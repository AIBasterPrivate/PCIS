using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCIS.Entity
{
    internal class User
    {
        public int Id { get; set; } = 1;//id
        public Person Person { get; set; }

        public override string? ToString()
        {
            return new StringBuilder()
                .AppendLine($"Person: {Person}")
                .AppendLine($"TicketNumber: {Id}")
                .ToString();
        }
    }
}
