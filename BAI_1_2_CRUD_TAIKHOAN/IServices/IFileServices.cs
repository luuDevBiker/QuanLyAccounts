using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_2_CRUD_TAIKHOAN.IServices
{
    interface IFileServices
    {
        // mở file
        List<T> openList<T>(string path);
        // save file
        List<T> saveList<T>(string path, List<T> lst);
    }
}
