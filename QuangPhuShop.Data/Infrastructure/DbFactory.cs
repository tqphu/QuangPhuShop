namespace QuangPhuShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private QuangPhuShopDbContext dbContext;

        public QuangPhuShopDbContext Init()
        {
            return dbContext ?? (dbContext = new QuangPhuShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}