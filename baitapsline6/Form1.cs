using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace baitapsline6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       
        private void btn_xem_Click(object sender, EventArgs e)
        {
            userbus.Ins.xem(dgv);

        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (userbus.Ins.them(dgv))
            {
                MessageBox.Show("Thêm thành công!");
                btn_xem_Click(sender, e);
            }
            else MessageBox.Show("loi!");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (userbus.Ins.sua(dgv))
            {
                MessageBox.Show("sửa thành công!");
                btn_xem_Click(sender, e);
            }
            else MessageBox.Show("loi!");

        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (userbus.Ins.xoa(dgv))
            {
                MessageBox.Show("Xóa thành công!");
                btn_xem_Click(sender, e);
            }
            else MessageBox.Show("loi!");
        }
        private void btn_tim_Click(object sender, EventArgs e)
        {
            userbus.Ins.tiemkiem(dgv, txt_tim.Text.ToString());

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv.SelectedCells[0].OwningRow;
            DateTime? Dob = (DateTime?)row.Cells["dateofbirth"].Value;
            bool? sex = (bool?)row.Cells["sex"].Value;
            if (sex == true)
            {
                cmb.SelectedIndex = 0;
            }
            else if (sex == false)
            {
                cmb.SelectedIndex = 1;
            }
            dtp.Value = Convert.ToDateTime(Dob);



        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv.SelectedCells[0].OwningRow;
            row.Cells["sex"].Value=cmb.Text.ToString();

        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv.SelectedCells[0].OwningRow;
            row.Cells["dateofbirth"].Value = dtp.Text.ToString();

        }
    }
}
