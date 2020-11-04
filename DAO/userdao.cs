using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODEL;

namespace DAO
{
    public class userdao
    {
        private static userdao ins;

        public static userdao Ins {
            get
            {
                if (ins == null) ins = new userdao();
                return ins;
            } }
        private userdao() { }
        public List<user> xem()
        {
            List<user> users = new List<user>();
            string query = "select * from users";
            DataTable data= DataProvider.Ins.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                string id =item["id"].ToString();
                string name = item["name"].ToString();
                DateTime? Dob = item["dateofbirth"].ToString()==string.Empty?null:(DateTime?) item["dateofbirth"];
                string info = item["info"].ToString();
                bool? sex= item["sex"].ToString()==string.Empty?null:(bool?)item["sex"];
                user use = new user(id, name, Dob, info, sex);
                users.Add(use);


            }
            user use1 = new user();
            users.Add(use1);
            return users;
        }
        public bool them( user use)
        {
            string query = "insert into users values ( @id , @name , @info , @dateofbirth  , @sex  )";
            object[] para = new object[] { use.Id,use.Name, use.Info, use.Dateofbirth, use.Sex};
            if (DataProvider.Ins.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        public bool sua(string id,user use)
        {
            string query = "update users set  name = @name , dateofbirth = @dateofbirth , info = @info , sex = @sex  where id = @id";
            object[] para = new object[] {use.Name,use.Dateofbirth,use.Info,use.Sex ,id};
            if(DataProvider.Ins.ExecuteNonQuery(query,para)>0)
           {
                return true;
           }
            return false;
        }
        public bool xoa(string id)
        {
            string query = "delete users  where id = @id";
            object[] para = new object[] { id };
            if (DataProvider.Ins.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }

        public List<user> tiemkiem(string x)
        {
            List<user> users = new List<user>();

            string query = "select * from users where id = @id or name = @name or  info = @info ";
            object[] para = new object[] { x, x, x };
            DataTable data = DataProvider.Ins.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string name = item["name"].ToString();
                DateTime? Dob = item["dateofbirth"].ToString() == string.Empty ? null : (DateTime?)item["dateofbirth"];
                string info = item["info"].ToString();
                bool? sex = item["sex"].ToString() == string.Empty ? null : (bool?)item["sex"];
                user use = new user(id, name, Dob, info, sex);
                users.Add(use);

            }
            return users;
        }



    }
}
