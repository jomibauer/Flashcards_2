using System;
using System.Collections.Generic;
using System.Linq;
using Flashcards.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Flashcards.Models
{
	public class FlashcardRepository: IFlashcardRepository
	{
		private readonly AppDbContext _appDbContext;
		public FlashcardRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public Flashcard GetFlashcardById(string Id)
		{
			return _appDbContext.Flashcards.FirstOrDefault(f => f.Id == Id);
		}

		public void RemoveFlashcard(Flashcard flashcard)
		{
			_appDbContext.Flashcards.Remove(flashcard);
			_appDbContext.SaveChanges();
		}

		public bool UpdateFlashcard(Flashcard flashcard)
		{
			var targetCard = _appDbContext.Flashcards
				.FirstOrDefault(f => f.Id == flashcard.Id);

			if (targetCard != null)
			{ 
			
				targetCard.FrontText = flashcard.FrontText;
				targetCard.BackText = flashcard.BackText;
				_appDbContext.SaveChanges();
				return true;
			}
			return false;
		}
	}
}
