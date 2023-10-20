using DALL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLL
{
    public class TaskBLL
    {
        TaskAccessDAL task_access = new TaskAccessDAL();
        public bool InsertTask(string name, string desc, DateTime? exp, DateTime? start, DateTime? end, string isHL, string status, string pjID)
        {
            return task_access.InsertTask(name, desc, exp, start, end, isHL, status, pjID);
        }
    }
}
