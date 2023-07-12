﻿
namespace PhoneShop.Domain.Entities.Category;

public class Category:Auditable
{
    public string Name { get; set; } = string.Empty;

    public string ImagePath { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

}
