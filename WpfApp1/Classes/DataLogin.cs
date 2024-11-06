using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{

    public struct Data
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }


    public class DataLogin
    {
        private List<Data> allData = new List<Data>();

        public List<Data> Data
        {
            get => allData;
            set
            {
                allData = value;
            }
        }

        public int Total => Data.Count;

        public Data ExistInDataBase(string _login, string _password)
        {
            Data _data = (from c in allData where c.Login == _login && c.Password == _password select c).FirstOrDefault();
            return _data;
        }
    }
}
