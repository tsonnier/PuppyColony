using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IdleGame1.Models;

namespace IdleGame1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        public IQueryable<Building> GetBuildings()
        {
            var _db = new IdleGame1.Models.GameDataContext();
            IQueryable<Building> query = _db.Buildings;
            query = query.Where(p => p.Unlocked == true);
            return query;
        }

        public IQueryable<Resource> GetResources()
        {
            var _db = new IdleGame1.Models.GameDataContext();
            IQueryable<Resource> query = _db.Resources;
            query = query.Where(p => p.Unlocked == true);
            return query;
        }

        protected void Build_Click(object sender, EventArgs e)
        {

            Response.Write("<script>alert('Button clicked!');</script>");
        }
    }
}