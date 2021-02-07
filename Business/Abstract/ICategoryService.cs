using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();

        List<Category> GetById(int Id);

        Category GetId(int categoryId);
    }
}
