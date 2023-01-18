using NttData.FileManagement.Common.Model;
using NttData.FileManagement.DataAccess.Repository.Contracts;
using NttData.FileManagement.DataAccess.Repository.Implementation;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NttData.FileManagement.Presentation.WinSite
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSurname_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IStudentService studentService = new StudentServiceImpl();
            Student student = new Student();
            student.Id = int.Parse(txtId.Text);
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Birthday = DateTime.Parse(txtBirthday.Text);

            studentService.Add(student);

            MessageBox.Show("The student is save");
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            //string SAttr = @ConfigurationManager.AppSettings.Get("StudentsFilePath");
            //MessageBox.Show(SAttr);
        }
    }
}
