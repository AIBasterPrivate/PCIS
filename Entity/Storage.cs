using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCIS.Entity
{
    internal class Storage
    {
        public Book Book { get; set; }
        public int AbsoluteAmount { get; set; } = 0;
        public int CurrentAmount { get; set; } = 0;

        public override string? ToString()
        {
            return new StringBuilder()
                .AppendLine($"Book: {Book}")
                .AppendLine($"AbsoluteAmount: {AbsoluteAmount}")
                .AppendLine($"CurrentAmount: {CurrentAmount}")
                .ToString();
        }
    }
}
