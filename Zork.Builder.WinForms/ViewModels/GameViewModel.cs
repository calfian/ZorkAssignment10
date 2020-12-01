using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Zork.Builder.WinForms
{
    internal class GameViewModel : INotifyPropertyChanged
    {
        public Game Game
        {
            get => mGame;
            set
            {
                mGame = value;
                NotifyPropertyChanged();
            }
        }

        public List<Room> RoomsList => Game?.World?.Rooms?.ToList();

        public string FullPath
        {
            get => mFullPath;
            set
            {
                mFullPath = value;
                NotifyPropertyChanged();
            }
        }

        public string Filename => FullPath != null ? Path.GetFileName(FullPath) : "Untitled";

        public bool IsModified
        {
            get => isModified;
            set
            {
                isModified = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string mFullPath;
        private Game mGame;
        private bool isModified;
    }
}