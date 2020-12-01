using System.Windows.Forms;

namespace Zork.Builder.WinForms
{
    internal partial class WorldView : UserControl
    {
        public GameViewModel ViewModel
        {
            get => mViewModel;
            set
            {
                mViewModel = value;
                if (value != null)
                {
                    gameViewModelBindingSource.DataSource = ViewModel;
                    roomsListBox.DataSource = ViewModel.RoomsList;
                }
            }
        }

        public void UpdateListBoxDataSource()
        {
            roomsListBox.DataSource = ViewModel.RoomsList;
        }

        public WorldView()
        {
            InitializeComponent();
        }

        private GameViewModel mViewModel;
    }
}
