    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        private static MailManager mailManager;
        static void Main(string[] args)
        {
            mailManager = new MailManager();

            Test();

            //  GC.Collect(0);

            Console.ReadLine();
        }

        static void Test()
        {
            Fax fax = new Fax(mailManager);

            fax.Unregister(mailManager);
            // mailManager = null;

            //GC.Collect(0);

        }
    }

    public class MailManager
    {
        public event EventHandler NewMailArrived;

        public MailManager()
        {
            Console.WriteLine("Object constructed");
        }

        ~MailManager()
        {
            Console.WriteLine("Object destryoed");

        }
    }

public class Fax
{
    public Fax(MailManager mainManager)
    {
        Console.WriteLine("fax constructed");
        mainManager.NewMailArrived += mainManager_NewMailArrived;
    }

    void mainManager_NewMailArrived(object sender, EventArgs e)
    {

    }

    ~Fax()
    {
        Console.WriteLine("fax destroyed");
    }

    public void Unregister(MailManager mainManager)
    {
        mainManager.NewMailArrived -= mainManager_NewMailArrived;
    }
}

