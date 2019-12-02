using Microsoft.AspNetCore.Authorization;
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
    //[Authorize(Roles = "Admin")]
    public class AdministrationController : Controller
    {
        private readonly UserManager<CitizenUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ExamDbContect _examDBContect;

        public AdministrationController(UserManager<CitizenUser> userManager, 
                                        RoleManager<IdentityRole> roleManager,
                                        ExamDbContect examDBContect)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _examDBContect = examDBContect;
        }

        //Start Roles Part

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
                    return RedirectToAction("ListRoles", "Administration");
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

        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            // Find the role by Role ID
            var role = await _roleManager.FindByIdAsync(id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Id = {id} Role չի գտնվել";
                return View("NotFound");
            }

            var model = new EditRoleViewModel
            {
                Id = role.Id,
                RoleName = role.Name
            };

            // Retrieve all the Users
            foreach (var user in _userManager.Users)
            {
                // If the user is in this role, add the username to
                // Users property of EditRoleViewModel. This model
                // object is then passed to the view for display
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }

            return View(model);
        }

        // This action responds to HttpPost and receives EditRoleViewModel
        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {
            var role = await _roleManager.FindByIdAsync(model.Id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Id = {model.Id} Role չի գտնվել";
                return View("NotFound");
            }
            else
            {
                role.Name = model.RoleName;

                // Update the Role using UpdateAsync
                var result = await _roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(model);
            }
        }

        //ավելացնւմ ենք Role-ում User ev heracnum 
        [HttpGet]
        public async Task<IActionResult> EditUsersInRole(string roleId)
        {
            ViewBag.roleId = roleId;

            var role = await _roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $" Id = {roleId} Role չի գտնվել";
                return View("NotFound");
            }

            var model = new List<UserRoleViewModel>();

            foreach (var user in _userManager.Users)
            {
                var userRoleViewModel = new UserRoleViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName
                };

                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleViewModel.IsSelected = true;
                }
                else
                {
                    userRoleViewModel.IsSelected = false;
                }

                model.Add(userRoleViewModel);
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Id = {roleId} Role չի գտնվել";
                return View("NotFound");
            }

            for (int i = 0; i < model.Count; i++)
            {
                var user = await _userManager.FindByIdAsync(model[i].UserId);

                IdentityResult result = null;

                if (model[i].IsSelected && !(await _userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await _userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].IsSelected && await _userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await _userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }

                if (result.Succeeded)
                {
                    if (i < (model.Count - 1))
                        continue;
                    else
                        return RedirectToAction("EditRole", new { Id = roleId });
                }
            }

            return RedirectToAction("EditRole", new { Id = roleId });
        }

        //End Roles Part 

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

        //Start Users Part 
        [HttpGet]
        public IActionResult ListUsers()
        {
            var users = _userManager.Users;
            return View(users);
        }
        //End Users Part 
    }
}
