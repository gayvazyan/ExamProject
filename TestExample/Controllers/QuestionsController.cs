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


            List<int> randomPart1 = RandomNumber.GetRandomNumbers(10, 1, 36);
            List<int> randomPart2 = RandomNumber.GetRandomNumbers(10, 36,71);
            List<int> randomPart3 = RandomNumber.GetRandomNumbers(10, 71, 104);


            List<int>  joinPart1andPart2 = (randomPart1.Concat(randomPart2)).ToList();

            List<int> joinAllParts = (joinPart1andPart2.Concat(randomPart3)).ToList();

            foreach (var item in joinAllParts)
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
                tempQuestions.Id5 = questions[4].Id;
                tempQuestions.Id6 = questions[5].Id;
                tempQuestions.Id7 = questions[6].Id;
                tempQuestions.Id8 = questions[7].Id;
                tempQuestions.Id9 = questions[8].Id;
                tempQuestions.Id10 = questions[9].Id;
                tempQuestions.Id11 = questions[10].Id;
                tempQuestions.Id12 = questions[11].Id;
                tempQuestions.Id13 = questions[12].Id;
                tempQuestions.Id14 = questions[13].Id;
                tempQuestions.Id15 = questions[14].Id;
                tempQuestions.Id16 = questions[15].Id;
                tempQuestions.Id17 = questions[16].Id;
                tempQuestions.Id18 = questions[17].Id;
                tempQuestions.Id19 = questions[18].Id;
                tempQuestions.Id20 = questions[19].Id;
                tempQuestions.Id21 = questions[20].Id;
                tempQuestions.Id22 = questions[21].Id;
                tempQuestions.Id23 = questions[22].Id;
                tempQuestions.Id24 = questions[23].Id;
                tempQuestions.Id25 = questions[24].Id;
                tempQuestions.Id26 = questions[25].Id;
                tempQuestions.Id27 = questions[26].Id;
                tempQuestions.Id28 = questions[27].Id;
                tempQuestions.Id29 = questions[28].Id;
                tempQuestions.Id30 = questions[29].Id;
            tempQuestions.Q1= questions[0].QuestionContent;
            tempQuestions.Q2= questions[1].QuestionContent;
            tempQuestions.Q3= questions[2].QuestionContent;
            tempQuestions.Q4= questions[3].QuestionContent;
            tempQuestions.Q5= questions[4].QuestionContent;
            tempQuestions.Q6= questions[5].QuestionContent;
            tempQuestions.Q7= questions[6].QuestionContent;
            tempQuestions.Q8= questions[7].QuestionContent;
            tempQuestions.Q9= questions[8].QuestionContent;
            tempQuestions.Q10= questions[9].QuestionContent;
            tempQuestions.Q11= questions[10].QuestionContent;
            tempQuestions.Q12= questions[11].QuestionContent;
            tempQuestions.Q13= questions[12].QuestionContent;
            tempQuestions.Q14= questions[13].QuestionContent;
            tempQuestions.Q15= questions[14].QuestionContent;
            tempQuestions.Q16= questions[15].QuestionContent;
            tempQuestions.Q17= questions[16].QuestionContent;
            tempQuestions.Q18= questions[17].QuestionContent;
            tempQuestions.Q19= questions[18].QuestionContent;
            tempQuestions.Q20= questions[19].QuestionContent;
            tempQuestions.Q21= questions[20].QuestionContent;
            tempQuestions.Q22= questions[21].QuestionContent;
            tempQuestions.Q23= questions[22].QuestionContent;
            tempQuestions.Q24= questions[23].QuestionContent;
            tempQuestions.Q25= questions[24].QuestionContent;
            tempQuestions.Q26= questions[25].QuestionContent;
            tempQuestions.Q27= questions[26].QuestionContent;
            tempQuestions.Q28= questions[27].QuestionContent;
            tempQuestions.Q29= questions[28].QuestionContent;
            tempQuestions.Q30= questions[29].QuestionContent;

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
            Question question5 = new Question();
            Question question6 = new Question();
            Question question7 = new Question();
            Question question8 = new Question();
            Question question9 = new Question();
            Question question10 = new Question();
            Question question11 = new Question();
            Question question12 = new Question();
            Question question13 = new Question();
            Question question14 = new Question();
            Question question15 = new Question();
            Question question16 = new Question();
            Question question17 = new Question();
            Question question18 = new Question();
            Question question19 = new Question();
            Question question20 = new Question();
            Question question21 = new Question();
            Question question22 = new Question();
            Question question23 = new Question();
            Question question24 = new Question();
            Question question25 = new Question();
            Question question26 = new Question();
            Question question27 = new Question();
            Question question28 = new Question();
            Question question29 = new Question();
            Question question30 = new Question();


            question1.Id = tempQuestions.Id1;
            question2.Id = tempQuestions.Id2;
            question3.Id = tempQuestions.Id3;
            question4.Id = tempQuestions.Id4;
            question5.Id = tempQuestions.Id5;
            question6.Id = tempQuestions.Id6;
            question7.Id = tempQuestions.Id7;
            question8.Id = tempQuestions.Id8;
            question9.Id = tempQuestions.Id9;
            question10.Id = tempQuestions.Id10;
            question11.Id = tempQuestions.Id11;
            question12.Id = tempQuestions.Id12;
            question13.Id = tempQuestions.Id13;
            question14.Id = tempQuestions.Id14;
            question15.Id = tempQuestions.Id15;
            question16.Id = tempQuestions.Id16;
            question17.Id = tempQuestions.Id17;
            question18.Id = tempQuestions.Id18;
            question19.Id = tempQuestions.Id19;
            question20.Id = tempQuestions.Id20;
            question21.Id = tempQuestions.Id21;
            question22.Id = tempQuestions.Id22;
            question23.Id = tempQuestions.Id23;
            question24.Id = tempQuestions.Id24;
            question25.Id = tempQuestions.Id25;
            question26.Id = tempQuestions.Id26;
            question27.Id = tempQuestions.Id27;
            question28.Id = tempQuestions.Id28;
            question29.Id = tempQuestions.Id29;
            question30.Id = tempQuestions.Id30;

            question1.QuestionContent = tempQuestions.Q1;
            question2.QuestionContent = tempQuestions.Q2;
            question3.QuestionContent = tempQuestions.Q3;
            question4.QuestionContent = tempQuestions.Q4;
            question5.QuestionContent = tempQuestions.Q5;
            question6.QuestionContent = tempQuestions.Q6;
            question7.QuestionContent = tempQuestions.Q7;
            question8.QuestionContent = tempQuestions.Q8;
            question9.QuestionContent = tempQuestions.Q9;
            question10.QuestionContent = tempQuestions.Q10;
            question11.QuestionContent = tempQuestions.Q11;
            question12.QuestionContent = tempQuestions.Q12;
            question13.QuestionContent = tempQuestions.Q13;
            question14.QuestionContent = tempQuestions.Q14;
            question15.QuestionContent = tempQuestions.Q15;
            question16.QuestionContent = tempQuestions.Q16;
            question17.QuestionContent = tempQuestions.Q17;
            question18.QuestionContent = tempQuestions.Q18;
            question19.QuestionContent = tempQuestions.Q19;
            question20.QuestionContent = tempQuestions.Q20;
            question21.QuestionContent = tempQuestions.Q21;
            question22.QuestionContent = tempQuestions.Q22;
            question23.QuestionContent = tempQuestions.Q23;
            question24.QuestionContent = tempQuestions.Q24;
            question25.QuestionContent = tempQuestions.Q25;
            question26.QuestionContent = tempQuestions.Q26;
            question27.QuestionContent = tempQuestions.Q27;
            question28.QuestionContent = tempQuestions.Q28;
            question29.QuestionContent = tempQuestions.Q29;
            question30.QuestionContent = tempQuestions.Q30;

            questions.Add(question1);
            questions.Add(question2);
            questions.Add(question3);
            questions.Add(question4);
            questions.Add(question5);
            questions.Add(question6);
            questions.Add(question7);
            questions.Add(question8);
            questions.Add(question9);
            questions.Add(question10);
            questions.Add(question11);
            questions.Add(question12);
            questions.Add(question13);
            questions.Add(question14);
            questions.Add(question15);
            questions.Add(question16);
            questions.Add(question17);
            questions.Add(question18);
            questions.Add(question19);
            questions.Add(question20);
            questions.Add(question21);
            questions.Add(question22);
            questions.Add(question23);
            questions.Add(question24);
            questions.Add(question25);
            questions.Add(question26);
            questions.Add(question27);
            questions.Add(question28);
            questions.Add(question29);
            questions.Add(question30);
            
            

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