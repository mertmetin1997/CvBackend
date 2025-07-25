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
    public class EfPersonalInfoRepository : EfGenericRepository<PersonalInfo, CvDbContext>, IPersonalInfoRepository
    {
        public EfPersonalInfoRepository(CvDbContext context) : base(context)
        {
        }
    }
}
