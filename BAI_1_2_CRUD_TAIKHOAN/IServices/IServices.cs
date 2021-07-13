using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_2_CRUD_TAIKHOAN.IServices
{
    interface IServices
    {
        //add account
        string addAccount <T>(T acc , List<T> lst);
        //find account
        int findAccount(string acc , List<Account> lst);
        //remove account
        string removeAccount<T>(int index , List<T> lst);
    }
}
