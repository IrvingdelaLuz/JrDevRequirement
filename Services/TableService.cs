using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JrDevRequirement.Models;

namespace JrDevRequirement.Services
{
    public static class TableService
    {
        public static List<Images> getImageList()
        {
            using (RequirementDBEntities db = new RequirementDBEntities())
            {
                List<Images> list = db.Images.ToList<Images>();
                return list;
            }
        }
    }
}