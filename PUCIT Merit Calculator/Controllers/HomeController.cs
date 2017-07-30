using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PUCIT_Merit_Calculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Calculator");
        }

        
        public ActionResult ShowAggregate()
        {
            Double marksObtainedInter = Convert.ToDouble (Request["marksObtainedInter"]);
            Double totalMarksInter = Convert.ToDouble(Request["totalMarksInter"]);
            Double marksObtainedMatric = Convert.ToDouble(Request["marksObtainedMatric"]);
            Double totalMarksMatric = Convert.ToDouble(Request["totalMarksMatric"]);
            Double marksObtainedTest = Convert.ToDouble(Request["marksObtainedTest"]);

            Double A = ((marksObtainedInter + (marksObtainedMatric / 4)) / (totalMarksInter + (totalMarksMatric / 4))) * (70);
            Double B = (marksObtainedTest / 140) * (30);
            Double merit = A + B;
            merit = Math.Round(merit, 2, MidpointRounding.AwayFromZero);
            ViewBag.Aggregate = merit;
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}