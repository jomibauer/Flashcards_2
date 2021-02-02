using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flashcards.Models.Entities
{
	public class FlashcardFolder
	{
		public FlashcardFolder()
		{
		}
		public string Id { get; set; }
		public string FolderName { get; set; }
		public string Description { get; set; }
		public string Subject { get; set; }
		public List<Flashcard> Flashcards { get; set; }
	}
}
