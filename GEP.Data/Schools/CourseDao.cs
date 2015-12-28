using GEP.Core.SchoolsModels;
using GEP.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEP.Data.Schools
{
    public class CourseDao : AbstractDao<SchoolContext, Course, int>, ICourseDao
    {
    }
}
