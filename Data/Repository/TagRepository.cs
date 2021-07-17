using Recipe_Api.Data.Entities;
using Recipe_Api.Data.Interfaces;
using System.Collections.Generic;


namespace Recipe_Api.Data.Repository
{
    public class TagRepository : ITag
    {
        private readonly AppDbContent appDbContent;
        public TagRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public IEnumerable<Tag> AllTags => appDbContent.Tag;
    }
}
