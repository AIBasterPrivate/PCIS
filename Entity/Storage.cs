using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCIS.Entity
{
    internal class Storage
    {
        public int BookId { get; set; } = 1;
        public int AbsoluteAmount { get; set; } = 0;
        public int CurrentAmount { get; set; } = 0;

        public override string? ToString()
        {
            return new StringBuilder()
                .AppendLine($"BookId: {BookId}")
                .AppendLine($"AbsoluteAmount: {AbsoluteAmount}")
                .AppendLine($"CurrentAmount: {CurrentAmount}")
                .ToString();
        }
    }
}
