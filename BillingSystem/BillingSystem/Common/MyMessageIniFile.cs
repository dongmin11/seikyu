using Common;
using System;
using System.IO;
using System.Reflection;
using Utils;

namespace BillingSystem.Common
{
    public class MyMessageIniFile : IniFile
    {

        public MyMessageIniFile() : base("")
        {
            Uri codeBase = new Uri(Assembly.GetExecutingAssembly().CodeBase);
            string path = Path.GetDirectoryName(codeBase.LocalPath) + "/" + ConstCommon.INI_PATH_MSG;
            FilePath = path;
        }
    }
}
