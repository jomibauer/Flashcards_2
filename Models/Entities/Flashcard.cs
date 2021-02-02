using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flashcards.Models.Entities
{
	public class Flashcard
	{
		public Flashcard()
		{
		}
		public string Id { get; set; }
		public string FrontText { get; set; }
		public string BackText { get; set; }

		[ForeignKey("FlashcardFolder")]
		public string FlashcardFolderId { get; set; }
		public FlashcardFolder flashcardFolder { get; set; }
	}
}
