 using QuangPhuShop.Data.Infrastructure;
using QuangPhuShop.Model.Models;

namespace QuangPhuShop.Data.Repositories
{
    public interface ITagRepository : IRepository<Tag>
    {
    }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}