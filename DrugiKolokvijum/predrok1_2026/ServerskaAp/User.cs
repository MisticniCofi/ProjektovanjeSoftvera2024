using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerskaAp
{
    internal class User : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;
        public User(string username, bool ulogovan)
        {
            Username = username;
            Ulogovan = ulogovan;
        }

        public String Username { get; set; PropertyChanged }

        public bool Ulogovan { get; set; }
    }
}
