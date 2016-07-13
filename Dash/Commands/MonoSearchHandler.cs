using Dash.Helpers;
using Mono.TextEditor;
using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;
using MonoDevelop.Ide.Gui;

namespace Dash.Commands
{
	public class MonoSearchHandler : CommandHandler
	{
		protected override void Run (object dataItem)
		{
			if (IdeApp.Workspace.IsOpen) {
				DashProcess.Start ("mono");
			}
		}
		protected override void Update (CommandInfo info)
		{
			Document doc = IdeApp.Workbench.ActiveDocument;
			info.Enabled = doc != null && doc.GetContent<ITextEditorDataProvider> () != null;
		}
	}
}

