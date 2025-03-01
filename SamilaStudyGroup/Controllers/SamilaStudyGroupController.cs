using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SamilaStudyGroup.Controllers
{
    public class SamilaStudyGroupController : Controller
    {
        // GET: SamilaStudyGroup
        public ActionResult SamilaStudyGroupView()
        {
            List<Models.SamilaStudyGroup> people = new List<Models.SamilaStudyGroup>();
            people.Add(new Models.SamilaStudyGroup { StudentNumber = "u24950221", FirstName = "Samila", Surname = "Magubane", EmailAddress = "u24950221@tuks.co.za"  });
            people.Add(new Models.SamilaStudyGroup { StudentNumber = "u12345678", FirstName = "Amy", Surname = "Winehouse", EmailAddress = "u12345678@tuks.co.za" });
            people.Add(new Models.SamilaStudyGroup { StudentNumber = "u91011121", FirstName = "Betty", Surname = "Boop", EmailAddress = "u91011121@tuks.co.za" });
            people.Add(new Models.SamilaStudyGroup { StudentNumber = "u31415167", FirstName = "Cat", Surname = "Matthews", EmailAddress = "u31415167@tuks.co.za" });
            people.Add(new Models.SamilaStudyGroup { StudentNumber = "u11223344", FirstName = "Dora", Surname = "Keith", EmailAddress = "u11223344@tuks.co.za" });
            return View(people);
        }
    }
}