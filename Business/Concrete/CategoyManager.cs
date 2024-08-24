using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoyManager : ICategoryService
    {
        ICategoryDal _categoyDal;

        public CategoyManager(ICategoryDal categoyDal)
        {
            _categoyDal = categoyDal;
        }

        public List<Category> GetAll()
        {
            //İş kodları
            return _categoyDal.GetAll();
        }
        //Select * from Categories where CategoryId = 3

        public Category GetById(int categoryId)
        {
            return _categoyDal.Get(c=>c.CategoryId == categoryId);
        }
    }
}
