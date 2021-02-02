using System;
using Flashcards.ActionFilters;
using Flashcards.Models;
using Flashcards.Models.Entities;
using Flashcards.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;

namespace Flashcards.Controllers
{
    [Authorize]
    
    public class FlashcardController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IFlashcardFolderRepository _folderRepository;
        private readonly IFlashcardRepository _flashcardRepository;

        public FlashcardController(ILogger<HomeController> logger,
                              UserManager<ApplicationUser> userManager,
                              IFlashcardFolderRepository folderRepository,
                              IFlashcardRepository flashcardRepository)
        {
            _logger = logger;
            _userManager = userManager;
            _folderRepository = folderRepository;
            _flashcardRepository = flashcardRepository;
        }

        //Get
        public IActionResult AddCard(string flashcardFolderId)
		{
            if (TempData["UserMessage"] != null)
			{
                ViewBag.UserMessage = TempData["UserMessage"];
			}
            if (TempData["ErrorMessage"] != null)
			{
                ViewBag.ErrorMessage = TempData["ErrorMessage"];
            }
            var temp = flashcardFolderId;
            var flashcardsViewModel = new FlashcardsViewModel
            {
                FolderName = _folderRepository.GetFolderById(flashcardFolderId).FolderName,
                FlashcardFolderId = flashcardFolderId,
                CurrentStack = _folderRepository.GetFlashcards(flashcardFolderId)
                
            };
            //Reverse current stack in order to show the newest card at the top of the list in the view.
            flashcardsViewModel.CurrentStack.Reverse();

            return View(flashcardsViewModel);
		}

        [HttpPost]
        public IActionResult AddCard(FlashcardViewModel flashcardViewModel)
		{
            if (ModelState.IsValid)
			{
                var flashcard = new Flashcard
                {
                    FrontText = flashcardViewModel.FrontText,
                    BackText = flashcardViewModel.BackText,
                    FlashcardFolderId = flashcardViewModel.FlashcardFolderId,
                    Id = Guid.NewGuid().ToString()
                };
                

                var success = _folderRepository.AddFlashcard(flashcard);
				if (success)
				{
                    TempData["UserMessage"] = "Card added successfully";
                    return RedirectToAction("AddCard", new { flashcardFolderId = flashcard.FlashcardFolderId });
                }
            }
            TempData["ErrorMessage"] = "Unable to add card to folder.  Please try again.";
            return RedirectToAction("AddCard", new { flashcardFolderId = flashcardViewModel.FlashcardFolderId });
			
		}

        public IActionResult ViewCards(string flashcardFolderId)
        {
            if (TempData["UserMessage"] != null)
            {
                ViewBag.UserMessage = TempData["UserMessage"];
            }
            if (TempData["ErrorMessage"] != null)
            {
                ViewBag.ErrorMessage = TempData["ErrorMessage"];
            }

            var flashcardsViewModel = new FlashcardsViewModel
            {
                FolderName = _folderRepository.GetFolderById(flashcardFolderId).FolderName,
                CurrentStack = _folderRepository.GetFlashcards(flashcardFolderId),
                FlashcardFolderId = flashcardFolderId
            };
            return View(flashcardsViewModel);
        
		}

        public IActionResult Practice(string flashcardFolderId)
		{
            var flashcardsViewModel = new FlashcardsViewModel
            {
                FolderName = _folderRepository.GetFolderById(flashcardFolderId).FolderName,
                CurrentStack = _folderRepository.GetFlashcards(flashcardFolderId),
                FlashcardFolderId = flashcardFolderId
            };
            return View(flashcardsViewModel);
        }

        public IActionResult DeleteCard(string flashcardId)
		{
            var cardToDelete = _flashcardRepository.GetFlashcardById(flashcardId);
            var folderId = cardToDelete.FlashcardFolderId;

            _flashcardRepository.RemoveFlashcard(cardToDelete);

            return RedirectToAction("ViewCards", new { flashcardFolderId = folderId });

		}

        public IActionResult EditCard(string flashcardId)
		{
            var flashcard = _flashcardRepository.GetFlashcardById(flashcardId);
            var flashcardViewModel = new FlashcardViewModel
            {
                FlashcardFolderId = flashcard.FlashcardFolderId,
                FrontText = flashcard.FrontText,
                BackText = flashcard.BackText,
                Id = flashcardId
            };
            return View(flashcardViewModel);
		}

        [HttpPost]
        public IActionResult EditCard(FlashcardViewModel flashcardViewModel)
		{
            var newCard = new Flashcard
            {
                Id = flashcardViewModel.Id,
                FrontText = flashcardViewModel.FrontText,
                BackText = flashcardViewModel.BackText,
                FlashcardFolderId = flashcardViewModel.FlashcardFolderId
            };
            var success = _flashcardRepository.UpdateFlashcard(newCard);
            if (success)
			{
                TempData["UserMessage"] = "Card Updated Successfully";
			}
			else
			{
                TempData["ErrorMessage"] = "We weren't able to update your card.  Please try again in a few minutes.";
			}
            return RedirectToAction("ViewCards", new { flashcardFolderId = flashcardViewModel.FlashcardFolderId });

        }
    }
}
