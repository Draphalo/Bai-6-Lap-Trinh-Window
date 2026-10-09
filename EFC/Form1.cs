using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Drawing;

namespace EFC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            Addbtn.Click += btnThem_Click;
            Editbtn.Click += btnSua_Click;
            Deletebtn.Click += btnXoa_Click;
            Sortbtn.Click += btnLocDat_Click;
            Updatebtn.Click += btnTaiLai_Click;
            dataGridView1.SelectionChanged += dgvSinhVien_SelectionChanged;
        }

        private async void Form1_Load(object? sender, EventArgs e)
        {
            await TaiDanhSach();
        }

        private async Task TaiDanhSach()
        {
            try
            {
                using var context = new AppDbContext();
                List<Student> danhSach = await context.Students
                    .AsNoTracking()
                    .ToListAsync();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = danhSach;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không tải được danh sách sinh viên: {ex.Message}");
            }
        }

        private async void btnTaiLai_Click(object? sender, EventArgs e)
        {
            await TaiDanhSach();
        }

        private void dgvSinhVien_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Student student)
            {
                textBox1.Text = student.FullName;
                textBox2.Text = student.Grade.ToString();
            }
        }

        private async void btnThem_Click(object? sender, EventArgs e)
        {
            if (!TryReadInput(out string fullName, out double grade))
            {
                return;
            }

            try
            {
                using var context = new AppDbContext();
                context.Students.Add(new Student { FullName = fullName, Grade = grade });
                await context.SaveChangesAsync();

                textBox1.Clear();
                textBox2.Clear();
                await TaiDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thêm được sinh viên: {ex.Message}");
            }
        }

        private async void btnSua_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is not Student selectedStudent)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!");
                return;
            }

            if (!TryReadInput(out string fullName, out double grade))
            {
                return;
            }

            try
            {
                using var context = new AppDbContext();
                Student? student = await context.Students.FindAsync(selectedStudent.Id);
                if (student is null)
                {
                    MessageBox.Show("Không tìm thấy sinh viên cần sửa.");
                    return;
                }

                student.FullName = fullName;
                student.Grade = grade;
                await context.SaveChangesAsync();
                await TaiDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không cập nhật được sinh viên: {ex.Message}");
            }
        }

        private async void btnXoa_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is not Student selectedStudent)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa \"{selectedStudent.FullName}\"?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using var context = new AppDbContext();
                Student? student = await context.Students.FindAsync(selectedStudent.Id);
                if (student is not null)
                {
                    context.Students.Remove(student);
                    await context.SaveChangesAsync();
                }

                textBox1.Clear();
                textBox2.Clear();
                await TaiDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không xóa được sinh viên: {ex.Message}");
            }
        }

        private async void btnLocDat_Click(object? sender, EventArgs e)
        {
            try
            {
                using var context = new AppDbContext();
                List<Student> passedStudents = await context.Students
                    .AsNoTracking()
                    .Where(student => student.Grade >= 5)
                    .OrderByDescending(student => student.Grade)
                    .ToListAsync();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = passedStudents;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không lọc được danh sách sinh viên: {ex.Message}");
            }
        }

        private bool TryReadInput(out string fullName, out double grade)
        {
            fullName = textBox1.Text.Trim();
            grade = 0;

            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                return false;
            }

            if (!double.TryParse(textBox2.Text, out grade))
            {
                MessageBox.Show("Điểm không hợp lệ!");
                return false;
            }

            return true;
        }
    }
}
