using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketsatisotomasyonu.Class
{
    class VeriTabaniIslemleri : Baglanti
    {
        string connstring = "User Id = system;Password = 1234;Data Source = 192.168.1.32:1521/xe;";
        static OracleConnection conn;
       
        public OracleConnection BaglantiAc()
        {
            throw new NotImplementedException();
        }

        public void BaglantiKapat()
        {
            throw new NotImplementedException();
        }
    }
}
