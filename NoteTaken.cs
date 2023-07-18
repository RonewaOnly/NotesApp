using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp
{
	public class NoteTaken
	{
		public string noteTitle { get; set; }
		public string noteDescription { get; set; }

		public NoteTaken() { }
		public NoteTaken(string noteTitle, string noteDescription)
		{
			this.noteTitle = noteTitle;
			this.noteDescription = noteDescription;
		}
	}
}
