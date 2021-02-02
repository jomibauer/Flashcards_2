using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace Flashcards.Models
{
	public class ApplicationUser : IdentityUser
	{
		public List<string> FlashcardFolderIds { get; set; } = new List<string>();
	}
}
