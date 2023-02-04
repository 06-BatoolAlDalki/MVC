using Read_File.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Read_File.Controllers
{
    public class File : Controller
    {
        // GET: File

        //private readonly ApplicationDbContext _dbContext = new ApplicationDbContext();

        public ActionResult Index()
        {
            // Read the file and store its contents in a list
            List<Employee> fileDataList = new List<Employee>();
            using (StreamReader sr = new StreamReader("path/to/file.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    // Parse the contents of the line and store it in a FileData object
                    // Add the FileData object to the list
                }
            }


            // Insert the contents of the list into the database
            //    using (var context = new YourDbContext())
            //    {
            //        foreach (var fileData in fileDataList)
            //        {
            //            context.FileDatas.Add(fileData);
            //        }
            //        context.SaveChanges();
            //    }

            return View();
        }

    }
}