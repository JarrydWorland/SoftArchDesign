using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureProject
{
    internal class Staff
    {

        private string id;
        private string login;
        private string password;

        public Staff(String Id, String Login, String Password)
        {
            this.id = Id;
            this.login = Login;
            this.password = Password;
        }

        public string Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
    }
}
