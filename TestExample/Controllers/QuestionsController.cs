using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TestExample.Models;
using TestExample.MyModels;
using TestExample.QAmodels;

namespace TestExample.Controllers
{
    [Authorize]
    public class QuestionsController : Controller
    {
        private readonly ExamDbContect _examDBContect;
        private readonly UserManager<CitizenUser> _userManager;
        private readonly SignInManager<CitizenUser> _signInManager;

        public QuestionsController(ExamDbContect examDBContect,
                                    UserManager<CitizenUser> userManager,
                                   SignInManager<CitizenUser> signInManager)
        {
            _examDBContect = examDBContect;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test1()
        {


            ViewBag.Questions = _examDBContect.DbQuestion1.ToList();

            List<Answer1> answersList = _examDBContect.DbAnswer1.ToList();

            foreach (var answer in answersList)
            {
                answer.CheckdAnswer = false;
                answer.CheckCorrectAnswer = false;
                _examDBContect.DbAnswer1.Update(answer);
                _examDBContect.SaveChanges();
            }

            return View(answersList);
        }

        public IActionResult Test2()
        {


            ViewBag.Questions = _examDBContect.DbQuestion2.ToList();

            List<Answer2> answersList = _examDBContect.DbAnswer2.ToList();

            foreach (var answer in answersList)
            {
                answer.CheckdAnswer = false;
                answer.CheckCorrectAnswer = false;
                _examDBContect.DbAnswer2.Update(answer);
                _examDBContect.SaveChanges();
            }

            return View(answersList);
        }

        public IActionResult Test3()
        {


            ViewBag.Questions = _examDBContect.DbQuestion3.ToList();

            List<Answer3> answersList = _examDBContect.DbAnswer3.ToList();

            foreach (var answer in answersList)
            {
                answer.CheckdAnswer = false;
                answer.CheckCorrectAnswer = false;
                _examDBContect.DbAnswer3.Update(answer);
                _examDBContect.SaveChanges();
            }

            return View(answersList);
        }

        public IActionResult Test4()
        {


            ViewBag.Questions = _examDBContect.DbQuestion4.ToList();

            List<Answer4> answersList = _examDBContect.DbAnswer4.ToList();

            foreach (var answer in answersList)
            {
                answer.CheckdAnswer = false;
                answer.CheckCorrectAnswer = false;
                _examDBContect.DbAnswer4.Update(answer);
                _examDBContect.SaveChanges();
            }

            return View(answersList);
        }

        public IActionResult Test5()
        {


            ViewBag.Questions = _examDBContect.DbQuestion5.ToList();

            List<Answer5> answersList = _examDBContect.DbAnswer5.ToList();

            foreach (var answer in answersList)
            {
                answer.CheckdAnswer = false;
                answer.CheckCorrectAnswer = false;
                _examDBContect.DbAnswer5.Update(answer);
                _examDBContect.SaveChanges();
            }

            return View(answersList);
        }

        public IActionResult Test6()
        {


            ViewBag.Questions = _examDBContect.DbQuestion6.ToList();

            List<Answer6> answersList = _examDBContect.DbAnswer6.ToList();

            foreach (var answer in answersList)
            {
                answer.CheckdAnswer = false;
                answer.CheckCorrectAnswer = false;
                _examDBContect.DbAnswer6.Update(answer);
                _examDBContect.SaveChanges();
            }

            return View(answersList);
        }

        public IActionResult Test7()
        {


            ViewBag.Questions = _examDBContect.DbQuestion7.ToList();

            List<Answer7> answersList = _examDBContect.DbAnswer7.ToList();

            foreach (var answer in answersList)
            {
                answer.CheckdAnswer = false;
                answer.CheckCorrectAnswer = false;
                _examDBContect.DbAnswer7.Update(answer);
                _examDBContect.SaveChanges();
            }

            return View(answersList);
        }

        [HttpPost]
        public IActionResult Submit1(IFormCollection ifromCollection)
        {
            int score = 0;
            string[] questionIds = ifromCollection["questionId"];
            foreach (var questionId in questionIds)
            {

         // null-i problemy
                string  checkedValueString = ifromCollection["question_" + questionId];

                int checkedValueInt = Convert.ToInt32(checkedValueString);
                if (checkedValueInt != 0)
                {
                    Answer1 answer = _examDBContect.DbAnswer1.FirstOrDefault(p => p.Id == checkedValueInt);
                    answer.CheckdAnswer = true;

                    if (answer.CorrectAnswer == true)
                    {
                        score++;
                        answer.CheckCorrectAnswer = true;
                        _examDBContect.DbAnswer1.Update(answer);
                        _examDBContect.SaveChanges();
                    }
                }
               
                
            }
           

            CitizenUser citizenUser = new CitizenUser();
            if (User.Identity.IsAuthenticated)
            {
                var userName = User.Identity.Name;
                citizenUser = _userManager.Users.FirstOrDefault(p => p.Email == userName);

                ViewBag.UserFullName = citizenUser.FirstName + " " +
                                   citizenUser.SecondName + " " +
                                    citizenUser.LastName;

            }
            CitizenReport citizenReport = _examDBContect.DbCitizenReport.FirstOrDefault(p => p.Passport == citizenUser.Passport);
            citizenReport.Result_Test2 = score;
            citizenReport.Test2DataTime = DateTime.Now;
            citizenReport.Test2Check = true;
            _examDBContect.DbCitizenReport.Update(citizenReport);
            _examDBContect.SaveChanges();
            ViewBag.Result_Test2 = score;
            ViewBag.Questions = _examDBContect.DbQuestion1.ToList();

            List<Answer1> answersList = _examDBContect.DbAnswer1.ToList();

            return View("Result1",answersList);

            
        }

        [HttpPost]
        public IActionResult Submit2(IFormCollection ifromCollection)
        {
            int score = 0;
            string[] questionIds = ifromCollection["questionId"];
            foreach (var questionId in questionIds)
            {

                // null-i problemy
                string checkedValueString = ifromCollection["question_" + questionId];

                int checkedValueInt = Convert.ToInt32(checkedValueString);
                if (checkedValueInt != 0)
                {
                    Answer2 answer = _examDBContect.DbAnswer2.FirstOrDefault(p => p.Id == checkedValueInt);
                    answer.CheckdAnswer = true;

                    if (answer.CorrectAnswer == true)
                    {
                        score++;
                        answer.CheckCorrectAnswer = true;
                        _examDBContect.DbAnswer2.Update(answer);
                        _examDBContect.SaveChanges();
                    }
                }


            }


            CitizenUser citizenUser = new CitizenUser();
            if (User.Identity.IsAuthenticated)
            {
                var userName = User.Identity.Name;
                citizenUser = _userManager.Users.FirstOrDefault(p => p.Email == userName);

                ViewBag.UserFullName = citizenUser.FirstName + " " +
                                   citizenUser.SecondName + " " +
                                    citizenUser.LastName;

            }
            CitizenReport citizenReport = _examDBContect.DbCitizenReport.FirstOrDefault(p => p.Passport == citizenUser.Passport);
            citizenReport.Result_Test2 = score;
            citizenReport.Test2DataTime = DateTime.Now;
            citizenReport.Test2Check = true;
            _examDBContect.DbCitizenReport.Update(citizenReport);
            _examDBContect.SaveChanges();
            ViewBag.Result_Test2 = score;
            ViewBag.Questions = _examDBContect.DbQuestion1.ToList();

            List<Answer2> answersList = _examDBContect.DbAnswer2.ToList();

            return View("Result2", answersList);


        }

        [HttpPost]
        public IActionResult Submit3(IFormCollection ifromCollection)

        {
            int score = 0;
            string[] questionIds = ifromCollection["questionId"];
            foreach (var questionId in questionIds)
            {

                // null-i problemy
                string checkedValueString = ifromCollection["question_" + questionId];

                int checkedValueInt = Convert.ToInt32(checkedValueString);
                if (checkedValueInt != 0)
                {
                    Answer3 answer = _examDBContect.DbAnswer3.FirstOrDefault(p => p.Id == checkedValueInt);
                    answer.CheckdAnswer = true;

                    if (answer.CorrectAnswer == true)
                    {
                        score++;
                        answer.CheckCorrectAnswer = true;
                        _examDBContect.DbAnswer3.Update(answer);
                        _examDBContect.SaveChanges();
                    }
                }


            }


            CitizenUser citizenUser = new CitizenUser();
            if (User.Identity.IsAuthenticated)
            {
                var userName = User.Identity.Name;
                citizenUser = _userManager.Users.FirstOrDefault(p => p.Email == userName);

                ViewBag.UserFullName = citizenUser.FirstName + " " +
                                   citizenUser.SecondName + " " +
                                    citizenUser.LastName;

            }
            CitizenReport citizenReport = _examDBContect.DbCitizenReport.FirstOrDefault(p => p.Passport == citizenUser.Passport);
            citizenReport.Result_Test2 = score;
            citizenReport.Test2DataTime = DateTime.Now;
            citizenReport.Test2Check = true;
            _examDBContect.DbCitizenReport.Update(citizenReport);
            _examDBContect.SaveChanges();
            ViewBag.Result_Test2 = score;
            ViewBag.Questions = _examDBContect.DbQuestion3.ToList();

            List<Answer3> answersList = _examDBContect.DbAnswer3.ToList();

            return View("Result3", answersList);


        }

        [HttpPost]
        public IActionResult Submit4(IFormCollection ifromCollection)

        {
            int score = 0;
            string[] questionIds = ifromCollection["questionId"];
            foreach (var questionId in questionIds)
            {

                // null-i problemy
                string checkedValueString = ifromCollection["question_" + questionId];

                int checkedValueInt = Convert.ToInt32(checkedValueString);
                if (checkedValueInt != 0)
                {
                    Answer4 answer = _examDBContect.DbAnswer4.FirstOrDefault(p => p.Id == checkedValueInt);
                    answer.CheckdAnswer = true;

                    if (answer.CorrectAnswer == true)
                    {
                        score++;
                        answer.CheckCorrectAnswer = true;
                        _examDBContect.DbAnswer4.Update(answer);
                        _examDBContect.SaveChanges();
                    }
                }


            }


            CitizenUser citizenUser = new CitizenUser();
            if (User.Identity.IsAuthenticated)
            {
                var userName = User.Identity.Name;
                citizenUser = _userManager.Users.FirstOrDefault(p => p.Email == userName);

                ViewBag.UserFullName = citizenUser.FirstName + " " +
                                   citizenUser.SecondName + " " +
                                    citizenUser.LastName;

            }
            CitizenReport citizenReport = _examDBContect.DbCitizenReport.FirstOrDefault(p => p.Passport == citizenUser.Passport);
            citizenReport.Result_Test2 = score;
            citizenReport.Test2DataTime = DateTime.Now;
            citizenReport.Test2Check = true;
            _examDBContect.DbCitizenReport.Update(citizenReport);
            _examDBContect.SaveChanges();
            ViewBag.Result_Test2 = score;
            ViewBag.Questions = _examDBContect.DbQuestion3.ToList();

            List<Answer4> answersList = _examDBContect.DbAnswer4.ToList();

            return View("Result4", answersList);


        }

        [HttpPost]
        public IActionResult Submit5(IFormCollection ifromCollection)

        {
            int score = 0;
            string[] questionIds = ifromCollection["questionId"];
            foreach (var questionId in questionIds)
            {

                // null-i problemy
                string checkedValueString = ifromCollection["question_" + questionId];

                int checkedValueInt = Convert.ToInt32(checkedValueString);
                if (checkedValueInt != 0)
                {
                    Answer5 answer = _examDBContect.DbAnswer5.FirstOrDefault(p => p.Id == checkedValueInt);
                    answer.CheckdAnswer = true;

                    if (answer.CorrectAnswer == true)
                    {
                        score++;
                        answer.CheckCorrectAnswer = true;
                        _examDBContect.DbAnswer5.Update(answer);
                        _examDBContect.SaveChanges();
                    }
                }


            }


            CitizenUser citizenUser = new CitizenUser();
            if (User.Identity.IsAuthenticated)
            {
                var userName = User.Identity.Name;
                citizenUser = _userManager.Users.FirstOrDefault(p => p.Email == userName);

                ViewBag.UserFullName = citizenUser.FirstName + " " +
                                   citizenUser.SecondName + " " +
                                    citizenUser.LastName;

            }
            CitizenReport citizenReport = _examDBContect.DbCitizenReport.FirstOrDefault(p => p.Passport == citizenUser.Passport);
            citizenReport.Result_Test2 = score;
            citizenReport.Test2Check = true;
            citizenReport.Test2DataTime = DateTime.Now;
            _examDBContect.DbCitizenReport.Update(citizenReport);
            _examDBContect.SaveChanges();
            ViewBag.Result_Test2 = score;
            ViewBag.Questions = _examDBContect.DbQuestion5.ToList();

            List<Answer5> answersList = _examDBContect.DbAnswer5.ToList();

            return View("Result5", answersList);


        }

        [HttpPost]
        public IActionResult Submit6(IFormCollection ifromCollection)

        {
            int score = 0;
            string[] questionIds = ifromCollection["questionId"];
            foreach (var questionId in questionIds)
            {

                // null-i problemy
                string checkedValueString = ifromCollection["question_" + questionId];

                int checkedValueInt = Convert.ToInt32(checkedValueString);
                if (checkedValueInt != 0)
                {
                    Answer6 answer = _examDBContect.DbAnswer6.FirstOrDefault(p => p.Id == checkedValueInt);
                    answer.CheckdAnswer = true;

                    if (answer.CorrectAnswer == true)
                    {
                        score++;
                        answer.CheckCorrectAnswer = true;
                        _examDBContect.DbAnswer6.Update(answer);
                        _examDBContect.SaveChanges();
                    }
                }


            }


            CitizenUser citizenUser = new CitizenUser();
            if (User.Identity.IsAuthenticated)
            {
                var userName = User.Identity.Name;
                citizenUser = _userManager.Users.FirstOrDefault(p => p.Email == userName);

                ViewBag.UserFullName = citizenUser.FirstName + " " +
                                   citizenUser.SecondName + " " +
                                    citizenUser.LastName;

            }
            CitizenReport citizenReport = _examDBContect.DbCitizenReport.FirstOrDefault(p => p.Passport == citizenUser.Passport);
            citizenReport.Result_Test2 = score;
            citizenReport.Test2Check = true;
            citizenReport.Test2DataTime = DateTime.Now;
            _examDBContect.DbCitizenReport.Update(citizenReport);
            _examDBContect.SaveChanges();
            ViewBag.Result_Test2 = score;
            ViewBag.Questions = _examDBContect.DbQuestion6.ToList();

            List<Answer6> answersList = _examDBContect.DbAnswer6.ToList();

            return View("Result6", answersList);


        }

        [HttpPost]
        public IActionResult Submit7(IFormCollection ifromCollection)

        {
            int score = 0;
            string[] questionIds = ifromCollection["questionId"];
            foreach (var questionId in questionIds)
            {

                // null-i problemy
                string checkedValueString = ifromCollection["question_" + questionId];

                int checkedValueInt = Convert.ToInt32(checkedValueString);
                if (checkedValueInt != 0)
                {
                    Answer7 answer = _examDBContect.DbAnswer7.FirstOrDefault(p => p.Id == checkedValueInt);
                    answer.CheckdAnswer = true;

                    if (answer.CorrectAnswer == true)
                    {
                        score++;
                        answer.CheckCorrectAnswer = true;
                        _examDBContect.DbAnswer7.Update(answer);
                        _examDBContect.SaveChanges();
                    }
                }


            }


            CitizenUser citizenUser = new CitizenUser();
            if (User.Identity.IsAuthenticated)
            {
                var userName = User.Identity.Name;
                citizenUser = _userManager.Users.FirstOrDefault(p => p.Email == userName);

                ViewBag.UserFullName = citizenUser.FirstName + " " +
                                   citizenUser.SecondName + " " +
                                    citizenUser.LastName;

            }
            CitizenReport citizenReport = _examDBContect.DbCitizenReport.FirstOrDefault(p => p.Passport == citizenUser.Passport);
            citizenReport.Result_Test2 = score;
            citizenReport.Test2Check = true;
            citizenReport.Test2DataTime = DateTime.Now;
            _examDBContect.DbCitizenReport.Update(citizenReport);
            _examDBContect.SaveChanges();
            ViewBag.Result_Test2 = score;
            ViewBag.Questions = _examDBContect.DbQuestion7.ToList();

            List<Answer7> answersList = _examDBContect.DbAnswer7.ToList();

            return View("Result7", answersList);


        }

        public IActionResult Random()
        {
            return View();
        }


    }
}