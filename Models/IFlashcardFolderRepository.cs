using System;
using System.Collections.Generic;
using Flashcards.Models.Entities;

namespace Flashcards.Models
{
	public interface IFlashcardFolderRepository
	{
		FlashcardFolder GetFolderById(string id);
		List<Flashcard> GetFlashcards(string id);
		bool AddFlashcard(Flashcard flashcard);
		bool UpdateFolder(FlashcardFolder folder);
		bool CreateFolder(FlashcardFolder folder);
	}
}
