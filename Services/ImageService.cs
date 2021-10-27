using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JrDevRequirement.Models;

namespace JrDevRequirement.Services
{
    public class ImageService
    {
        public void imageSave(imageConvert img)
        {
            using (RequirementDBEntities db = new RequirementDBEntities())
            {
                Images i = new Images();
                i.ImageName = img.name;
                i.ImageText = img.base64;
                i.DateConverted = img.dateConverted;
                db.Images.Add(i);
                db.SaveChanges();
            }
        }
    }
}