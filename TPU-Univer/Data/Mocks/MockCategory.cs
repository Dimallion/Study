using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPU_Univer.Data.Interfaces;
using TPU_Univer.Data.Models;

namespace TPU_Univer.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category
                    {
                        categoryName = "электромобили", desc = "современные электрические автомобили"
                    },
                    new Category
                    {
                        categoryName = "классические автомобили", desc = "с двигателем внутреннего сгорания"
                    }
                };
            }
        }
    }
}
