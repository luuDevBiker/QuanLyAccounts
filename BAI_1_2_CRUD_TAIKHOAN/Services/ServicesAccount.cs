using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAI_1_2_CRUD_TAIKHOAN.IServices;

namespace BAI_1_2_CRUD_TAIKHOAN.Services
{
    class ServicesAccount : IServices.IServices
    {
        public ServicesAccount()
        {
        }

        public string addAccount<T>(T acc, List<T> lst)
        {
            lst.Add(acc);
            return "Thêm thành công";
        }

        public int findAccount(string acc, List<Account> lst)
        {
            return lst.FindIndex(x => x.Acc == acc);
        }

        public string removeAccount<T>(int index, List<T> lst)
        {
            lst.RemoveAt(index);
            return "Xóa thành công";
        }
    }
}
