namespace EFC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Addbtn = new Button();
            Editbtn = new Button();
            Deletebtn = new Button();
            Sortbtn = new Button();
            Updatebtn = new Button();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(76, 339);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(832, 336);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(219, 47);
            label1.Name = "label1";
            label1.Size = new Size(491, 38);
            label1.TabIndex = 2;
            label1.Text = "QUẢN LÝ SINH VIÊN - EF CORE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 139);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 3;
            label2.Text = "Họ tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(560, 139);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 4;
            label3.Text = "Điểm:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(202, 136);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(339, 31);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(624, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 31);
            textBox2.TabIndex = 6;
            // 
            // Addbtn
            // 
            Addbtn.ImageAlign = ContentAlignment.MiddleLeft;
            Addbtn.ImageIndex = 0;
            Addbtn.ImageList = imageList1;
            Addbtn.Location = new Point(76, 245);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(140, 47);
            Addbtn.TabIndex = 7;
            Addbtn.Text = "Thêm";
            Addbtn.UseVisualStyleBackColor = true;
            // 
            // Editbtn
            // 
            Editbtn.ImageAlign = ContentAlignment.MiddleLeft;
            Editbtn.ImageIndex = 2;
            Editbtn.ImageList = imageList1;
            Editbtn.Location = new Point(244, 245);
            Editbtn.Name = "Editbtn";
            Editbtn.Size = new Size(116, 47);
            Editbtn.TabIndex = 8;
            Editbtn.Text = "Sửa";
            Editbtn.UseVisualStyleBackColor = true;
            // 
            // Deletebtn
            // 
            Deletebtn.ImageAlign = ContentAlignment.MiddleLeft;
            Deletebtn.ImageKey = "bin.png";
            Deletebtn.ImageList = imageList1;
            Deletebtn.Location = new Point(408, 245);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(114, 47);
            Deletebtn.TabIndex = 9;
            Deletebtn.Text = "Xoá";
            Deletebtn.UseVisualStyleBackColor = true;
            // 
            // Sortbtn
            // 
            Sortbtn.ImageAlign = ContentAlignment.MiddleLeft;
            Sortbtn.ImageIndex = 1;
            Sortbtn.ImageList = imageList1;
            Sortbtn.Location = new Point(772, 245);
            Sortbtn.Name = "Sortbtn";
            Sortbtn.Size = new Size(136, 47);
            Sortbtn.TabIndex = 10;
            Sortbtn.Text = "Lọc SV đạt";
            Sortbtn.UseVisualStyleBackColor = true;
            // 
            // Updatebtn
            // 
            Updatebtn.ImageAlign = ContentAlignment.MiddleLeft;
            Updatebtn.ImageKey = "refesh.png";
            Updatebtn.ImageList = imageList1;
            Updatebtn.Location = new Point(560, 245);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(183, 47);
            Updatebtn.TabIndex = 10;
            Updatebtn.Text = "Tải lại danh sách";
            Updatebtn.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "plus.png");
            imageList1.Images.SetKeyName(1, "sort.png");
            imageList1.Images.SetKeyName(2, "edit.png");
            imageList1.Images.SetKeyName(3, "bin.png");
            imageList1.Images.SetKeyName(4, "refesh.png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 717);
            Controls.Add(Updatebtn);
            Controls.Add(Sortbtn);
            Controls.Add(Deletebtn);
            Controls.Add(Editbtn);
            Controls.Add(Addbtn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Addbtn;
        private Button Editbtn;
        private Button Deletebtn;
        private Button Sortbtn;
        private Button Updatebtn;
        private ImageList imageList1;
    }
}
