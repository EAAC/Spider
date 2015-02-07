using Spider.Data.Orm;
using Spider.Data.Orm.Configuration;
using Spider.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spider.Service
{
    public class UserService : ServiceBase<User>
    {
        public UserService(SpiderEntities dbContext)
            : base(dbContext)
        {

        }

        public OperationResult GreetUser(User model)
        {
            return null;//TODO
        }

        
    }
}
