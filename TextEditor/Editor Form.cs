using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
	public partial class EditorForm : Form
	{
		string currentFilePath;

		public EditorForm()
		{
			InitializeComponent();
			currentFilePath = "";
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var window = new EditorForm();
			window.Show();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult fileDialog = openFileDialog1.ShowDialog();

			if (fileDialog == DialogResult.OK)
			{
				currentFilePath = openFileDialog1.FileName;

				try
				{
					textBox.Text = File.ReadAllText(currentFilePath);
					this.Text = Path.GetFileName(currentFilePath) + " - Text Edit";
				}
				catch (IOException)
				{

				}
			}
		}

		private bool fileHasChanged(string str)
		{
			return (File.ReadAllText(currentFilePath) == str);
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				// If no prexisting path
				if (currentFilePath == "")
				{
					DialogResult fileDialog = saveFileDialog1.ShowDialog();
					currentFilePath = saveFileDialog1.FileName;
				}

				if (currentFilePath != "")
					System.IO.File.WriteAllText(currentFilePath, textBox.Text);
			}
			catch (IOException)
			{
				// Check your privelage
			}

		}

		private void EditorForm_FormClosing_1(object sender, FormClosingEventArgs e)
		{
			try
			{
				if (textBox.Text.Length > 0 && currentFilePath == "" || !fileHasChanged(textBox.Text))
				{
					var result = MessageBox.Show(
						"New file has been modified, save changes?",
						"Warning",
						MessageBoxButtons.YesNoCancel,
						MessageBoxIcon.Warning);

					if (result == DialogResult.Yes)
					{
						saveToolStripMenuItem.PerformClick();

						if (textBox.Text.Length > 0 && currentFilePath == "" || fileHasChanged(textBox.Text))
							e.Cancel = true;
					}
					else if (result == DialogResult.Cancel)
					{
						// Cancel the close request
						e.Cancel = true;
					}
					else if (result == DialogResult.No)
					{
						// Exit
					}
				}
			}
			catch (Exception)
			{
				// Will catch exception if empty path and > 0
			}
		}

		private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var current = textBox.Font.Size + 4;
			textBox.Font = new Font(textBox.Font.FontFamily, current);
		}

		private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var current = textBox.Font.Size - 4;
			textBox.Font = new Font(textBox.Font.FontFamily, current);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void textBox_TextChanged(object sender, EventArgs e)
		{
			// Super inefficient, try loading only visible
			lineNumberBox.Text = "";

			for (int i = 0; i < textBox.Lines.Count(); i++)
			{
				lineNumberBox.Text += i + "\n";
			}
		}

		private void textBox_VScroll(object sender, EventArgs e)
		{
			// Scroll with other box
		}
	}
}
