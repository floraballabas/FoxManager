using FoxManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Repositories
{
    public class UserRepository
    {
        FoxManagerContext FoxManagerContext;

        public UserRepository(FoxManagerContext foxManagerContext)
        {
            FoxManagerContext = foxManagerContext;
        }
    }
}
