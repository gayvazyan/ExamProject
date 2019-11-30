using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestExample.Models;
using TestExample.MyModels;
using TestExample.ViewModels;

namespace TestExample.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ExamDbContect _examDBContect;

        public AdministrationController(RoleManager<IdentityRole> roleManager,
                                        ExamDbContect examDBContect)
        {
            _roleManager = roleManager;
            _examDBContect = examDBContect;
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                // We just need to specify a unique role name to create a new role
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };

                // Saves the role in the underlying AspNetRoles table
                IdentityResult result = await _roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("index", "home");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult ListRoles()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }


        //Start Question Part 

        [HttpGet]
        public IActionResult CreateQuestion()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuestion(CreateQuestionViewModel model)
        {
            if (ModelState.IsValid)
            {

                Question newQuestion = new Question
                {
                    QId = model.QId,
                    QuestionContent = model.QuestionContent
                };
                // Add new Question
                var result = await _examDBContect.DbQuestion.AddAsync(newQuestion);
                var resultSave = await _examDBContect.SaveChangesAsync();
            }

            return RedirectToAction("ListQuestions");
        }

        [HttpGet]
        public IActionResult ListQuestions()
        {
            var questions = _examDBContect.DbQuestion.ToList();
            return View(questions);
        }

        [HttpGet]
        public  IActionResult DeleteQuestion(int QId)
        {
            var question = _examDBContect.DbQuestion.FirstOrDefault(p => p.QId == QId);
           _examDBContect.DbQuestion.Remove(question);
            _examDBContect.SaveChanges();

            return RedirectToAction("ListQuestions");
        }

        //End Question Part 


        //Start Answer Part 

        [HttpGet]
        public IActionResult CreateAnswer()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAnswer(CreateAnswerViewModel model)
        {
            if (ModelState.IsValid)
            {

                Answer newAnswer = new Answer
                {
                    QuestionId = model.QuestionId,
                    QuestionVariantContent = model.QuestionVariantContent,
                    CorrectAnswer = model.CorrectAnswer
                };
                // Add new Answer
                var result = await _examDBContect.DbAnswer.AddAsync(newAnswer);
                var resultSave = await _examDBContect.SaveChangesAsync();
            }

            return RedirectToAction("ListAnswers");
        }

        [HttpGet]
        public IActionResult ListAnswers()
        {
            var answers = _examDBContect.DbAnswer.ToList();
            return View(answers);
        }

        [HttpGet]
        public IActionResult DeleteAnswer(int AId)
        {
            var answer = _examDBContect.DbAnswer.FirstOrDefault(p => p.Id == AId);
            _examDBContect.DbAnswer.Remove(answer);
            _examDBContect.SaveChanges();

            return RedirectToAction("ListAnswers");
        }

        //End Answer Part 
    }
}
