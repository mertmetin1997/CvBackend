using Core.DataAccess;
using cvProject.DataAccess.Abstract;
using cvProject.DataAccess.Contexts;
using cvProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.DataAccess.Concrete.EntityFramework
{
    public class EfExperienceRepository : EfGenericRepository<Experience, CvDbContext>, IExperienceRepository
    {
        public EfExperienceRepository(CvDbContext context) : base(context)
        {
        }
    }
}
