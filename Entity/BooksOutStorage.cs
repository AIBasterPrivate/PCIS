using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCIS.Entity
{
    internal class BooksOutStorage
    {
        public int BookId { get; set; } = 1;
        public int UserId { get; set; } = 1;
        public DateTime TakeAwayTime { get; set; } = DateTime.Now;
        public DateTime GiveAwayTime { get; set; } = DateTime.Now;
        public bool IsReturned { get; set; } = false;

        public override string? ToString()
        {
            return new StringBuilder()
                .AppendLine($"BookId: {BookId}")
                .AppendLine($"UserId: {UserId}")
                .AppendLine($"TakeAwayTime: {TakeAwayTime}")
                .AppendLine($"GiveAwayTime: {GiveAwayTime}")
                .AppendLine($"IsReturned: {IsReturned}")
                .ToString();
        }
    }
}
