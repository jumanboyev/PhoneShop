﻿
using Microsoft.AspNetCore.Http;

namespace PhoneShop.Service.Dtos.Categories;

public class CategoryCreateDto
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public IFormFile Image { get; set; } = default!;

}
