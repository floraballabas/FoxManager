using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxManager.Services;

namespace FoxManager.Controllers
{
    [Route("")]
    public class TeamController : Controller
    {
        private TeamService TeamService;

        public TeamController(TeamService teamService)
        {
            TeamService = teamService;
        }


        [Route("/team")]
        [HttpGet]
        public IActionResult Team()
        {
            var teams = TeamService.GetDivisionTeams();
            return View();
        }
    }
}
