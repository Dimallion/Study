using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPU_Univer.Data.Models;

namespace TPU_Univer.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
