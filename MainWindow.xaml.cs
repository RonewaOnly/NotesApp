using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NotesApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		List<NoteTaken> noted = new List<NoteTaken>();
		public string title="", comments = "";
		public MainWindow()
		{
			InitializeComponent();
		}

		private void btnClicked(object sender, RoutedEventArgs e)
		{
			if(NoteTitle.Text == string.Empty || CommentFill.Text == string.Empty)
			{
				MessageBox.Show("Fill in please", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			else
			{
				takeNotes();
			}
			NoteTitle.Text = string.Empty;
			CommentFill.Text = string.Empty;
		}

		public void takeNotes()
		{
			title = NoteTitle.Text;
			comments = CommentFill.Text;
			noted.Add(new NoteTaken(title, comments));
			DateTime dateTime = DateTime.Now;//Shows the current date and time

			foreach (var i in noted)
			{
				NoteSaved.Items.Add(i.noteTitle);
				NoteSaved.Items.Add(i.noteDescription);
				NoteSaved.Items.Add(dateTime);
			}
			noted.Clear();//this makes sure that no older information is display again
			//NoteSaved.Items.Add(noted);
		}
	}
}
