using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCIS.Entity
{
    internal class User
    {
        public int PersonId { get; set; } = 1;
        public string TicketNumber { get; set; } = "00001";

        public override string? ToString()
        {
            return new StringBuilder()
                .AppendLine($"PerosnId: {PersonId}")
                .AppendLine($"TicketNumber: {TicketNumber}")
                .ToString();
        }
    }
}
