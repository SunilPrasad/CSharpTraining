using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {

        public static DateTime Created { get; set; } = DateTime.Now;

        public override string ToString() => string.Format("{0}, {1}", "First", "Second");


        static void Main(string[] args)
        {
            MailManager mailManager = new MailManager();

            Fax fax = new Fax(mailManager);
            Mobile mobile = new Mobile(mailManager);

            mailManager.SimulateNewMail("SUnil", "Sunil", "Test");

        }

       
    }


    public class MailManager
    {
        public event EventHandler<EmailEventArgs> OnNewMailArrived;

        public void SimulateNewMail(string to,string from,string sub)
        {
            OnNewMailArrived?.Invoke(this, new EmailEventArgs(to,@from,sub));
        }

    }

    public class Fax
    {
        private MailManager _mailManager;

        public Fax(MailManager mailManager)
        {
            _mailManager = mailManager;
            _mailManager.OnNewMailArrived += _mailManager_OnNewMailArrived;

        }

        private void _mailManager_OnNewMailArrived(object sender, EmailEventArgs e)
        {
            Console.WriteLine(e.From+e.To+e.Subject);

            Console.WriteLine("Fax Received Email");
        }
    }

    public class Mobile
    {
        private MailManager _mailManager;

        public Mobile(MailManager mailManager)
        {
            _mailManager = mailManager;
            _mailManager.OnNewMailArrived += _mailManager_OnNewMailArrived;

        }

        private void _mailManager_OnNewMailArrived(object sender, EmailEventArgs e)
        {
            Console.WriteLine("Mobile Received Email");
        }

        public void UnRegisterEmailNotification()
        {
            _mailManager.OnNewMailArrived -= _mailManager_OnNewMailArrived;
        }
    }

    public class EmailEventArgs : EventArgs
    {
        
        public EmailEventArgs(string to , string from,string sub)
        {
            From = from;
            To = to;
            Subject = sub;
        }

        public string From { get; }
        public string To { get; }
        public string Subject { get; }
    }

}
