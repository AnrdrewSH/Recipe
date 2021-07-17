using Recipe_Api.Data.Entities;
using System.Collections.Generic;


namespace Recipe_Api.Data.Interfaces
{
    public interface IRecipeStep
    {
        IEnumerable<Step> AllSteps { get; }
    }
}
