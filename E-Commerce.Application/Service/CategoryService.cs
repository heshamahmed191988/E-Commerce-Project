using AutoMapper;
using E_Commerce.Application.Contract;
using E_Commerce.Application.Mapping;
using E_Commerce.DTOS.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Service
{
    public class CategoryService:ICategoryService
    {
        ICategoryRepository _categoryRepository;
        IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public void AddCategory(CategoryDTO categoryDTO)
        {
            _categoryRepository.Add(AutoMapping.MapCategory(categoryDTO));
            _categoryRepository.save();
        }

        public IQueryable<CategoryDTO> GetAll()
        {
            var c = _categoryRepository.GetAll();

            return c.Select(i => AutoMapping.MapCategoryDTO(i));
        }

        public CategoryDTO GetCategory(int id)
        {
            if (id != 0)
            {
                var c = AutoMapping.MapCategoryDTO(_categoryRepository.GetByID(id));
                return c;
            }
            else
                return null;
        }

        public void RemoveCategory(CategoryDTO categoryDTO)
        {
            _categoryRepository.Delete(AutoMapping.MapCategory(categoryDTO));
            _categoryRepository.save();
        }

        public void UpdateCategory(CategoryDTO categoryDTO)
        {
            _categoryRepository.Update(AutoMapping.MapCategory(categoryDTO));
            _categoryRepository.save();
        }
    }
}
