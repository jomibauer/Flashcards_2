using System;
using System.ComponentModel.DataAnnotations;

namespace Flashcards.ViewModels
{
	public class FlashcardViewModel
	{
		
		public string FolderName { get; set; }
		public string Id { get; set; }
		public string FlashcardFolderId { get; set; }
		[Required]
		public string FrontText { get; set; }
		[Required]
		public string BackText { get; set; }
	}
}
