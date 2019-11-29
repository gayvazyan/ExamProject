using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<CitizenUser> _userManager;
        private readonly SignInManager<CitizenUser> _signInManager;

        public HomeController(ITestChecked testChecked,
                              ExamDbContect examDBContect,
                              IConfiguration configuration,
                              UserManager<CitizenUser> userManager,
                              SignInManager<CitizenUser> signInManager)
        {
            _testChecked = testChecked;
            _examDBContect = examDBContect;
            _configuration = configuration;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            CitizenUser citizenUser = new CitizenUser();
            if (User.Identity.IsAuthenticated)
            {
                var userName = User.Identity.Name;
                citizenUser = _userManager.Users.FirstOrDefault(p => p.Email == userName);
            }

            CitizenReport citizenReport = _examDBContect.DbCitizenReport.FirstOrDefault(p => p.Passport == citizenUser.Passport);
            TempQuestions tempQuestions = new TempQuestions();
            tempQuestions = _examDBContect.DbTempQuestions.FirstOrDefault(p => p.Passport == citizenUser.Passport);
            if (tempQuestions != null)
            {
                tempQuestions.CurrentAttempt = 31;
                _examDBContect.DbTempQuestions.Update(tempQuestions);
                _examDBContect.SaveChanges();
            }

            return View();
        }

        [HttpGet]
        public IActionResult TestQ()
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
            CitizenUser citizenUser = new CitizenUser();
            if (User.Identity.IsAuthenticated)
            {
                var userName = User.Identity.Name;
                citizenUser = _userManager.Users.FirstOrDefault(p => p.Email == userName);
            }

            CitizenReport citizenReport = _examDBContect.DbCitizenReport.FirstOrDefault(p => p.Passport == citizenUser.Passport);

            var startDate = citizenReport.StartDate;
            ViewBag.TiemExasise = startDate;


            Random random = new Random();
            int rundomNumber = random.Next(1, 8);
            EmptyTextViewModel emptyTextViewModel = _examDBContect.DbEmptyTextViewModel
                 .FirstOrDefault(p => p.Id == rundomNumber);
           
            //ViewBags Start
            #region ViewBags Start
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
            #endregion
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

            if (id != 0)
            {
                CitizenReport citizenReport = _examDBContect.DbCitizenReport.FirstOrDefault(p => p.Id == id);

                var SmtpServer = _configuration["EmailConfiguration:SmtpServer"];
                var SmtpPort = Convert.ToInt32(_configuration["EmailConfiguration:SmtpPort"]);
                var SmtpUsername = _configuration["EmailConfiguration:SmtpUsername"];
                var SmtpPassword = _configuration["EmailConfiguration:SmtpPassword"];
                var testSumResult = citizenReport.Result_Test1 + citizenReport.Result_Test2;
                var Time1 = (citizenReport.Test1DataTime).ToString("dd/MM/yyyy HH:mm");
                var Time2 = (citizenReport.Test2DataTime).ToString("dd/MM/yyyy HH:mm");
                var subject = "Հարգելի " + citizenReport.LastName + " " + citizenReport.FirstName;

                var text = " Դուք  , մասնակցել էք Ընտրությունների անցկացման մասնագիտական դասընթացներ ստուգարքին համակարգչային եղանակով և ստացել եք " + testSumResult + " միավոր: "
                 + " Խնդիրը հանձնել եք " + Time1 + "-ին, և ստացել եք " + citizenReport.Result_Test1 + " միավոր "
                  + " Հարցաշարը հանձնել եք " + Time2 + "-ին, և ստացել եք " + citizenReport.Result_Test2 + " միավոր: "
                  + " Դասընթացների մասին լրացուցիչ ինֆորմացիա կարող եք ստանալ այցելելով https://www.elections.am կայք  Մասնագիտական դասընտացներ բաժին:  ";


                MailSender.Sender(SmtpServer, SmtpPort, SmtpUsername, SmtpPassword, citizenReport.Email, subject, text);

                citizenReport.Notification = true;
                citizenReport.NotificationData = DateTime.Now;
                _examDBContect.Update(citizenReport);
                _examDBContect.SaveChanges();


            }

            List<CitizenReport> citizenReportList = _examDBContect.DbCitizenReport.ToList();

            return View(citizenReportList);

        }

        [HttpGet]
        public IActionResult MyEmail(int id)
        {


            CitizenReport citizenReport = _examDBContect.DbCitizenReport.FirstOrDefault(p => p.Id == id);

            var SmtpServer = _configuration["EmailConfiguration:SmtpServer"];
            var SmtpPort = Convert.ToInt32(_configuration["EmailConfiguration:SmtpPort"]);
            var SmtpUsername = _configuration["EmailConfiguration:SmtpUsername"];
            var SmtpPassword = _configuration["EmailConfiguration:SmtpPassword"];
            var testSumResult = citizenReport.Result_Test1 + citizenReport.Result_Test2;
            var Time1 = (citizenReport.Test1DataTime).ToString("dd/MM/yyyy HH:mm");
            var Time2 = (citizenReport.Test2DataTime).ToString("dd/MM/yyyy HH:mm");
            var subject = "Հարգելի " + citizenReport.LastName + " " + citizenReport.FirstName;

            var text = " Դուք  , մասնակցել էք Ընտրությունների անցկացման մասնագիտական դասընթացներ ստուգարքին համակարգչային եղանակով և ստացել եք " + testSumResult + " միավոր: "
               + " Խնդիրը հանձնել եք " + Time1 + "-ին, և ստացել եք " + citizenReport.Result_Test1 + " միավոր "
                + " Հարցաշարը հանձնել եք " + Time2 + "-ին, և ստացել եք " + citizenReport.Result_Test2 + " միավոր: "
                + " Դասընթացների մասին լրացուցիչ ինֆորմացիա կարող եք ստանալ այցելելով https://www.elections.am կայք Մասնագիտական դասընտացներ բաժին:  ";

            MailSender.Sender(SmtpServer, SmtpPort, SmtpUsername, SmtpPassword, citizenReport.Email, subject, text);

            citizenReport.Notification = true;
            citizenReport.NotificationData = DateTime.Now;
            _examDBContect.Update(citizenReport);
            _examDBContect.SaveChanges();
            return View("Result", citizenReport);

        }

        [HttpGet]
        public IActionResult Result()
        {
            CitizenUser citizenUser = new CitizenUser();
            if (User.Identity.IsAuthenticated)
            {
                var userName = User.Identity.Name;
                citizenUser = _userManager.Users.FirstOrDefault(p => p.Email == userName);

            }
            CitizenReport citizenReport = _examDBContect.DbCitizenReport.FirstOrDefault(p => p.Passport == citizenUser.Passport);


            return View(citizenReport);
        }

        [HttpGet]
        public IActionResult StartDate()
        {
            CitizenUser citizenUser = new CitizenUser();
            if (User.Identity.IsAuthenticated)
            {
                var userName = User.Identity.Name;
                citizenUser = _userManager.Users.FirstOrDefault(p => p.Email == userName);

            }
            CitizenReport citizenReport = _examDBContect.DbCitizenReport.FirstOrDefault(p => p.Passport == citizenUser.Passport);

           // citizenReport.StartDate= DateTime.UtcNow.AddSeconds(2400);
            citizenReport.StartDate= DateTime.UtcNow.AddSeconds(95);
            _examDBContect.DbCitizenReport.Update(citizenReport);
            _examDBContect.SaveChanges();

            return RedirectToAction("Random", "Questions");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
