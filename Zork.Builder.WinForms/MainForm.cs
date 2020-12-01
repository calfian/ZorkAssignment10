using System;
using System.Reflection;
using System.Windows.Forms;

namespace Zork.Builder.WinForms
{
    public partial class MainForm : Form
    {
        private string AssemblyTitle => Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>()?.Title;

        public MainForm()
        {
            InitializeComponent();
            InitializeViewModels();
        }

        private void InitializeViewModels()
        {
            mGameViewModel = new GameViewModel();
            gameView.ViewModel = mGameViewModel;
            mGameViewModel.PropertyChanged += mGameViewModel_PropertyChanged;
            worldView.ViewModel = mGameViewModel;
        }

        private void mGameViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "IsModified")
            {
                isModifiedToolStripStatusLabel.Text = mGameViewModel.IsModified ? "Yes" : "No";
            }
        }

        private void OpenWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mGameViewModel.IsModified)
            {
                DialogResult result = MessageBox.Show("Save modified world?", AssemblyTitle, MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SaveWorld();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Zork files (*.json)|*.json";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                OpenWorld(dialog.FileName);
            }
        }

        private void NewWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mGameViewModel.IsModified)
            {
                DialogResult result = MessageBox.Show("Save modified world?", AssemblyTitle, MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SaveWorld();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            mGameViewModel.Game = new Game();
            mGameViewModel.Game.World = new World();
            mGameViewModel.IsModified = true;
            worldView.UpdateListBoxDataSource();
            UpdateTitle();
        }

        private void SaveWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mGameViewModel.FullPath))
            {
                saveWorldAsToolStripMenuItem.PerformClick();
            }
            else
            {
                SaveWorld();
                UpdateTitle();
            }
        }

        private void SaveWorldAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Zork files (*.json)|*.json";
            dialog.Title = "Save World As";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                mGameViewModel.FullPath = dialog.FileName;
                SaveWorld();
                UpdateTitle();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mGameViewModel.IsModified)
            {
                DialogResult result = MessageBox.Show("Save modified world?", AssemblyTitle, MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SaveWorld();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void OpenWorld(string filename)
        {
            Assert.ArgumentIsNotNull(filename, nameof(filename));

            try
            {
                Cursor = Cursors.WaitCursor;

                mGameViewModel.Game = Game.Load(filename);
                mGameViewModel.FullPath = filename;
                mGameViewModel.IsModified = false;
                worldView.UpdateListBoxDataSource();
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, "Error Opening World");
                CloseWorld();
            }
        }

        private void CloseWorld()
        {
            mGameViewModel.Game = null;
            mGameViewModel.FullPath = null;
            mGameViewModel.IsModified = false;
        }

        private void SaveWorld()
        {
            Assert.IsTrue(!string.IsNullOrEmpty(mGameViewModel.FullPath));

            mGameViewModel.Game.Save(mGameViewModel.FullPath);
            mGameViewModel.IsModified = false;
        }

        private void UpdateTitle() => Text = $"{AssemblyTitle} - {mGameViewModel.Filename}";

        private GameViewModel mGameViewModel;
    }
}
