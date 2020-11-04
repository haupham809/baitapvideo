using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using MODEL;

namespace BUS
{
    public class userbus
    {
        private static userbus ins;

        public static userbus Ins
        {
            get
            {
                if (ins == null) ins = new userbus();
                return ins;
            }
        }
        private userbus() { }
        public void xem(DataGridView data)
        {
            data.DataSource = userdao.Ins.xem();


        }
        public bool them(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string id = row.Cells["id"].Value.ToString();
            string name = row.Cells["name"].Value.ToString();
            DateTime? Dob = (DateTime?)row.Cells["dateofbirth"].Value;
            string info = row.Cells["info"].Value.ToString();
            bool? sex = (bool?)row.Cells["sex"].Value;


            user use = new user(id, name, Dob, info, sex);
            return userdao.Ins.them(use);

        }
        public bool sua(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string id = row.Cells["id"].Value.ToString();
            string name = row.Cells["name"].Value.ToString();
            DateTime? Dob =(DateTime?) row.Cells["dateofbirth"].Value;
            string info = row.Cells["info"].Value.ToString();
            bool? sex =(bool?) row.Cells["sex"].Value;


            user use = new user(id,name,Dob,info,sex);
           return userdao.Ins.sua(id,use);

        }
        public bool xoa(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string id = row.Cells["id"].Value.ToString();
            return userdao.Ins.xoa(id);

        }
        public void tiemkiem(DataGridView data, string x)
        {
            data.DataSource = userdao.Ins.tiemkiem(x);

        }
    }
}
