using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Inisharp.WinApi;
namespace Inisharp.Ini
{
  public class Ini
  {
    private string _iniPath;

    public Ini(string iniPath)
    {
      _iniPath = iniPath;
      _verifyFile();
    }

    void _verifyFile()
    {
      if (!File.Exists(_iniPath))
        throw new FileNotFoundException(string.Format("{0} not found", _iniPath));
    }

    public string ReadValue(string section, string key)
    {
      StringBuilder temp = new StringBuilder(0xff);
      int i = Api.GetPrivateProfileString(section, key, "", temp, 0xff, this._iniPath);
      return temp.ToString();
    }

    public void WriteValue(string section, string key, string value)
    {
      Api.WritePrivateProfileString(section, key, value, this._iniPath);
    }
  }
}
