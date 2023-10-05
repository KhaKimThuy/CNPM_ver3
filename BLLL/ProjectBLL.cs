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
        public bool InsertPJ(string name, string desc, DateTime exp, DateTime start, DateTime end, string ver, string pk)
        {
            return pj_access.InsertPJ(name, desc, exp, start, end, ver, pk);
        }

        public bool DelMemberFromProject(string u_pk, string pj_id)
        {
            return pj_access.DelMemberFromProject(u_pk, pj_id);
        }

        public DataTable GetProjectInfoAllOfMan(string pk)
        {
            return pj_access.GetProjectInfoAllOfMan(pk);
        }

        public bool AddMember2Project(string u_id, string u_email, string pj_id)
        {
            return pj_access.AddMember2Project(u_id, u_email, pj_id);
        }

        public DataTable GetUserOfProject(string pj_id)
        {
            return pj_access.GetUserOfProject(pj_id);
        }

        public bool UpdateProject(string pj_id, string pj_name, string desc, DateTime exp, DateTime start, DateTime end, string ver, string u_pk)
        {
            return pj_access.UpdateProject(pj_id, pj_name, desc, exp, start, end, ver, u_pk);
        }
    }
}
