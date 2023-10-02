using DALL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BLLL
{
    public class ProjectBLL
    {
        ProjectAccessDAL pj_access = new ProjectAccessDAL();
        public bool InsertPJ(string name, string desc, DateTime exp, DateTime start, DateTime end, string ver, string u_id)
        {
            return pj_access.InsertPJ(name, desc, exp, start, end, ver, u_id);
        }

        public DataTable GetProjectInfoAllOfMan(string u_id)
        {
            return pj_access.GetProjectInfoAllOfMan(u_id);
        }

        public bool AddMember2Project(string u_id, string u_email, string pj_id)
        {
            return pj_access.AddMember2Project(u_id, u_email, pj_id);
        }

        public DataTable GetUserOfProject(string pj_id)
        {
            return pj_access.GetUserOfProject(pj_id);
        }
    }
}
