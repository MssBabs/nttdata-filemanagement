using NttData.FileManagement.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NttData.FileManagement.DataAccess.Repository.Contracts
{
    public interface IStudentRepository
    {
        bool Add(Student student);
    }
}
