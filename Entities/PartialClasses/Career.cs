using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public partial class Career
    {
        public override string ToString()
        {
            return this.Id + "-" + this.Name;
        }
    }
}
