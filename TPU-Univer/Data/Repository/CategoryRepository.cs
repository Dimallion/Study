﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPU_Univer.Data.Interfaces;
using TPU_Univer.Data.Models;

namespace TPU_Univer.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppContext appDBContent;
        public CategoryRepository(AppContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
