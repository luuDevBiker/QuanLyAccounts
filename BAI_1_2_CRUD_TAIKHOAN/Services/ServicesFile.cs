using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAI_1_2_CRUD_TAIKHOAN.IServices;

namespace BAI_1_2_CRUD_TAIKHOAN.Services
{
    class ServicesFile : IFileServices
    {
        List<Account> _lstAccounts = new List<Account>();
        private string path = @"C:\Users\le van luu\Documents\C#3\frm1_buoi1\BAI_1_2_CRUD_TAIKHOAN\DATA\FileDataAccount.bin";
        private FileStream _fs;
        private BinaryFormatter _bf;

        public ServicesFile()
        {
            _lstAccounts = new List<Account>();
        }
        public List<T> openList<T>(string path)
        {
            try
            {
                _fs = new FileStream(path, FileMode.Open);
                _bf = new BinaryFormatter();
                var data = _bf.Deserialize(_fs);
                List<T> _lst = (List<T>)data;
                _fs.Close();
                return _lst;
            }
            catch (Exception e)
            {
                _fs.Close();
                MessageBox.Show(e.ToString());
                return null;
            }
        }

        public List<T> saveList<T>(string path, List<T> lst)
        {
            try
            {
                _fs = new FileStream(path, FileMode.Create);
                _bf = new BinaryFormatter();
                _bf.Serialize(_fs, lst);
                _fs.Close();
                MessageBox.Show("Lưu file thành công.");
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                _fs.Close();
                return null;
            }
        }
    }
}
