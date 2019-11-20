using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TestExample.Models;
using TestExample.MyModels;
using TestExample.Services;
using TestExample.ViewModels;

namespace TestExample.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ITestChecked _testChecked;
        private readonly ExamDbContect _examDBContect;
        private readonly IConfiguration _configuration;

        public HomeController(ITestChecked testChecked, 
                              ExamDbContect examDBContect,
                              IConfiguration configuration)
        {
            _testChecked = testChecked;
            _examDBContect = examDBContect;
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Test(int testId)
        {
            EmptyTextViewModel emptyTextViewModel = _examDBContect.DbEmptyTextViewModel
                .FirstOrDefault(p => p.Id == testId);
            //ViewBags Start

            ViewBag.NumberTicket = emptyTextViewModel.Id;
            ViewBag.Region = emptyTextViewModel.Region;
            ViewBag.Community = emptyTextViewModel.Community;
            ViewBag.CEC = emptyTextViewModel.CEC;
            ViewBag.TEC = emptyTextViewModel.TEC;
            ViewBag.Participants = emptyTextViewModel.Participants;
            ViewBag.AllAdditionallyDuringElDay = emptyTextViewModel.AllAdditionallyDuringElDay;
            ViewBag.AllMobileVoters = emptyTextViewModel.AllMobileVoters;
            ViewBag.PartMobileVoters = emptyTextViewModel.PartMobileVoters;
            ViewBag.VadTickets = emptyTextViewModel.VadTickets;
            ViewBag.NumerableTickets = emptyTextViewModel.NumerableTickets;
            ViewBag.UnusedNumerableTickets = emptyTextViewModel.UnusedNumerableTickets;
            ViewBag.UnusedGlueTickets = emptyTextViewModel.UnusedGlueTickets;
            ViewBag.InvalidTickets = emptyTextViewModel.InvalidTickets;
            ViewBag.ForA = emptyTextViewModel.ForA;
            ViewBag.ForB = emptyTextViewModel.ForB;
            ViewBag.ForC = emptyTextViewModel.ForC;
            ViewBag.ForAx = emptyTextViewModel.ForAx;
            ViewBag.ForAy = emptyTextViewModel.ForAy;
            ViewBag.ForBm = emptyTextViewModel.ForBm;
            ViewBag.ForBn = emptyTextViewModel.ForBn;
            ViewBag.ForCk = emptyTextViewModel.ForCk;
            ViewBag.ForCl = emptyTextViewModel.ForCl;
            ViewBag.ListAll = emptyTextViewModel.ListAll;
            ViewBag.TecGlueTickets = emptyTextViewModel.TecGlueTickets;
            ViewBag.TecNumerableTickets = emptyTextViewModel.TecNumerableTickets;

            //ViewBags end

            return View("TestInput");
        }

        [HttpGet]
        public IActionResult Random()
        {
            return View();
        }

        public IActionResult RandomT()
        {
            Random random = new Random();
            int rundomNumber = random.Next(1, 8);
            EmptyTextViewModel emptyTextViewModel = _examDBContect.DbEmptyTextViewModel
                 .FirstOrDefault(p => p.Id == rundomNumber);
            //ViewBags Start

            ViewBag.NumberTicket = emptyTextViewModel.Id;
            ViewBag.Region = emptyTextViewModel.Region;
            ViewBag.Community = emptyTextViewModel.Community;
            ViewBag.CEC = emptyTextViewModel.CEC;
            ViewBag.TEC = emptyTextViewModel.TEC;
            ViewBag.Participants = emptyTextViewModel.Participants;
            ViewBag.AllAdditionallyDuringElDay = emptyTextViewModel.AllAdditionallyDuringElDay;
            ViewBag.AllMobileVoters = emptyTextViewModel.AllMobileVoters;
            ViewBag.PartMobileVoters = emptyTextViewModel.PartMobileVoters;
            ViewBag.VadTickets = emptyTextViewModel.VadTickets;
            ViewBag.NumerableTickets = emptyTextViewModel.NumerableTickets;
            ViewBag.UnusedNumerableTickets = emptyTextViewModel.UnusedNumerableTickets;
            ViewBag.UnusedGlueTickets = emptyTextViewModel.UnusedGlueTickets;
            ViewBag.InvalidTickets = emptyTextViewModel.InvalidTickets;
            ViewBag.ForA = emptyTextViewModel.ForA;
            ViewBag.ForB = emptyTextViewModel.ForB;
            ViewBag.ForC = emptyTextViewModel.ForC;
            ViewBag.ForAx = emptyTextViewModel.ForAx;
            ViewBag.ForAy = emptyTextViewModel.ForAy;
            ViewBag.ForBm = emptyTextViewModel.ForBm;
            ViewBag.ForBn = emptyTextViewModel.ForBn;
            ViewBag.ForCk = emptyTextViewModel.ForCk;
            ViewBag.ForCl = emptyTextViewModel.ForCl;
            ViewBag.ListAll = emptyTextViewModel.ListAll;
            ViewBag.TecGlueTickets = emptyTextViewModel.TecGlueTickets;
            ViewBag.TecNumerableTickets = emptyTextViewModel.TecNumerableTickets;

            //ViewBags end

            return View("TestInput");
        }

        [HttpGet]
        public IActionResult Questions()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Email(int id)
        {
          
            if (id!=0)
            {
                CitizenReport citizenReport = _examDBContect.DbCitizenReport.FirstOrDefault(p => p.Id == id);

                var SmtpServer = _configuration["EmailConfiguration:SmtpServer"];
                var SmtpPort = Convert.ToInt32(_configuration["EmailConfiguration:SmtpPort"]);
                var SmtpUsername = _configuration["EmailConfiguration:SmtpUsername"];
                var SmtpPassword = _configuration["EmailConfiguration:SmtpPassword"];

                var text = "Քաղաքացի " + citizenReport.LastName + " " + citizenReport.FirstName + " Դուք " +
                    citizenReport.TestDataTime +"-ին"
                    + " , մասնակցել էք Գարոի կազմակերպած դասընթացին  և ստացել եք " + citizenReport.Result + " միավոր:";

                MailSender.Sender(SmtpServer, SmtpPort, SmtpUsername, SmtpPassword, citizenReport.Email, text);

                citizenReport.Notification = "Ծանուցվել է";
                _examDBContect.Update(citizenReport);
                _examDBContect.SaveChanges();


            }
            
               

                List<CitizenReport> citizenReportList = _examDBContect.DbCitizenReport.ToList();

                return View(citizenReportList);

        }

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
