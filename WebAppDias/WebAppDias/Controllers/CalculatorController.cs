using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAppDias.Controllers
{
    [Route("[controller]/[action]")]
    public class CalculatorController : Controller
    {
        public CalculatorController()
        {
            //ViewData["action"] = RouteData.Values["action"].ToString();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PlusTen(int number)
        {
            ViewData["number"] = number;
            ViewData["result"] = number + 10;

            return View();
        }

        /*[Route("[controller]/{firstNumber:int}/{secondNumber:int}")]
        public IActionResult Sum(int firstNumber, int secondNumber)
        {
            ViewData["firstNumber"] = firstNumber;
            ViewData["secondNumber"] = secondNumber;
            ViewData["result"] = firstNumber + secondNumber;

            return View();
        }*/

        [Route("{firstNumber:int}/{secondNumber:int}")]
        public IActionResult Sum(int firstNumber, int secondNumber)
        {
            ViewData["mark"] = '+';
            ViewData["firstNumber"] = firstNumber;
            ViewData["secondNumber"] = secondNumber;
            ViewData["result"] = firstNumber + secondNumber;

            return View("Result");
        }

        [Route("{firstNumber:int}/{secondNumber:int:min(1)}")]
        public IActionResult Divide(int firstNumber, int secondNumber)
        {
            ViewData["mark"] = '/';
            ViewData["firstNumber"] = firstNumber;
            ViewData["secondNumber"] = secondNumber;
            ViewData["result"] = firstNumber / secondNumber;

            return View("Result");
        }
    }
}