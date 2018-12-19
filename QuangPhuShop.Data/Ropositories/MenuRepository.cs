﻿using QuangPhuShop.Data.Infrastructure;
using QuangPhuShop.Model.Models;

namespace QuangPhuShop.Data.Repositories
{
    public interface IMenuRepository : IRepository<Menu>
    {
    }

    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}