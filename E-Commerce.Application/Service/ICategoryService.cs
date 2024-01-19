using E_Commerce.DTOS.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Service
{
    public interface ICategoryService
    {
        public IQueryable<CategoryDTO> GetAllPagination(int page, int pageSize);
        public CategoryDTO GetCategory(int id);
        public void AddCategory(CategoryDTO categoryDTO);
        public void UpdateCategory(CategoryDTO categoryDTO);
        public void RemoveCategory(CategoryDTO categoryDTO);
    }
}
