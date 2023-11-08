using Common;
using System;
using System.IO;
using System.Reflection;
using Utils;

namespace BillingSystem.Common
{
    public class MyIniFile: IniFile
    {

        public MyIniFile() : base("")
        {
            Uri codeBase = new Uri(Assembly.GetExecutingAssembly().CodeBase);
            string path = Path.GetDirectoryName(codeBase.LocalPath) + "/" + ConstCommon.INI_PATH;
            FilePath = path;
        }
    }
}
