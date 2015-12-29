using System;
using System.Windows;
using ChiliDomain.DbObjects;
using NoweChili.View;

namespace NoweChili.Models
{
    public class LoggedUser
    {
        public string loggedDbUserName { get; set; }
        public DateTime LogedDateTime { get; set; }

        public LoggedUser()
        {           
        }
        public LoggedUser(UserDbObject loggedDbUser, DateTime loggedDateTime)
        {
            this.loggedDbUserName = loggedDbUser.UserName;
            this.LogedDateTime = loggedDateTime.Date;
        }

        public void Logout(Window window)
        {
            loggedDbUserName = String.Empty;
            LogedDateTime = DateTime.Now;
            var LoginView = new LoginPanel();
            LoginView.Show();
            window.Close();
        }
    }
}
