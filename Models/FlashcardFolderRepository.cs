using System;
using System.Collections.Generic;
using System.Linq;
using Flashcards.Models.Entities;

namespace Flashcards.Models
{
	public class FlashcardFolderRepository: IFlashcardFolderRepository
	{
		private readonly AppDbContext _appDbContext;
		public FlashcardFolderRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
			
		}

		public FlashcardFolder GetFolderById(string id)
		{
			return _appDbContext.FlashcardFolders
				.FirstOrDefault(f => f.Id == id);
		}

		public List<Flashcard> GetFlashcards(string id)
		{
			return  _appDbContext.Flashcards.Where(f => f.FlashcardFolderId == id).ToList<Flashcard>();
		}

		public bool UpdateFolder (FlashcardFolder folder)
		{
			var targetFolder = _appDbContext.FlashcardFolders
				.FirstOrDefault(f => f.Id == folder.Id);
			if (targetFolder != null)
			{
				targetFolder.FolderName = folder.FolderName;
				targetFolder.Subject = folder.Subject;
				targetFolder.Description = folder.Description;
				_appDbContext.SaveChanges();
				return true;
			}
			return false;
		}

		public bool CreateFolder (FlashcardFolder folder)
		{
			var nullOrCollision = _appDbContext.FlashcardFolders
				.FirstOrDefault(f => f.Id == folder.Id);
			if (nullOrCollision == null)
			{
				var newFolder = new FlashcardFolder
				{
					FolderName = folder.FolderName,
					Subject = folder.Subject,
					Description = folder.Description,
					Id = folder.Id
				};
				_appDbContext.FlashcardFolders.Add(newFolder);
				
				_appDbContext.SaveChanges();
				return true;
			}
			return false;
		}

		public bool AddFlashcard (Flashcard flashcard)
		{
			var targetFolder = _appDbContext.FlashcardFolders
				.FirstOrDefault(f => f.Id == flashcard.FlashcardFolderId);

			if (targetFolder != null)
			{
				var newCard = new Flashcard
				{
					FrontText = flashcard.FrontText,
					BackText = flashcard.BackText,
					FlashcardFolderId = flashcard.FlashcardFolderId,
					Id = flashcard.Id
				};

				_appDbContext.Flashcards.Add(newCard);
				_appDbContext.SaveChanges();
				return true;
			}
			else
			{
				return false;
			}
		}

	}
}
