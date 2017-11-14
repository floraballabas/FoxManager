using FoxManager.Entities;
using FoxManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Repositories
{
    public class TeamRepository
    {
        FoxManagerContext FoxManagerContext;

        public TeamRepository(FoxManagerContext foxManagerContext)
        {
            FoxManagerContext = foxManagerContext;
        }

        public List<Team> GetDivisionTeamList()
        {
            return FoxManagerContext.Teams.Where(x => x.Division.DivisionId.Equals(1))
                .ToList();
        }
    }
}