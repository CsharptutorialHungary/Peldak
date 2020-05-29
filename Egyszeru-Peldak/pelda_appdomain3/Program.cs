using System;
using System.IO;
using System.Security;
using System.Security.Permissions;

namespace pelda_appdomain3
{
    public class Code : MarshalByRefObject
    {
        public void Greet()
        {
            Console.WriteLine("Hello from App domain: " + AppDomain.CurrentDomain.FriendlyName);
        }

        public void DoSomething()
        {
            try
            {
                var mappak = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var temp = Path.GetTempPath();

            PermissionSet permissions = new PermissionSet(PermissionState.None);
            permissions.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution)); //csak managed kód futtatása
            permissions.AddPermission(new FileIOPermission(FileIOPermissionAccess.Read, temp)); //csak fájlok olvasása
            permissions.AddPermission(new ReflectionPermission(PermissionState.None)); //nincs reflection

            AppDomain isolated = AppDomain.CreateDomain("isolated", 
                                                        AppDomain.CurrentDomain.Evidence,
                                                        AppDomain.CurrentDomain.SetupInformation, 
                                                        permissions);
            Type codeType = typeof(Code);

            Code peldany = (Code)isolated.CreateInstanceAndUnwrap(codeType.Assembly.FullName, codeType.FullName);

            peldany.Greet();

            //Jogok hiányában kivétel
            peldany.DoSomething();

            AppDomain.Unload(isolated);

            Console.ReadKey();
        }
    }
}
