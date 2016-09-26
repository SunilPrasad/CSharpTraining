using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CodeAccessSecurityC
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeAccessPermission perm = new FileIOPermission(FileIOPermissionAccess.AllAccess, "c:/temp/xyz.txt");
            perm.Deny();

            try
            {
                StreamReader objW = File.OpenText(@"c:/temp/xyz.txt");
                CodeAccessPermission.RevertDeny();
                objW = null;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}
