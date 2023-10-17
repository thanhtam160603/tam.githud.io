using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using quanlyhoso;

namespace quanlyhoso
{
    public partial class FrmMain : Form
    {
        public DataTable dtHoso;
        public BinarySearchTree tree = new BinarySearchTree();

        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            dtHoso = createTable();
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

        ////////// CHECK DATA
        
        public bool checkDataADD_hoso()
        {
            if (string.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập Tên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtLuong.Text))
            {
                MessageBox.Show("Bạn chưa nhập Lương", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLuong.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSdt.Text))
            {
                MessageBox.Show("Bạn chưa nhập Số Điện Thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSdt.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDiachi.Text))
            {
                MessageBox.Show("Bạn chưa nhập Địa Chỉ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiachi.Focus();
                return false;
            }
            return true;
        }
        public bool checkDataFindbyname()
        {
            if (string.IsNullOrEmpty(txtFindbyname.Text))
            {
                MessageBox.Show("Bạn chưa nhập Tên cần tìm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFindbyname.Focus();
                return false;
            }
            return true;
        }
        public bool checkDataFindbyTime()
        {
            if (dateTimePicker_Min.Value>dateTimePicker_Max.Value)
            {
                MessageBox.Show("Bạn cần chỉnh lại mốc thời gian phù hợp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        ////////// EVENT CLICK
        
        private void btnThemhoso_Click(object sender, EventArgs e)////// THÊM HỒ SƠ
        {
            if (checkDataADD_hoso())
            {

                dtHoso.Rows.Add(txtTen.Text, txtLuong.Text, txtSdt.Text, txtDiachi.Text, dateTimePicker_Add.Value.ToString("g"));
                dataQuanlyhoso.DataSource = dtHoso;
                hoso hs = new hoso(txtTen.Text, txtLuong.Text, txtSdt.Text, txtDiachi.Text, dateTimePicker_Add.Value);
                tree.Insert(hs);
                txtSL.Text = Convert.ToString(tree.Count());
                txtTen.Clear();
                txtLuong.Clear();
                txtSdt.Clear();
                txtDiachi.Clear();
                dateTimePicker_Add.Value = DateTime.Now;
            }
        }
        private void btnFindbyname_Click(object sender, EventArgs e)//////// TÌM KIẾM HỒ SƠ BẰNG TÊN
        {
            if (checkDataFindbyname())
            {
                string Fname = txtFindbyname.Text;
                FormFind frm = new FormFind();
                
               
                List<hoso> hs = new List<hoso>();
                tree.Findname_TraverseInOrder(tree.Root, Fname,ref hs);
                if (hs.Count() == 0)
                {
                    MessageBox.Show("Không có hồ sơ cần tìm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frm.hoso_temp = hs;
                    frm.ShowDialog();
                }

            }
        }
        private void btnFindbytime_Click(object sender, EventArgs e)///////// TÌM KIẾM HỒ SƠ BẰNG THỜI GIAN
        {
            if (checkDataFindbyTime())
            {
                FormFind frm = new FormFind();
                List<hoso> hs = new List<hoso>();
                DateTime min = dateTimePicker_Min.Value;
                DateTime max = dateTimePicker_Max.Value;

                tree.Finddistance_TraverseInOrder(tree.Root, min, max, ref hs);
                if (hs.Count() == 0)
                {
                    MessageBox.Show("Không có hồ sơ cần tìm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frm.hoso_temp = hs;
                    frm.ShowDialog();
                }

            }
        }

        //////////////BinarySearchTree

        public class Node
        {
            public Node LeftNode { get; set; }
            public Node RightNode { get; set; }
            public hoso Data { get; set; }
        }
        public class BinarySearchTree
        {
            public Node Root { get; set; }
        ////////////// HÀM INSERT DỮ LIỆU VÀO TREE
            public bool Insert(hoso value)
            {
                Node before = null, after = this.Root;
                while (after != null)
                {
                    before = after;
                    if (value.datetime <= after.Data.datetime)
                        after = after.LeftNode;
                    else if (value.datetime > after.Data.datetime)
                        after = after.RightNode;
                    else
                        return false;
                }
                Node newNode = new Node();
                newNode.Data = value;
                if (this.Root == null)
                    this.Root = newNode;
                else
                {
                    if (value.datetime <= before.Data.datetime)
                        before.LeftNode = newNode;
                    else
                        before.RightNode = newNode;
                }
                return true;
            }
        ///////////// HÀM TÌM KIẾM THEO TÊN
            public void Findname_TraverseInOrder(Node parent, string ten,ref List<hoso> hs)
            {

                if (parent != null)
                {
                    Findname_TraverseInOrder(parent.LeftNode, ten, ref hs);
                    if (parent.Data.ten.ToLower().Contains(ten.ToLower()))    hs.Add(parent.Data);
                    Findname_TraverseInOrder(parent.RightNode, ten, ref hs);
                }
            }
        ///////////////// HÀM TÌM KIẾM THEO THỜI GIAN
            public void Finddistance_TraverseInOrder(Node parent, DateTime min, DateTime max, ref List<hoso> hs)
            {
                if (parent != null)
                {
                    Finddistance_TraverseInOrder(parent.LeftNode, min, max, ref  hs);
                    if (parent.Data.datetime >= min & parent.Data.datetime <= max) hs.Add(parent.Data);
                    Finddistance_TraverseInOrder(parent.RightNode, min, max, ref  hs);
                }
            }
            public int Count(Node parent)
            {
                if (parent == null)
                    return 0;
                else
                    return 1 + Count(parent.LeftNode) + Count(parent.RightNode);
            }
            public int Count()
            {
                return Count(Root);
            }
        }

         ////////////// HÀM TẠO RANDOM HỒ SƠ
        private void buttonAddrandom_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            txtTen.Text = Convert.ToString((char)rd.Next(65, 90));
            txtLuong.Text = Convert.ToString(rd.Next(1,9)*5000000);
            txtSdt.Text = Convert.ToString(rd.Next(100000000,999999999));
            txtDiachi.Text = Convert.ToString((char)rd.Next(97, 122));
            dateTimePicker_Add.Value = new DateTime(rd.Next(2019, 2023), rd.Next(1, 13), rd.Next(1, 29),rd.Next(1,24),rd.Next(1,60),rd.Next(1,60));
            dtHoso.Rows.Add(txtTen.Text, txtLuong.Text, txtSdt.Text, txtDiachi.Text, dateTimePicker_Add.Value.ToString("g"));
            dataQuanlyhoso.DataSource = dtHoso;
            hoso hs = new hoso(txtTen.Text, txtLuong.Text, txtSdt.Text, txtDiachi.Text, dateTimePicker_Add.Value);
            tree.Insert(hs);
            txtSL.Text = Convert.ToString(tree.Count());
            txtTen.Clear();
            txtLuong.Clear();
            txtSdt.Clear();
            txtDiachi.Clear();
            dateTimePicker_Add.Value = DateTime.Now;
        }
    
    }
}
