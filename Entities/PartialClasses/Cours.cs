using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Entities
{
    public partial class Cours
    {
        public string CareerName
        {
            get
            {
                return this.Career.Name;
            }
            set
            {

            }
        }
    }
}
