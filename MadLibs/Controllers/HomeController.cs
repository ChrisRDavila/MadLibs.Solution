using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() 
    {   
      return View(); 
    }
    
    [Route("/story")]
    public ActionResult Story(string name1, string verb1, string adverb1, string adjective1) 
    { 
      MadLibsVariable myMadLibsVariable = new MadLibsVariable();
      myMadLibsVariable.Name1 = name1;
      myMadLibsVariable.Verb1 = verb1;
      myMadLibsVariable.Adverb1 = adverb1;
      myMadLibsVariable.Adjective1 = adjective1;
      return View(myMadLibsVariable); 
    }

    
  }
}