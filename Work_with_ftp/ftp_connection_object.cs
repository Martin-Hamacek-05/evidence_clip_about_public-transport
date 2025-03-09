using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace evidence_clip_about_public_transport.Work_with_ftp
{
    public class ftp_connection_object
    {
        private string server;
        private NetworkCredential user_login;

        public ftp_connection_object(string server, NetworkCredential user_login)
        {
            this.Server = server;
            this.User_login = user_login;
        }

        public string Server { get => server; set => server = value; }
        public NetworkCredential User_login { get => user_login; set => user_login = value; }
    }
}
