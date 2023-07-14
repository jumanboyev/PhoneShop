
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using PhoneShop.DataAccess.Interfaces.Categories;
using PhoneShop.Domain.Entities.Category;
using PhoneShop.Domain.Exseptions.Categories;
using PhoneShop.Service.Commons.Helpers;
using PhoneShop.Service.Dtos.Categories;
using PhoneShop.Service.Interfaces.Categories;
using PhoneShop.Service.Interfaces.Common;
using System.IO;

namespace PhoneShop.Service.Services.Categories;

public class CategoryService : ICategoryService
{
    private ICategoryRepository _repository;
    private IFileService _fileService;

    public CategoryService(ICategoryRepository repository,IFileService fileService)
    {
        this._repository = repository;
        this._fileService=fileService;
    }
    public async Task<bool> CreateAsync(CategoryCreateDto dto)
    {
        string imagepath = await _fileService.UploadImageAsync(dto.Image);
        Category category = new Category()
        {
            ImagePath = imagepath,
            Name = dto.Name,
            Description = dto.Description,
            CreateAt = TimeHelpers.GetDateTime(),
            UpdateAt = TimeHelpers.GetDateTime()
        };
        var result=await _repository.CreateAsync(category);
        return result > 0;
    }

   
    public async Task<bool> DeleteAsync(int id)
    {
        var category = await _repository.GetByIdAsync(id);
       // if(category is null) throw new CategoryNotFoundExseptions();

        var result = await _fileService.DeleteImageAsync(category.ImagePath);
        if (result == false) throw new FileNotFoundException();

        var dbresult = await _repository.DeleteAsync(id);
        return dbresult > 0;
    }
}
