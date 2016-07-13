using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;
using MonoDevelop.Ide.Gui;   
using Mono.TextEditor;
using Dash.Helpers;

namespace Dash.Commands
{
	public class DashSearchHandler : CommandHandler
	{
		protected override void Run (object dataItem)
		{
			if (IdeApp.Workspace.IsOpen) {
				DashProcess.Start (string.Empty);
			}
		}

		protected override void Update (CommandInfo info)
		{
			Document doc = IdeApp.Workbench.ActiveDocument;  
			info.Enabled = doc != null && doc.GetContent<ITextEditorDataProvider> () != null;  
		}  
	}
}

