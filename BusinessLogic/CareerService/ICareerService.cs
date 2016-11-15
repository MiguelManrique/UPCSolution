using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.CareerService
{
    public interface ICareerService
    {
        List<Career> GetAllCareers();
    }
}
