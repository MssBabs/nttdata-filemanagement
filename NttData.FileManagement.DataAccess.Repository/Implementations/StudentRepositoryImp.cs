using NttData.FileManagement.Common.Model;
using NttData.FileManagement.DataAccess.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NttData.FileManagement.DataAccess.Repository.Implementation
{
    public class StudentRepositoryImp : IStudentRepository
    {
        public bool Add(Student student)
        {
            //variable de entorno: path
            string path = ConfigurationManager.AppSettings.Get("StudentFilePath");
            string studenTxt = student.ToString() + Environment.NewLine;
            
            if (!File.Exists(path))
                File.WriteAllText(path, studenTxt, Encoding.UTF8);
            else
                File.AppendAllText(path, studenTxt, Encoding.UTF8);


            return true;

            throw new NotImplementedException();
        }
    }
}
