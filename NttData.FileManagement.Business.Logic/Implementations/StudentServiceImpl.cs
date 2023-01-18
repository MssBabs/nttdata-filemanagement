using NttData.FileManagement.Common.Model;
using NttData.FileManagement.DataAccess.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NttData.FileManagement.DataAccess.Repository.Implementation
{
    public class StudentServiceImpl : IStudentService
    {
        public bool Add(Student student)
        {
            int studentAge = GetStudentAgeByStudentBirthday(student.Birthday);

            if(studentAge > 0) 
            {
                student.Age = studentAge;

                //new IStudentRepository obj use StudentRepositoryImp metoh:
                IStudentRepository iStudentRepository = new StudentRepositoryImp();
                iStudentRepository.Add(student);
            }

            return true;
        }

        private int GetStudentAgeByStudentBirthday(DateTime studentBirthday) 
        {
            DateTime dateTimeToday = DateTime.Today;
            int studentAge = dateTimeToday.Year - studentBirthday.Year;

            if (dateTimeToday < studentBirthday.AddYears(studentAge))
                --studentAge;

            return studentAge;
        }
    }
}
