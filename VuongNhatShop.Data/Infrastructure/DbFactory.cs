using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuongNhatShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private VuongNhatShopDbContext dbContext;

        public VuongNhatShopDbContext Init()
        {
            return dbContext ?? (dbContext = new VuongNhatShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
