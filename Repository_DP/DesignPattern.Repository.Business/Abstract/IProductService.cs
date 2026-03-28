using DesignPattern.Repository.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Repository.Business.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
    }
}
