using System;
using System.Collections.Generic;
using Flashcards.Models.Entities;

namespace Flashcards.ViewModels
{
	public class FlashcardFolderInfoViewModel
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string Subject { get; set; }
		public string FlashcardFolderId { get; set; }
	}
}
