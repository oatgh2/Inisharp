using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inisharp.WinApi
{
  internal static class Api
  {
    [DllImport("kernel32")]
    internal static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

    [DllImport("kernel32")]
    internal static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder reVal, int size, string filePath);  }
}
