using FoxManager.Models;
using FoxManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Services
{
    public class TeamService
    {
        private TeamRepository TeamRepository;

        public TeamService(TeamRepository teamRepository)
        {
            TeamRepository = teamRepository;
        }

        public List<Team> GetDivisionTeams()
        {
            return TeamRepository.GetDivisionTeamList();
        }
    }
}
