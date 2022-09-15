using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCIS.Entity
{
    internal class BooksOutStorage
    {
        public Book Book { get; set; }
        public User User { get; set; }
        public DateTime TakeAwayTime { get; set; } = DateTime.Now;
        public DateTime GiveAwayTime { get; set; } = DateTime.Now;
        public bool IsReturned { get; set; } = false;

        public override string? ToString()
        {
            return new StringBuilder()
                .AppendLine($"Book: {Book}")
                .AppendLine($"User: {User}")
                .AppendLine($"TakeAwayTime: {TakeAwayTime}")
                .AppendLine($"GiveAwayTime: {GiveAwayTime}")
                .AppendLine($"IsReturned: {IsReturned}")
                .ToString();
        }
    }
}
