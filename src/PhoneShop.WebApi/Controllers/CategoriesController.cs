using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneShop.DataAccess.Interfaces.Categories;
using PhoneShop.DataAccess.Repasitories.Categories;
using PhoneShop.Domain.Entities.Category;
using PhoneShop.Service.Commons.Helpers;
using PhoneShop.Service.Dtos.Categories;
using PhoneShop.Service.Interfaces.Categories;

namespace PhoneShop.WebApi.Controllers;

[Route("api/categories")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private ICategoryService _service;

    public CategoriesController(ICategoryService service)
    {
        this._service=service;
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromForm] CategoryCreateDto dto)
        =>Ok(await _service.CreateAsync(dto));

    [HttpDelete]

    public async Task<IActionResult> DeleteAsync(int id)
        =>Ok(await _service.DeleteAsync(id));
}
