using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{

  //  public delegate void FileDownloadCompleted(int time);

    class Program
    {   

        static void Main(string[] args)
        {
            Action<int> fileCompl = new Action<int>(OnDownlodCompleted);

          //  FileDownloadCompleted fileCompl = new FileDownloadCompleted(OnDownlodCompleted);

            fileCompl += OnDownlodCompleted;

            fileCompl -= OnDownlodCompleted;

            DownloadHelper downloadHelper = new DownloadHelper();

            downloadHelper.DownloadFileAsync("test.txt", fileCompl);

        //    Console.WriteLine("Hello");


        }

        private static void OnDownlodCompleted(int i)
        {
            Console.WriteLine(i);
        }

        private static void WaitCallBackCompleted(int i)
        {
            Console.WriteLine(i);
        }

    }

    public class DownloadHelper
    {

        public void DownloadFileAsync(string fileName, Action<int> onDownloadCompleted)        
        {



            onDownloadCompleted(1000);

        }
    }
   
}
