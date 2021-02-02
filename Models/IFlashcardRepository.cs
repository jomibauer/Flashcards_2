using System;
using System.Collections.Generic;
using Flashcards.Models.Entities;

namespace Flashcards.Models
{
	public interface IFlashcardRepository
	{
		public Flashcard GetFlashcardById(string Id);
		public void RemoveFlashcard(Flashcard flashcard);
		public bool UpdateFlashcard(Flashcard flashcard);
	}
}
