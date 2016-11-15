using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.CareerRepository
{
    public class CareerRepository : ICareerRepository
    {
        public List<Entities.Career> GetAllCareers()
        {
            UPCModelEntities UPCModel = new UPCModelEntities();
            List<Career> careers = (from c in UPCModel.Careers
                                    //where c.Name.Contains("ing")
                                   select c).ToList();
            return careers;
        }
    }
}
