using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeApi.Dbinfrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
