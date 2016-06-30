using System;

namespace HelloDocker
{
    public class HomeViewModel
    {
        public string MachineName {get;}
        public string GeneratedDateTime {get;}

        public HomeViewModel()
        {
            this.MachineName = Environment.MachineName;
            this.GeneratedDateTime = DateTime.Now.ToString();
        }
    }
}