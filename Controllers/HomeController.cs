using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Flashcards.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Flashcards.ViewModels;
using Flashcards.Models.Entities;

namespace Flashcards.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
		private readonly IFlashcardFolderRepository _folderRepository;

		public HomeController(ILogger<HomeController> logger,
                              UserManager<ApplicationUser> userManager,
                              IFlashcardFolderRepository folderRepository)
        {
            _logger = logger;
            _userManager = userManager;
			_folderRepository = folderRepository;
		}

        public async Task<IActionResult> Index()
        {
            ViewBag.UserData = _userManager.GetUserName(HttpContext.User);
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user == null)
			{
                return Redirect("/Identity/Account/Logout");
			}
        
            var flashcardFoldersViewModel = new FlashcardFoldersViewModel {};
            if (user.FlashcardFolderIds != null)
            {
                flashcardFoldersViewModel.FlashcardFolders = new List<FlashcardFolder> { };
                foreach (var folderId in user.FlashcardFolderIds)
                {
                    flashcardFoldersViewModel.FlashcardFolders
                        .Add(_folderRepository.GetFolderById(folderId));
                }
            }
   
			
            
            return View(flashcardFoldersViewModel);
        }

        public IActionResult FolderDetails(string Id)
		{
            ViewBag.UserMessage = TempData["UserMessage"];
            var folder = _folderRepository.GetFolderById(Id);
            var flashcardFolderInfoViewModel = new FlashcardFolderInfoViewModel
            {
                Name = folder.FolderName,
                Subject = folder.Subject,
                Description = folder.Description,
                FlashcardFolderId = folder.Id
            };

            return View(flashcardFolderInfoViewModel);

		}

        public IActionResult EditFolder(string Id)
		{
            var folder = _folderRepository.GetFolderById(Id);
            var flashcardFolderInfoViewModel = new FlashcardFolderInfoViewModel
            {
                Name = folder.FolderName,
                Subject = folder.Subject,
                Description = folder.Description,
                FlashcardFolderId = folder.Id
            };

            return View(flashcardFolderInfoViewModel);

        }

        [HttpPost]
        public IActionResult EditFolder(FlashcardFolderInfoViewModel flashcardFolderInfoViewModel)
        {
            if (ModelState.IsValid)
            {
                var folder = new FlashcardFolder
                {
                    FolderName = flashcardFolderInfoViewModel.Name,
                    Subject = flashcardFolderInfoViewModel.Subject,
                    Description = flashcardFolderInfoViewModel.Description,
                    Id = flashcardFolderInfoViewModel.FlashcardFolderId
                };

                var success = _folderRepository.UpdateFolder(folder);

                if (success)
                {
                    TempData["UserMessage"] = "Folder updated!";
                    return RedirectToAction("FolderDetails", new { Id = flashcardFolderInfoViewModel.FlashcardFolderId });
                }
            }
            ModelState.AddModelError("EditFolderFailed", "Unable to make your changes. Please make sure every field is filled in, then try again.");
            return View(flashcardFolderInfoViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult InitNewFolder()
		{
            var newFolderId = Guid.NewGuid().ToString();
            return RedirectToAction("CreateFolder", new { Id = newFolderId });
		}

        public IActionResult CreateFolder(string Id)
		{
            if (TempData["ErrorMessage"] != null)
            {
                ViewBag.ErrorMessage = TempData["ErrorMessage"];
            }

            
            var flashcardFolderInfoViewModel = new FlashcardFolderInfoViewModel
            {
                Name = "",
                Subject = "",
                Description = "Type a description of your Folder here",
                FlashcardFolderId = Id
            };
			

            return View(flashcardFolderInfoViewModel);
		}

        [HttpPost]
        public async Task<IActionResult> CreateFolder(FlashcardFolderInfoViewModel flashcardFolderInfoViewModel)
		{
            if (ModelState.IsValid)
            {
                var folder = new FlashcardFolder
                {
                    FolderName = flashcardFolderInfoViewModel.Name,
                    Subject = flashcardFolderInfoViewModel.Subject,
                    Description = flashcardFolderInfoViewModel.Description,
                    Id = flashcardFolderInfoViewModel.FlashcardFolderId
                };
                var success = _folderRepository.CreateFolder(folder);
                if (success)
                {
                    var user = await _userManager.GetUserAsync(HttpContext.User);
                    //probably want to change user.flashcardfolderids to a list, this is messy and confusing
                    //
                    
                    if (user.FlashcardFolderIds != null )
					{
                        var oldIds = user.FlashcardFolderIds;
                        
                        // If the user deletes all their folderIds, the database leaves an empty string in their folderId column.
                        // (Probably bc of serialization of the enumerable)
                        // Replacing user.FlashcardFolderIds that has "" at index 0 is the same as starting a new list.
                        if (oldIds[0] == "")
                        {
                            var newIds = new List<string> { flashcardFolderInfoViewModel.FlashcardFolderId };
                            user.FlashcardFolderIds = newIds;
                        }
                        else
                        {
                            user.FlashcardFolderIds.Add(flashcardFolderInfoViewModel.FlashcardFolderId);
                        }
                    }
					else { user.FlashcardFolderIds = new List<string> { flashcardFolderInfoViewModel.FlashcardFolderId }; }
					
                    
                    await _userManager.UpdateAsync(user);
                    return RedirectToAction("CreateFolderSuccess", new { Id = flashcardFolderInfoViewModel.FlashcardFolderId });
                }
            }
            TempData["ErrorMessage"] = "Something happened and we couldn't create that folder.  Make sure you filled in every field, then try again.";
            return RedirectToAction("CreateFolder", new { Id = flashcardFolderInfoViewModel.FlashcardFolderId });
		}

        public IActionResult CreateFolderSuccess(string Id)
		{
            var folder = _folderRepository.GetFolderById(Id);
            var flashcardFolderInfoViewModel = new FlashcardFolderInfoViewModel
            {
                Name = folder.FolderName,
                FlashcardFolderId = Id
            };

            return View(flashcardFolderInfoViewModel);
		}

        public async Task<IActionResult> RemoveFolder(string Id)
		{
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var newList = user.FlashcardFolderIds.ToList();
            newList.Remove(newList.First(x => x == Id));
            
            user.FlashcardFolderIds = newList;
            

            await _userManager.UpdateAsync(user);
            return RedirectToAction("Index");
		}
    }
}
