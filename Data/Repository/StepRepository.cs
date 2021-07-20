using Recipe_Api.Arrays;
using Recipe_Api.Data.Entities;
using Recipe_Api.Data.Interfaces;
using System.Linq;

namespace Recipe_Api.Data.Repository
{
    public class StepRepository : IRecipeStep
    {
        private AppDbContext _context;
        //private IUnitOfWork _unitOfWork;
        public StepRepository(AppDbContext context/*, IUnitOfWork unitOfWork*/)
        {
            _context = context;
            //_unitOfWork = unitOfWork;

        }
        public StepArray[] AllSteps()
        {
            return _context.Set<Step>().ToList()
                .ConvertAll(x => new StepArray { StepId = x.StepId, StepDescription = x.StepDescription })
                .ToArray();
        }
    }
}
