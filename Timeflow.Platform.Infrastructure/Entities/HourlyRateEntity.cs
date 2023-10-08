using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timeflow.Platform.Infrastructure.Entities
{
    public class HourlyRateEntity : BaseEntity<int>
    {
        public int ProjectId { get; set; }

        public int ContractId { get; set; }

        public decimal Rate { get; set; }

        public int CurrencyId { get; set; }
    }
}
