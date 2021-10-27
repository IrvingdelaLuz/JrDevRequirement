using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JrDevRequirement.Models;

namespace JrDevRequirement.Services
{
    public class TableService
    {
        public List<Images> getImageList()
        {
            using (RequirementDBEntities db = new RequirementDBEntities())
            {
                List<Images> list = db.Images.ToList<Images>();
                return list;
            }
        }
    }
}