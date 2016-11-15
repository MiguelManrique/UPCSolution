using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.CareerRepository
{
    public interface ICareerRepository
    {
        List<Career> GetAllCareers();
    }
}
