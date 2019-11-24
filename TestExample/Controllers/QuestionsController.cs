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

        public IActionResult Test()
        {
            CitizenUser citizenUser = new CitizenUser();
            if (User.Identity.IsAuthenticated)
            {
                var userName = User.Identity.Name;
                citizenUser = _userManager.Users.FirstOrDefault(p => p.Email == userName);
            }
          

            //  ViewBag.Questions = _examDBContect.DbQuestion1.ToList();
            int countQuestion = _examDBContect.DbQuestion.Count();
             List<Question> questions = new List<Question>();
            List<int> randomList = RandomNumber.GetRandomNumbers(4);

            foreach (var item in randomList)
            {
                var questionsRandom = _examDBContect.DbQuestion.FirstOrDefault(p => p.Id == item);
                questions.Add(questionsRandom);
            }

            
            ViewBag.Questions = questions;
            TempQuestions tempQuestionsRemove = new TempQuestions();
            tempQuestionsRemove = _examDBContect.DbTempQuestions.FirstOrDefault(p => p.Passport == citizenUser.Passport);
            if (tempQuestionsRemove != null)
            {
                _examDBContect.DbTempQuestions.Remove(tempQuestionsRemove);
                _examDBContect.SaveChanges();
            }
            TempQuestions tempQuestions = new TempQuestions();
            tempQuestions.Passport = citizenUser.Passport;
            
                tempQuestions.Id1 = questions[0].Id;
                tempQuestions.Id2 = questions[1].Id;
                tempQuestions.Id3 = questions[2].Id;
                tempQuestions.Id4 = questions[3].Id;
            tempQuestions.Q1= questions[0].QuestionContent;
            tempQuestions.Q2= questions[1].QuestionContent;
            tempQuestions.Q3= questions[2].QuestionContent;
            tempQuestions.Q4= questions[3].QuestionContent;

            _examDBContect.DbTempQuestions.Update(tempQuestions);
            _examDBContect.SaveChanges();

            List<Answer> answersList = _examDBContect.DbAnswer.ToList();

            foreach (var answer in answersList)
            {
                answer.CheckdAnswer = false;
                answer.CheckCorrectAnswer = false;
                _examDBContect.DbAnswer.Update(answer);
                _examDBContect.SaveChanges();
            }

            return View(answersList);
        }

      

        [HttpPost]
        public IActionResult Submit(IFormCollection ifromCollection)
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
                    Answer answer = _examDBContect.DbAnswer.FirstOrDefault(p => p.Id == checkedValueInt);
                    answer.CheckdAnswer = true;

                    if (answer.CorrectAnswer == true)
                    {
                        score++;
                        answer.CheckCorrectAnswer = true;
                        _examDBContect.DbAnswer.Update(answer);
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



            // ViewBag.Questions = TempData["baza"];

            TempQuestions tempQuestions = new TempQuestions();
            tempQuestions = _examDBContect.DbTempQuestions
                      .FirstOrDefault(p => p.Passport == citizenUser.Passport);

            List<Question> questions = new List<Question>();
            Question question1 = new Question();
            Question question2 = new Question();
            Question question3 = new Question();
            Question question4 = new Question();


            question1.Id = tempQuestions.Id1;
            question2.Id = tempQuestions.Id2;
            question3.Id = tempQuestions.Id3;
            question4.Id = tempQuestions.Id4;
            question1.QuestionContent = tempQuestions.Q1;
            question2.QuestionContent = tempQuestions.Q2;
            question3.QuestionContent = tempQuestions.Q3;
            question4.QuestionContent = tempQuestions.Q4;
            questions.Add(question1);
            questions.Add(question2);
            questions.Add(question3);
            questions.Add(question4);

            ViewBag.Questions = questions;
            List<Answer> answersList = _examDBContect.DbAnswer.ToList();

            return View("Result",answersList);

            
        }

       

        public IActionResult Random()
        {
            return View();
        }


    }
}