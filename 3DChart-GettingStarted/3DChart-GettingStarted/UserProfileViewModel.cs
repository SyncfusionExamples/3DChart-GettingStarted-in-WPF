using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_3DCharts
{
    public class UsersViewModel
    {
        public UsersViewModel()
        {
            this.UsersList = new ObservableCollection<UserProfile>();

            DateTime date = DateTime.Today;

            UsersList.Add(new UserProfile { TimeStamp = date.AddHours(0.5), NoOfUsers = 1000 });
            UsersList.Add(new UserProfile { TimeStamp = date.AddHours(1), NoOfUsers = 5000 });
            UsersList.Add(new UserProfile { TimeStamp = date.AddHours(1.5), NoOfUsers = 3000 });
            UsersList.Add(new UserProfile { TimeStamp = date.AddHours(2), NoOfUsers = 4000 });
            UsersList.Add(new UserProfile { TimeStamp = date.AddHours(2.5), NoOfUsers = 2000 });
            UsersList.Add(new UserProfile { TimeStamp = date.AddHours(3), NoOfUsers = 1000 });
        }
        public ObservableCollection<UserProfile> UsersList { get; set; }

    }
}
