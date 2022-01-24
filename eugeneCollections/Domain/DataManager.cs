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
        public ITagRepository Tags { get; set; }
        public IThemeRepository Themes { get; set; }
        public IUserRepository Users { get; set; }
        public ILikeRepository Likes { get; set; }
        public DataManager(ICollectionRepository collection,ICommentRepository comment,ITagRepository tag,IThemeRepository theme,IUserRepository user,ILikeRepository like)
        {
            Collections = collection;
            Comments = comment;
            Tags = tag;
            Themes = theme;
            Users = user;
            Likes = like;
        }
    }
}
