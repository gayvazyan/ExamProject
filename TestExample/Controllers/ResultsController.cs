using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TestExample.Models;
using TestExample.MyModels;
using TestExample.Services;
using TestExample.ViewModels;
using MailKit.Net.Smtp;
using MimeKit;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestExample.Controllers
{
    public class ResultsController : Controller
    {
        private readonly ITestChecked _testChecked;
        private readonly ExamDbContect _examDBContect;
        private readonly UserManager<CitizenUser> _userManager;
        private readonly SignInManager<CitizenUser> _signInManager;
       

        public ResultsController(ITestChecked testChecked,
                                 ExamDbContect examDBContect,
                                 UserManager<CitizenUser> userManager,
                                 SignInManager<CitizenUser> signInManager)
        {
            _testChecked = testChecked;
            _examDBContect = examDBContect;
            _userManager = userManager;
            _signInManager = signInManager;
           

        }


        [HttpGet]
        public IActionResult Test()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Test(CitizenTestResults citizenTestResults, int testTicket)
        {
          //  if (ModelState.IsValid)
         //   {
                citizenTestResults.NumberTicket = testTicket;
                _examDBContect.Add(citizenTestResults);
                _examDBContect.SaveChanges();

         //   }

            EmptyTextViewModel emptyTextViewModel = _examDBContect.DbEmptyTextViewModel
                                                        .FirstOrDefault(p => p.Id == testTicket);
            CitizenTestViewModel citizenTestViewModel = _testChecked.TestResult(citizenTestResults, emptyTextViewModel);
            citizenTestResults.Result = citizenTestViewModel.Result;

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

            CitizenUser citizenUser = new CitizenUser();

            if (User.Identity.IsAuthenticated)
            {
                var userName = User.Identity.Name;
                citizenUser = _userManager.Users.FirstOrDefault(p => p.Email == userName);

                ViewBag.UserFullName = citizenUser.FirstName + " " +
                                   citizenUser.SecondName + " " +
                                    citizenUser.LastName;
                
            }

            CitizenReport citizenReport = _examDBContect.DbCitizenReport
                                    .FirstOrDefault(p => p.Passport == citizenUser.Passport);

            citizenReport.Test1DataTime = DateTime.Now;
            citizenReport.Test1Check = true;
            citizenReport.Result_Test1 = citizenTestViewModel.Result;
            citizenReport.NumberTicket = citizenTestViewModel.NumberTicket;
              
                
                
        
            _examDBContect.Update(citizenReport);
            _examDBContect.SaveChanges();

            TempQuestions tempQuestions = new TempQuestions();
            tempQuestions = _examDBContect.DbTempQuestions.FirstOrDefault(p => p.Passport == citizenUser.Passport);
            tempQuestions.TestEnd = true;
            _examDBContect.DbTempQuestions.Update(tempQuestions);
            _examDBContect.SaveChanges();

            return View(citizenTestViewModel);
        }


    }
}
