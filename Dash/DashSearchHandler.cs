using System;
using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;
using MonoDevelop.Ide.Gui;   
using Mono.TextEditor;

namespace Dash
{
	public class DashSearchHandler : CommandHandler
	{
		protected override void Run ()
		{
			Document doc = IdeApp.Workbench.ActiveDocument;
			var textEditorData = doc.GetContent<ITextEditorDataProvider> ().GetTextEditorData ();  

			Console.WriteLine (	textEditorData.SelectedText);

			System.Diagnostics.Process.Start (string.Format ("dash://{0}:{1}", "Mono", textEditorData.SelectedText));
		}

		protected override void Update (CommandInfo info)
		{
			Document doc = IdeApp.Workbench.ActiveDocument;  
			info.Enabled = doc != null && doc.GetContent<ITextEditorDataProvider> () != null;  
		}  
	}
}

