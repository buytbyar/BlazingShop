﻿using BlazingShop.Shared;
using System.Collections.Generic;

namespace BlazingShop.Client.Services.CategoryService
{
    interface ICategoryService
    {
        List<Category> Categories { get; set; }
        void LoadCategries();
    }
}
