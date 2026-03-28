using DesignPattern.Repository.Business.Abstract;
using DesignPattern.Repository.DataAccess.Abstract;
using DesignPattern.Repository.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Repository.Business.Concrete
{
    
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TDelete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public List<Category> TGetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void TInsert(Category entity)
        {
            /* BURADA İŞ KURALLARIMIZI YAZABİLİRİZ. ÖRNEĞİN:
             * İş kuralı: Fiyat 0'dan büyük olmalı
            if (entity.Price <= 0)
                throw new Exception("Ürün fiyatı 0'dan büyük olmalıdır.");
            */
            _categoryDal.Insert(entity);
        }

        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
