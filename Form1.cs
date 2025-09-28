using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Homewoke_b4
{
    public partial class Form1 : Form
    {
        BindingList<Student> students = new BindingList<Student>();
        public BindingList<Student> GetStudents()
        {
            students.Add(new Student("1", "Nguyen Van A", "Nam", 8.5f, "CNTT"));
            students.Add(new Student("2", "Tran Thi B", "Nu", 7.0f, "QTKD"));
            students.Add(new Student("3", "Le Van C", "Nam", 9.0f, "CNTT"));
            students.Add(new Student("4", "Pham Thi D", "Nu", 6.5f, "QTKD"));
            students.Add(new Student("5", "Hoang Van E", "Nam", 8.0f, "CNTT"));
            return students;
        }

        public Form1()
        {
            InitializeComponent();
            dtgStudents.DataSource = GetStudents();
            txtTongSVNam.Text = students.Count(s => s.sex == "Nam").ToString();
            txtTongSVNu.Text = students.Count(s => s.sex == "Nu").ToString();

        }

        private void btbThemSua_Click(object sender, EventArgs e)
        {
            if (dtgStudents.SelectedRows.Count > 0)
            {
                var student = students[dtgStudents.CurrentRow.Index];
                student.id = txtMSV.Text;
                student.name = txtHoTen.Text;
                student.sex = radNam.Checked ? "Nam" : "Nu";
                student.score = float.Parse(txtDiemTB.Text);
                student.faculty = cbbNganh.Text;
                MessageBox.Show("Đã sửa thông tin sinh viên thành công", "Thông báo");
            }
            else
            {
                students.Add(new Student(txtMSV.Text, txtHoTen.Text, radNam.Checked ? "Nam" : "Nu", float.Parse(txtDiemTB.Text), cbbNganh.Text));
                txtTongSVNam.Text = students.Count(s => s.sex == "Nam").ToString();
                txtTongSVNu.Text = students.Count(s => s.sex == "Nu").ToString();
                MessageBox.Show("Đã thêm thông tin sinh viên thành công", "Thông báo");
            }
            dtgStudents.ClearSelection();
            txtMSV.Clear();
            txtDiemTB.Clear();
            txtHoTen.Clear();
            radNam.Checked = false;
            radNu.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgStudents.ClearSelection();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dtgStudents.CurrentRow != null)
            {
                students.RemoveAt(dtgStudents.CurrentRow.Index);
                txtTongSVNam.Text = students.Count(s => s.sex == "Nam").ToString();
                txtTongSVNu.Text = students.Count(s => s.sex == "Nu").ToString();
            }
        }

        private void dtgStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMSV.Text = students[dtgStudents.CurrentRow.Index].id;
            txtHoTen.Text = students[dtgStudents.CurrentRow.Index].name;
            if (students[dtgStudents.CurrentRow.Index].sex == "Nam")
                radNam.Checked = true;
            else
                radNu.Checked = true;
            txtDiemTB.Text = students[dtgStudents.CurrentRow.Index].score.ToString();
            cbbNganh.Text = students[dtgStudents.CurrentRow.Index].faculty;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;

        }
    }
}
