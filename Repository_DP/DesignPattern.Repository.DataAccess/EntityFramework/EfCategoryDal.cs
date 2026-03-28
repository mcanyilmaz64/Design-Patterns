using DesignPattern.Repository.DataAccess.Abstract;
using DesignPattern.Repository.DataAccess.Concrete;
using DesignPattern.Repository.DataAccess.Repositories;
using DesignPattern.Repository.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Repository.DataAccess.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(Context context) : base(context)
        {
            
        }
    }
}
