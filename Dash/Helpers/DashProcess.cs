using MonoDevelop.Ide;
using MonoDevelop.Ide.Gui;
using Mono.TextEditor;
using System.Diagnostics;

namespace Dash.Helpers
{
	public static class DashProcess
	{

		public static void Start(string keyword)
		{
			Document doc = IdeApp.Workbench.ActiveDocument;
			var textEditorData = doc.GetContent<ITextEditorDataProvider> ().GetTextEditorData ();

			if (!string.IsNullOrEmpty (textEditorData.SelectedText)) {
				Process.Start (string.Format ($"dash://{keyword}:{textEditorData.SelectedText}"));
			}
		}
	}
}

