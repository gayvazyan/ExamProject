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
        [HttpGet]
        public IActionResult CurrentAttempt()
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
            int currentID = tempQuestions.CurrentAttempt;

            return RedirectToAction("Question", new { id = currentID + 1 });
        }

        [HttpGet]
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
            List<int> randomPart2 = RandomNumber.GetRandomNumbers(10, 36, 71);
            List<int> randomPart3 = RandomNumber.GetRandomNumbers(10, 71, 104);


            List<int> joinPart1andPart2 = (randomPart1.Concat(randomPart2)).ToList();

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
            tempQuestions.Q1 = questions[0].QuestionContent;
            tempQuestions.Q2 = questions[1].QuestionContent;
            tempQuestions.Q3 = questions[2].QuestionContent;
            tempQuestions.Q4 = questions[3].QuestionContent;
            tempQuestions.Q5 = questions[4].QuestionContent;
            tempQuestions.Q6 = questions[5].QuestionContent;
            tempQuestions.Q7 = questions[6].QuestionContent;
            tempQuestions.Q8 = questions[7].QuestionContent;
            tempQuestions.Q9 = questions[8].QuestionContent;
            tempQuestions.Q10 = questions[9].QuestionContent;
            tempQuestions.Q11 = questions[10].QuestionContent;
            tempQuestions.Q12 = questions[11].QuestionContent;
            tempQuestions.Q13 = questions[12].QuestionContent;
            tempQuestions.Q14 = questions[13].QuestionContent;
            tempQuestions.Q15 = questions[14].QuestionContent;
            tempQuestions.Q16 = questions[15].QuestionContent;
            tempQuestions.Q17 = questions[16].QuestionContent;
            tempQuestions.Q18 = questions[17].QuestionContent;
            tempQuestions.Q19 = questions[18].QuestionContent;
            tempQuestions.Q20 = questions[19].QuestionContent;
            tempQuestions.Q21 = questions[20].QuestionContent;
            tempQuestions.Q22 = questions[21].QuestionContent;
            tempQuestions.Q23 = questions[22].QuestionContent;
            tempQuestions.Q24 = questions[23].QuestionContent;
            tempQuestions.Q25 = questions[24].QuestionContent;
            tempQuestions.Q26 = questions[25].QuestionContent;
            tempQuestions.Q27 = questions[26].QuestionContent;
            tempQuestions.Q28 = questions[27].QuestionContent;
            tempQuestions.Q29 = questions[28].QuestionContent;
            tempQuestions.Q30 = questions[29].QuestionContent;

            _examDBContect.DbTempQuestions.Update(tempQuestions);
            _examDBContect.SaveChanges();

            //skizb_Test2Result-i maqrum
            CitizenReport citizenReport = _examDBContect.DbCitizenReport
                                          .FirstOrDefault(p => p.Passport == citizenUser.Passport);
            citizenReport.Result_Test2 = 0;
            citizenReport.Test2Check = false;
            citizenReport.Test2DataTime = DateTime.MinValue;
            _examDBContect.DbCitizenReport.Update(citizenReport);
            _examDBContect.SaveChanges();
            // verj_Test2Result-i maqrum

            List<Answer> answersList = _examDBContect.DbAnswer.ToList();

            foreach (var answer in answersList)
            {
                answer.CheckdAnswer = false;
                answer.CheckCorrectAnswer = false;
                _examDBContect.DbAnswer.Update(answer);
                _examDBContect.SaveChanges();
            }

            return RedirectToAction("Question", new { id = 1 });
        }


        [HttpGet]
        public IActionResult Question(int id)
        {
            CitizenUser citizenUser = new CitizenUser();
            if (User.Identity.IsAuthenticated)
            {
                var userName = User.Identity.Name;
                citizenUser = _userManager.Users.FirstOrDefault(p => p.Email == userName);
            }


            TempQuestions tempQuestions = new TempQuestions();
            tempQuestions = _examDBContect.DbTempQuestions.FirstOrDefault(p => p.Passport == citizenUser.Passport);

            ViewBag.QId = id;
            switch (id)
            {
                case 1:
                    ViewBag.Question = tempQuestions.Q1;
                    ViewBag.QuestionId = tempQuestions.Id1;
                    ViewBag.Cheked = tempQuestions.Cheked1;
                    ViewBag.Answer = tempQuestions.Answer1;

                    break;
                case 2:
                    ViewBag.Question = tempQuestions.Q2;
                    ViewBag.QuestionId = tempQuestions.Id2;
                    ViewBag.Cheked = tempQuestions.Cheked2;
                    ViewBag.Answer = tempQuestions.Answer2;

                    break;
                case 3:
                    ViewBag.Question = tempQuestions.Q3;
                    ViewBag.QuestionId = tempQuestions.Id3;
                    ViewBag.Cheked = tempQuestions.Cheked3;
                    ViewBag.Answer = tempQuestions.Answer3;
                    break;
                case 4:
                    ViewBag.Question = tempQuestions.Q4;
                    ViewBag.QuestionId = tempQuestions.Id4;
                    ViewBag.Cheked = tempQuestions.Cheked4;
                    ViewBag.Answer = tempQuestions.Answer4;
                    break;
                case 5:
                    ViewBag.Question = tempQuestions.Q5;
                    ViewBag.QuestionId = tempQuestions.Id5;
                    ViewBag.Cheked = tempQuestions.Cheked5;
                    ViewBag.Answer = tempQuestions.Answer5;
                    break;
                case 6:
                    ViewBag.Question = tempQuestions.Q6;
                    ViewBag.QuestionId = tempQuestions.Id6;
                    ViewBag.Cheked = tempQuestions.Cheked6;
                    ViewBag.Answer = tempQuestions.Answer6;
                    break;
                case 7:
                    ViewBag.Question = tempQuestions.Q7;
                    ViewBag.QuestionId = tempQuestions.Id7;
                    ViewBag.Cheked = tempQuestions.Cheked7;
                    ViewBag.Answer = tempQuestions.Answer7;
                    break;
                case 8:
                    ViewBag.Question = tempQuestions.Q8;
                    ViewBag.QuestionId = tempQuestions.Id8;
                    ViewBag.Cheked = tempQuestions.Cheked8;
                    ViewBag.Answer = tempQuestions.Answer8;
                    break;
                case 9:
                    ViewBag.Question = tempQuestions.Q9;
                    ViewBag.QuestionId = tempQuestions.Id9;
                    ViewBag.Cheked = tempQuestions.Cheked9;
                    ViewBag.Answer = tempQuestions.Answer9;
                    break;
                case 10:
                    ViewBag.Question = tempQuestions.Q10;
                    ViewBag.QuestionId = tempQuestions.Id10;
                    ViewBag.Cheked = tempQuestions.Cheked10;
                    ViewBag.Answer = tempQuestions.Answer10;
                    break;
                case 11:
                    ViewBag.Question = tempQuestions.Q11;
                    ViewBag.QuestionId = tempQuestions.Id11;
                    ViewBag.Cheked = tempQuestions.Cheked11;
                    ViewBag.Answer = tempQuestions.Answer11;
                    break;
                case 12:
                    ViewBag.Question = tempQuestions.Q12;
                    ViewBag.QuestionId = tempQuestions.Id12;
                    ViewBag.Cheked = tempQuestions.Cheked12;
                    ViewBag.Answer = tempQuestions.Answer12;
                    break;
                case 13:
                    ViewBag.Question = tempQuestions.Q13;
                    ViewBag.QuestionId = tempQuestions.Id13;
                    ViewBag.Cheked = tempQuestions.Cheked13;
                    ViewBag.Answer = tempQuestions.Answer13;
                    break;
                case 14:
                    ViewBag.Question = tempQuestions.Q14;
                    ViewBag.QuestionId = tempQuestions.Id14;
                    ViewBag.Cheked = tempQuestions.Cheked14;
                    ViewBag.Answer = tempQuestions.Answer14;
                    break;
                case 15:
                    ViewBag.Question = tempQuestions.Q15;
                    ViewBag.QuestionId = tempQuestions.Id15;
                    ViewBag.Cheked = tempQuestions.Cheked15;
                    ViewBag.Answer = tempQuestions.Answer15;
                    break;
                case 16:
                    ViewBag.Question = tempQuestions.Q16;
                    ViewBag.QuestionId = tempQuestions.Id16;
                    ViewBag.Cheked = tempQuestions.Cheked16;
                    ViewBag.Answer = tempQuestions.Answer16;
                    break;
                case 17:
                    ViewBag.Question = tempQuestions.Q17;
                    ViewBag.QuestionId = tempQuestions.Id17;
                    ViewBag.Cheked = tempQuestions.Cheked17;
                    ViewBag.Answer = tempQuestions.Answer17;
                    break;
                case 18:
                    ViewBag.Question = tempQuestions.Q18;
                    ViewBag.QuestionId = tempQuestions.Id18;
                    ViewBag.Cheked = tempQuestions.Cheked18;
                    ViewBag.Answer = tempQuestions.Answer18;
                    break;
                case 19:
                    ViewBag.Question = tempQuestions.Q19;
                    ViewBag.QuestionId = tempQuestions.Id19;
                    ViewBag.Cheked = tempQuestions.Cheked19;
                    ViewBag.Answer = tempQuestions.Answer19;
                    break;
                case 20:
                    ViewBag.Question = tempQuestions.Q20;
                    ViewBag.QuestionId = tempQuestions.Id20;
                    ViewBag.Cheked = tempQuestions.Cheked20;
                    ViewBag.Answer = tempQuestions.Answer20;
                    break;
                case 21:
                    ViewBag.Question = tempQuestions.Q21;
                    ViewBag.QuestionId = tempQuestions.Id21;
                    ViewBag.Cheked = tempQuestions.Cheked21;
                    ViewBag.Answer = tempQuestions.Answer21;
                    break;
                case 22:
                    ViewBag.Question = tempQuestions.Q22;
                    ViewBag.QuestionId = tempQuestions.Id22;
                    ViewBag.Cheked = tempQuestions.Cheked22;
                    ViewBag.Answer = tempQuestions.Answer22;
                    break;
                case 23:
                    ViewBag.Question = tempQuestions.Q23;
                    ViewBag.QuestionId = tempQuestions.Id23;
                    ViewBag.Cheked = tempQuestions.Cheked23;
                    ViewBag.Answer = tempQuestions.Answer23;
                    break;
                case 24:
                    ViewBag.Question = tempQuestions.Q24;
                    ViewBag.QuestionId = tempQuestions.Id24;
                    ViewBag.Cheked = tempQuestions.Cheked24;
                    ViewBag.Answer = tempQuestions.Answer24;
                    break;
                case 25:
                    ViewBag.Question = tempQuestions.Q25;
                    ViewBag.QuestionId = tempQuestions.Id25;
                    ViewBag.Cheked = tempQuestions.Cheked25;
                    ViewBag.Answer = tempQuestions.Answer25;
                    break;
                case 26:
                    ViewBag.Question = tempQuestions.Q26;
                    ViewBag.QuestionId = tempQuestions.Id26;
                    ViewBag.Cheked = tempQuestions.Cheked26;
                    ViewBag.Answer = tempQuestions.Answer26;
                    break;
                case 27:
                    ViewBag.Question = tempQuestions.Q27;
                    ViewBag.QuestionId = tempQuestions.Id27;
                    ViewBag.Cheked = tempQuestions.Cheked27;
                    ViewBag.Answer = tempQuestions.Answer27;
                    break;
                case 28:
                    ViewBag.Question = tempQuestions.Q28;
                    ViewBag.QuestionId = tempQuestions.Id28;
                    ViewBag.Cheked = tempQuestions.Cheked28;
                    ViewBag.Answer = tempQuestions.Answer28;
                    break;
                case 29:
                    ViewBag.Question = tempQuestions.Q29;
                    ViewBag.QuestionId = tempQuestions.Id29;
                    ViewBag.Cheked = tempQuestions.Cheked29;
                    ViewBag.Answer = tempQuestions.Answer29;
                    break;

                default:
                    ViewBag.Question = tempQuestions.Q30;
                    ViewBag.QuestionId = tempQuestions.Id30;
                    ViewBag.Cheked = tempQuestions.Cheked30;
                    ViewBag.Answer = tempQuestions.Answer30;
                    break;
            }

            //ays hatvacum petq e uxarkem tvyalner Harcashari uxecuyci hmara
            //masnavorapes ete jist e patasxanel Score=1 chekd=1
            //ete sxal e patasxanel Score=0 chekd=1
            //ete chi patasxanel chekd=0

            #region ViewBag.Cheked
            ViewBag.Cheked1 = tempQuestions.Cheked1;
            ViewBag.Cheked2 = tempQuestions.Cheked2;
            ViewBag.Cheked3 = tempQuestions.Cheked3;
            ViewBag.Cheked4 = tempQuestions.Cheked4;
            ViewBag.Cheked5 = tempQuestions.Cheked5;
            ViewBag.Cheked6 = tempQuestions.Cheked6;
            ViewBag.Cheked7 = tempQuestions.Cheked7;
            ViewBag.Cheked8 = tempQuestions.Cheked8;
            ViewBag.Cheked9 = tempQuestions.Cheked9;
            ViewBag.Cheked10 = tempQuestions.Cheked10;
            ViewBag.Cheked11 = tempQuestions.Cheked11;
            ViewBag.Cheked12 = tempQuestions.Cheked12;
            ViewBag.Cheked13 = tempQuestions.Cheked13;
            ViewBag.Cheked14 = tempQuestions.Cheked14;
            ViewBag.Cheked15 = tempQuestions.Cheked15;
            ViewBag.Cheked16 = tempQuestions.Cheked16;
            ViewBag.Cheked17 = tempQuestions.Cheked17;
            ViewBag.Cheked18 = tempQuestions.Cheked18;
            ViewBag.Cheked19 = tempQuestions.Cheked19;
            ViewBag.Cheked20 = tempQuestions.Cheked20;
            ViewBag.Cheked21 = tempQuestions.Cheked21;
            ViewBag.Cheked22 = tempQuestions.Cheked22;
            ViewBag.Cheked23 = tempQuestions.Cheked23;
            ViewBag.Cheked24 = tempQuestions.Cheked24;
            ViewBag.Cheked25 = tempQuestions.Cheked25;
            ViewBag.Cheked26 = tempQuestions.Cheked26;
            ViewBag.Cheked27 = tempQuestions.Cheked27;
            ViewBag.Cheked28 = tempQuestions.Cheked28;
            ViewBag.Cheked29 = tempQuestions.Cheked29;
            ViewBag.Cheked30 = tempQuestions.Cheked30;
            #endregion


            List<Answer> answersList = _examDBContect.DbAnswer.ToList();
            return View(answersList);

        }


        [HttpPost]
        public IActionResult Question(IFormCollection ifromCollection, string Idnext, string Idpreview)
        {
            int qId = (Idnext == null) ? (Convert.ToInt32(Idpreview) + 1) : (qId = Convert.ToInt32(Idnext) - 1);

            CitizenUser citizenUser = new CitizenUser();
            if (User.Identity.IsAuthenticated)
            {
                var userName = User.Identity.Name;
                citizenUser = _userManager.Users.FirstOrDefault(p => p.Email == userName);
            }

            CitizenReport citizenReport = _examDBContect.DbCitizenReport.FirstOrDefault(p => p.Passport == citizenUser.Passport);
            TempQuestions tempQuestions = new TempQuestions();
            tempQuestions = _examDBContect.DbTempQuestions.FirstOrDefault(p => p.Passport == citizenUser.Passport);
            tempQuestions.CurrentAttempt = qId;
            _examDBContect.DbTempQuestions.Update(tempQuestions);

            string[] questionIds = ifromCollection["questionId"];
            foreach (var questionId in questionIds)
            {
                // null-i problemy
                string checkedValueString = ifromCollection["question_" + questionId];


                int checkedValueInt = Convert.ToInt32(checkedValueString);

                if (checkedValueInt != 0)
                {
                    Answer answer1 = _examDBContect.DbAnswer.FirstOrDefault(p => p.Id == checkedValueInt);
                    var QestionID = answer1.QuestionId;
                    Answer answer2 = _examDBContect.DbAnswer.FirstOrDefault(p => p.QuestionId == QestionID);


                    var idFirst = answer2.Id;
                    Answer answerFirst = _examDBContect.DbAnswer.FirstOrDefault(p => p.Id == idFirst);
                    answerFirst.CheckdAnswer = false;
                    answerFirst.CheckCorrectAnswer = false;
                    _examDBContect.DbAnswer.Update(answerFirst);
                    _examDBContect.SaveChanges();


                    var idSecond = answer2.Id + 1;
                    Answer answerSecond = _examDBContect.DbAnswer.FirstOrDefault(p => p.Id == idSecond);
                    answerSecond.CheckdAnswer = false;
                    answerSecond.CheckCorrectAnswer = false;
                    _examDBContect.DbAnswer.Update(answerSecond);
                    _examDBContect.SaveChanges();



                    var idThird = answer2.Id + 2;
                    Answer answerThird = _examDBContect.DbAnswer.FirstOrDefault(p => p.Id == idSecond);
                    answerThird.CheckdAnswer = false;
                    answerThird.CheckCorrectAnswer = false;
                    _examDBContect.DbAnswer.Update(answerThird);
                    _examDBContect.SaveChanges();

                    Answer answer = _examDBContect.DbAnswer.FirstOrDefault(p => p.Id == checkedValueInt);
                    answer.CheckdAnswer = true;
                    if (answer.CorrectAnswer == true)
                    {
                        answer.CheckCorrectAnswer = true;
                        _examDBContect.DbAnswer.Update(answer);
                        _examDBContect.SaveChanges();

                        switch (qId)
                        {
                            case 1:
                                tempQuestions.Score1 = 1;
                                break;
                            case 2:
                                tempQuestions.Score2 = 1;
                                break;
                            case 3:
                                tempQuestions.Score3 = 1;
                                break;
                            case 4:
                                tempQuestions.Score4 = 1;
                                break;
                            case 5:
                                tempQuestions.Score5 = 1;
                                break;
                            case 6:
                                tempQuestions.Score6 = 1;
                                break;
                            case 7:
                                tempQuestions.Score7 = 1;
                                break;
                            case 8:
                                tempQuestions.Score8 = 1;
                                break;
                            case 9:
                                tempQuestions.Score9 = 1;
                                break;
                            case 10:
                                tempQuestions.Score10 = 1;
                                break;
                            case 11:
                                tempQuestions.Score11 = 1;
                                break;
                            case 12:
                                tempQuestions.Score12 = 1;
                                break;
                            case 13:
                                tempQuestions.Score13 = 1;
                                break;
                            case 14:
                                tempQuestions.Score14 = 1;
                                break;
                            case 15:
                                tempQuestions.Score15 = 1;
                                break;
                            case 16:
                                tempQuestions.Score16 = 1;
                                break;
                            case 17:
                                tempQuestions.Score17 = 1;
                                break;
                            case 18:
                                tempQuestions.Score18 = 1;
                                break;
                            case 19:
                                tempQuestions.Score19 = 1;
                                break;
                            case 20:
                                tempQuestions.Score20 = 1;
                                break;
                            case 21:
                                tempQuestions.Score21 = 1;
                                break;
                            case 22:
                                tempQuestions.Score22 = 1;
                                break;
                            case 23:
                                tempQuestions.Score23 = 1;
                                break;
                            case 24:
                                tempQuestions.Score24 = 1;
                                break;
                            case 25:
                                tempQuestions.Score25 = 1;
                                break;
                            case 26:
                                tempQuestions.Score26 = 1;
                                break;
                            case 27:
                                tempQuestions.Score27 = 1;
                                break;
                            case 28:
                                tempQuestions.Score28 = 1;
                                break;
                            case 29:
                                tempQuestions.Score29 = 1;
                                break;
                            case 30:
                                tempQuestions.Score30 = 1;
                                break;

                            default:

                                break;
                        }
                    }
                    else
                    {

                        switch (qId)
                        {
                            case 1:
                                tempQuestions.Score1 = 0;
                                break;
                            case 2:
                                tempQuestions.Score2 = 0;
                                break;
                            case 3:
                                tempQuestions.Score3 = 0;
                                break;
                            case 4:
                                tempQuestions.Score4 = 0;
                                break;
                            case 5:
                                tempQuestions.Score5 = 0;
                                break;
                            case 6:
                                tempQuestions.Score6 = 0;
                                break;
                            case 7:
                                tempQuestions.Score7 = 0;
                                break;
                            case 8:
                                tempQuestions.Score8 = 0;
                                break;
                            case 9:
                                tempQuestions.Score9 = 0;
                                break;
                            case 10:
                                tempQuestions.Score10 = 0;
                                break;
                            case 11:
                                tempQuestions.Score11 = 0;
                                break;
                            case 12:
                                tempQuestions.Score12 = 0;
                                break;
                            case 13:
                                tempQuestions.Score13 = 0;
                                break;
                            case 14:
                                tempQuestions.Score14 = 0;
                                break;
                            case 15:
                                tempQuestions.Score15 = 0;
                                break;
                            case 16:
                                tempQuestions.Score16 = 0;
                                break;
                            case 17:
                                tempQuestions.Score17 = 0;
                                break;
                            case 18:
                                tempQuestions.Score18 = 0;
                                break;
                            case 19:
                                tempQuestions.Score19 = 0;
                                break;
                            case 20:
                                tempQuestions.Score20 = 0;
                                break;
                            case 21:
                                tempQuestions.Score21 = 0;
                                break;
                            case 22:
                                tempQuestions.Score22 = 0;
                                break;
                            case 23:
                                tempQuestions.Score23 = 0;
                                break;
                            case 24:
                                tempQuestions.Score24 = 0;
                                break;
                            case 25:
                                tempQuestions.Score25 = 0;
                                break;
                            case 26:
                                tempQuestions.Score26 = 0;
                                break;
                            case 27:
                                tempQuestions.Score27 = 0;
                                break;
                            case 28:
                                tempQuestions.Score28 = 0;
                                break;
                            case 29:
                                tempQuestions.Score29 = 0;
                                break;
                            case 30:
                                tempQuestions.Score30 = 0;
                                break;

                            default:

                                break;
                        }
                    }

                    //avelacnum enq cheked araci texty

                    switch (qId)
                    {
                        case 1:
                            tempQuestions.Cheked1 = true;
                            tempQuestions.Answer1 = answer.QuestionVariantContent;
                            break;
                        case 2:
                            tempQuestions.Cheked2 = true;
                            tempQuestions.Answer2 = answer.QuestionVariantContent;
                            break;
                        case 3:
                            tempQuestions.Cheked3 = true;
                            tempQuestions.Answer3 = answer.QuestionVariantContent;
                            break;
                        case 4:
                            tempQuestions.Cheked4 = true;
                            tempQuestions.Answer4 = answer.QuestionVariantContent;
                            break;
                        case 5:
                            tempQuestions.Cheked5 = true;
                            tempQuestions.Answer5 = answer.QuestionVariantContent;
                            break;
                        case 6:
                            tempQuestions.Cheked6 = true;
                            tempQuestions.Answer6 = answer.QuestionVariantContent;
                            break;
                        case 7:
                            tempQuestions.Cheked7 = true;
                            tempQuestions.Answer7 = answer.QuestionVariantContent;
                            break;
                        case 8:
                            tempQuestions.Cheked8 = true;
                            tempQuestions.Answer8 = answer.QuestionVariantContent;
                            break;
                        case 9:
                            tempQuestions.Cheked9 = true;
                            tempQuestions.Answer9 = answer.QuestionVariantContent;
                            break;
                        case 10:
                            tempQuestions.Cheked10 = true;
                            tempQuestions.Answer10 = answer.QuestionVariantContent;
                            break;
                        case 11:
                            tempQuestions.Cheked11 = true;
                            tempQuestions.Answer11 = answer.QuestionVariantContent;
                            break;
                        case 12:
                            tempQuestions.Cheked12 = true;
                            tempQuestions.Answer12 = answer.QuestionVariantContent;
                            break;
                        case 13:
                            tempQuestions.Cheked13 = true;
                            tempQuestions.Answer13 = answer.QuestionVariantContent;
                            break;
                        case 14:
                            tempQuestions.Cheked14 = true;
                            tempQuestions.Answer14 = answer.QuestionVariantContent;
                            break;
                        case 15:
                            tempQuestions.Cheked15 = true;
                            tempQuestions.Answer15 = answer.QuestionVariantContent;
                            break;
                        case 16:
                            tempQuestions.Cheked16 = true;
                            tempQuestions.Answer16 = answer.QuestionVariantContent;
                            break;
                        case 17:
                            tempQuestions.Cheked17 = true;
                            tempQuestions.Answer17 = answer.QuestionVariantContent;
                            break;
                        case 18:
                            tempQuestions.Cheked18 = true;
                            tempQuestions.Answer18 = answer.QuestionVariantContent;
                            break;
                        case 19:
                            tempQuestions.Cheked19 = true;
                            tempQuestions.Answer19 = answer.QuestionVariantContent;
                            break;
                        case 20:
                            tempQuestions.Cheked20 = true;
                            tempQuestions.Answer20 = answer.QuestionVariantContent;
                            break;
                        case 21:
                            tempQuestions.Cheked21 = true;
                            tempQuestions.Answer21 = answer.QuestionVariantContent;
                            break;
                        case 22:
                            tempQuestions.Cheked22 = true;
                            tempQuestions.Answer22 = answer.QuestionVariantContent;
                            break;
                        case 23:
                            tempQuestions.Cheked23 = true;
                            tempQuestions.Answer23 = answer.QuestionVariantContent;
                            break;
                        case 24:
                            tempQuestions.Cheked24 = true;
                            tempQuestions.Answer24 = answer.QuestionVariantContent;
                            break;
                        case 25:
                            tempQuestions.Cheked25 = true;
                            tempQuestions.Answer25 = answer.QuestionVariantContent;
                            break;
                        case 26:
                            tempQuestions.Cheked26 = true;
                            tempQuestions.Answer26 = answer.QuestionVariantContent;
                            break;
                        case 27:
                            tempQuestions.Cheked27 = true;
                            tempQuestions.Answer27 = answer.QuestionVariantContent;
                            break;
                        case 28:
                            tempQuestions.Cheked28 = true;
                            tempQuestions.Answer28 = answer.QuestionVariantContent;
                            break;
                        case 29:
                            tempQuestions.Cheked29 = true;
                            tempQuestions.Answer29 = answer.QuestionVariantContent;
                            break;
                        case 30:
                            tempQuestions.Cheked30 = true;
                            tempQuestions.Answer30 = answer.QuestionVariantContent;
                            break;

                        default:

                            break;
                    }

                    _examDBContect.DbTempQuestions.Update(tempQuestions);
                    _examDBContect.SaveChanges();
                }


            }

            #region ScoreCount
            var score = 0;
            if (tempQuestions.Score1 == 1) { score++; }
            if (tempQuestions.Score2 == 1) { score++; }
            if (tempQuestions.Score3 == 1) { score++; }
            if (tempQuestions.Score4 == 1) { score++; }
            if (tempQuestions.Score5 == 1) { score++; }
            if (tempQuestions.Score6 == 1) { score++; }
            if (tempQuestions.Score7 == 1) { score++; }
            if (tempQuestions.Score8 == 1) { score++; }
            if (tempQuestions.Score9 == 1) { score++; }
            if (tempQuestions.Score10 == 1) { score++; }
            if (tempQuestions.Score11 == 1) { score++; }
            if (tempQuestions.Score12 == 1) { score++; }
            if (tempQuestions.Score13 == 1) { score++; }
            if (tempQuestions.Score14 == 1) { score++; }
            if (tempQuestions.Score15 == 1) { score++; }
            if (tempQuestions.Score16 == 1) { score++; }
            if (tempQuestions.Score17 == 1) { score++; }
            if (tempQuestions.Score18 == 1) { score++; }
            if (tempQuestions.Score19 == 1) { score++; }
            if (tempQuestions.Score20 == 1) { score++; }
            if (tempQuestions.Score21 == 1) { score++; }
            if (tempQuestions.Score22 == 1) { score++; }
            if (tempQuestions.Score23 == 1) { score++; }
            if (tempQuestions.Score24 == 1) { score++; }
            if (tempQuestions.Score25 == 1) { score++; }
            if (tempQuestions.Score26 == 1) { score++; }
            if (tempQuestions.Score27 == 1) { score++; }
            if (tempQuestions.Score28 == 1) { score++; }
            if (tempQuestions.Score29 == 1) { score++; }
            if (tempQuestions.Score30 == 1) { score++; }
            #endregion

            citizenReport.Result_Test2 = score;
            citizenReport.Test2Check = true;
            citizenReport.Test2DataTime = DateTime.Now;
            _examDBContect.DbCitizenReport.Update(citizenReport);
            _examDBContect.SaveChanges();

            if ((qId == 30) && (Idnext == null))
            {
                return RedirectToAction("Question", new { id = qId - 1 });
            }



            if (qId != 30)
            {
                if (Idnext == null)
                {
                    return RedirectToAction("Question", new { id = qId - 1 });
                }
                else
                {
                    return RedirectToAction("Question", new { id = qId + 1 });
                }
            }
            else
            {
                return RedirectToAction("FullResult");
            }
        }

        [HttpPost]
        public IActionResult Submit(IFormCollection ifromCollection)
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

            #region  List<Question>
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
            #endregion


            ViewBag.Questions = questions;
            List<Answer> answersList = _examDBContect.DbAnswer.ToList();

            return View("Result", answersList);


        }

        [HttpGet]
        public IActionResult Result()
        {
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
            ViewBag.Result_Test2 = citizenReport.Result_Test2;





            TempQuestions tempQuestions = new TempQuestions();
            tempQuestions = _examDBContect.DbTempQuestions
                      .FirstOrDefault(p => p.Passport == citizenUser.Passport);


            #region AddAllQuestionsInViewBag
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

            #endregion

            ViewBag.Questions = questions;

            List<Answer> answersList = _examDBContect.DbAnswer.ToList();

            return View(answersList);


        }

        [HttpGet]
        public IActionResult FullResult()
        {
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
            ViewBag.Result_Test2 = citizenReport.Result_Test2;





            TempQuestions tempQuestions = new TempQuestions();
            tempQuestions = _examDBContect.DbTempQuestions
                      .FirstOrDefault(p => p.Passport == citizenUser.Passport);
            tempQuestions.CurrentAttempt = 30;
            _examDBContect.DbTempQuestions.Update(tempQuestions);
            _examDBContect.SaveChanges();

            #region ViewBag.Score
            ViewBag.Score1 = tempQuestions.Score1;
            ViewBag.Score2 = tempQuestions.Score2;
            ViewBag.Score3 = tempQuestions.Score3;
            ViewBag.Score4 = tempQuestions.Score4;
            ViewBag.Score5 = tempQuestions.Score5;
            ViewBag.Score6 = tempQuestions.Score6;
            ViewBag.Score7 = tempQuestions.Score7;
            ViewBag.Score8 = tempQuestions.Score8;
            ViewBag.Score9 = tempQuestions.Score9;
            ViewBag.Score10 = tempQuestions.Score10;
            ViewBag.Score11 = tempQuestions.Score11;
            ViewBag.Score12 = tempQuestions.Score12;
            ViewBag.Score13 = tempQuestions.Score13;
            ViewBag.Score14 = tempQuestions.Score14;
            ViewBag.Score15 = tempQuestions.Score15;
            ViewBag.Score16 = tempQuestions.Score16;
            ViewBag.Score17 = tempQuestions.Score17;
            ViewBag.Score18 = tempQuestions.Score18;
            ViewBag.Score19 = tempQuestions.Score19;
            ViewBag.Score20 = tempQuestions.Score20;
            ViewBag.Score21 = tempQuestions.Score21;
            ViewBag.Score22 = tempQuestions.Score22;
            ViewBag.Score23 = tempQuestions.Score23;
            ViewBag.Score24 = tempQuestions.Score24;
            ViewBag.Score25 = tempQuestions.Score25;
            ViewBag.Score26 = tempQuestions.Score26;
            ViewBag.Score27 = tempQuestions.Score27;
            ViewBag.Score28 = tempQuestions.Score28;
            ViewBag.Score29 = tempQuestions.Score29;
            ViewBag.Score30 = tempQuestions.Score30;
            #endregion



            #region AddAllQuestionsInViewBag
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

            #endregion

            ViewBag.Questions = questions;

            List<Answer> answersList = _examDBContect.DbAnswer.ToList();

            return View(answersList);


        }

        [HttpGet]
        public IActionResult AllTest()
        {
            CitizenUser citizenUser = new CitizenUser();
            if (User.Identity.IsAuthenticated)
            {
                var userName = User.Identity.Name;
                citizenUser = _userManager.Users.FirstOrDefault(p => p.Email == userName);
            }


            //  ViewBag.Questions = _examDBContect.DbQuestion1.ToList();
            int countQuestion = _examDBContect.DbQuestion.Count();


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

            foreach (var answer in answersList)
            {
                answer.CheckdAnswer = false;
                answer.CheckCorrectAnswer = false;
                _examDBContect.DbAnswer.Update(answer);
                _examDBContect.SaveChanges();
            }

            return View(answersList);
        }

        [HttpGet]
        public IActionResult Random()
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
            int currentID = tempQuestions.CurrentAttempt;
            ViewBag.CurrentID = currentID;
            return View();
        }

        [HttpGet]
        public IActionResult Table(int idCurrent)
        {

            if (idCurrent == 31)
            {
                return RedirectToAction("FullResult");
            }
            return RedirectToAction("Question", new { id = idCurrent });
        }
    }
}