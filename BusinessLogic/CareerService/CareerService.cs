using DataAccess.CareerRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.CareerService
{
    public class CareerService : ICareerService
    {
        public List<Entities.Career> GetAllCareers()
        {
            ICareerRepository repository = new CareerRepository();
            return repository.GetAllCareers();
        }
    }
}
