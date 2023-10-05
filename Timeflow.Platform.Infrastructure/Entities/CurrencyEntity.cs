using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timeflow.Platform.Infrastructure.Entities
{
    public class CurrencyEntity: BaseEntity<int>
    {
        public string Name { get; set; } = null!;

        public string Abbreviation { get; set; } = null!;
    }
}
