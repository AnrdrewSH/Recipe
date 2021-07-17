using Recipe_Api.Data.Entities;
using Recipe_Api.Data.Interfaces;
using System.Collections.Generic;

//Данный мок нужен был мне для того, чтобы заменить собою базу данных, я её уже подключил, так что следующих моков не последует, а этот я оставлю для того, чтобы лучше запомнить это всё
namespace Recipe_Api.Data.Mocks
{
    public class MockRecipeStep : IRecipeStep
    {
        public IEnumerable<Step> AllSteps
        {
            get
            {
                return new List<Step>
                {
                    new Step { StepDescription = "Выпекаем коржи" },
                    new Step { StepDescription = "Делаем крем" },
                    new Step { StepDescription = "Намазываем крем на коржи" }
                };
            }
        }
    }
}
