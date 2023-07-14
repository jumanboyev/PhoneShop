using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop.Service.Commons.Helpers;

public class MediaHelper
{
    public static string MakeImageName(string filename)
    {
        FileInfo fileInfo = new FileInfo(filename);
        string exseption = fileInfo.Extension;
        string name = "IMG_" + Guid.NewGuid() + exseption;
        return name;
    }
}
