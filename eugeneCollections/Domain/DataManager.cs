using eugeneCollections.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Domain
{
    public class DataManager
    {
        public ICollectionRepository Collections { get; set; }
        public ICommentRepository Comments { get; set; }
        public IItemRepository Items { get; set; }
        public ITagRepository Tags { get; set; }
        public IThemeRepository Themes { get; set; }
        public IUserRepository Users { get; set; }
        public DataManager(ICollectionRepository collection,ICommentRepository comment,IItemRepository item,ITagRepository tag,IThemeRepository theme,IUserRepository user)
        {
            Collections = collection;
            Comments = comment;
            Items = item;
            Tags = tag;
            Themes = theme;
            Users = user;
        }
    }
}
