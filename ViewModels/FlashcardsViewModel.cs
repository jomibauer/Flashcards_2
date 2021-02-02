using System;
using System.Collections.Generic;
using Flashcards.Models.Entities;

namespace Flashcards.ViewModels
{
	public class FlashcardsViewModel
	{
		public FlashcardsViewModel()
		{
		}
		public string FolderName { get; set; }
		public string FlashcardFolderId { get; set; }
		public List<Flashcard> CurrentStack { get; set; }
		public List<Flashcard> ReviewStack { get; set; }

	}
}
