using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShotTrackVM.Models
{
    public class UserModel : INotifyPropertyChanged
    {
        //User Class for personalized User experience within App

        private string _username;
        private string _password;
        private int _highscore;

        public string Username
        {
            get; set;
        }

        public string Password
        {
            get; set;
        }

        public int Highscore
        {
            get; set;
        }

        public event PropertyChangedEventHandler PropChange;

        //Ensure View is notified when properties are changed

        protected virtual void OnPropertyChange(string propName)
        {
            PropChange?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
