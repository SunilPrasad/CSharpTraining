using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample.cs
{
    class Program
    {
        //Stack is a collection type with Last-In-First-Out (LIFO) behaviour

        // Think of your browser.As you navigate to different web sites, these addresses that you visit are 
        //pushed on a stack. Then, when you click the back button, the item on the stack 
        //(which represents the current address in the browser) is popped and now we can get the 
        //last address you visited from the item on the stack.The undo feature in applications is implemented using a stack as well.


        static void Main(string[] args)
        {
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Browse("a.html");
            webBrowser.Browse("b.html");
            webBrowser.Browse("c.html");
            webBrowser.Browse("d.html");

            webBrowser.Back();
            webBrowser.Back();
            webBrowser.Back();


        }


        public class WebBrowser
        {
            private Stack<string> _webpageStack;
            private string _cussrentPage;

            public WebBrowser()
            {
                _webpageStack=new Stack<string>(10);
            }

            public void Browse(string url)
            {
                Console.WriteLine("Visting page {0} : ",url);
                _cussrentPage = url;
                _webpageStack.Push(url);
            }

            public void Back()
            {
                var page = _webpageStack.Pop();

                if (page.Equals(_cussrentPage))
                {
                    page = _webpageStack.Pop();
                }

                Console.WriteLine("Back to page {0}:",page);
            }
        }
    }
}
