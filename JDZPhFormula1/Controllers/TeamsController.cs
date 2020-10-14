using JDZPhFormula1.Repository;
using JDZPhFormula1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JDZPhFormula1.Controllers
{
    public class TeamsController : Controller
    {
        private readonly ITeamService _teamService;

        public TeamsController()
        {
            _teamService = new TeamRepository();
        }

        public TeamsController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        // GET: Teams
        public ActionResult Index()
        {
            var teams = _teamService.GetTeams();
            return View(teams);
        }

        [Route("teams/{name}")]
        public ActionResult GetTeamByName(string name)
        {
            var team = _teamService.GetTeamByName(name);

            return View(team);
        }
    }
}