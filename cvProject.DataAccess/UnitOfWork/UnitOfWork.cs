using Core.UnitOfWorks;
using cvProject.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.DataAccess.UnitOfWork
{
    public class UnitOfWork(CvDbContext context) : IUnitOfWork
    {
        private readonly CvDbContext _context = context;


        // primary constructor oluşturuduğum için bu satırı kaldırdım
        //private readonly CvDbContext _context;

        //public UnitOfWork(CvDbContext context)
        //{
        //    _context = context;
        //}

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
