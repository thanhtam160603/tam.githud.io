using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyhoso
{
    public partial class FormFind : Form
    {
        public List<hoso> hoso_temp;
        public FormFind()
        {
            InitializeComponent();
            Findhoso = createTable();
        }
        public DataTable Findhoso;
        private void FormFind_Load(object sender, EventArgs e)
        {
            foreach (hoso item in hoso_temp)
            {
                Findhoso.Rows.Add(item.ten, item.luong, item.sdt, item.diachi, item.datetime.ToString("g"));
                dataQuanlyhoso_Find.DataSource = Findhoso;
            }
        }
        public DataTable createTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Ten");
            dt.Columns.Add("Luong");
            dt.Columns.Add("Sdt");
            dt.Columns.Add("Diachi");
            dt.Columns.Add("Ngaythemhoso");
            return dt;
        }
    }
}
