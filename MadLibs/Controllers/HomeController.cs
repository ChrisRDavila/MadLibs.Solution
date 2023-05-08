using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Entry() 
    {   
      return View(); 
    }

    [Route("/personForm")]
    public ActionResult PersonForm()
    {
      return View();
    }

    [Route("/personStory")]
    public ActionResult PersonStory(string name1, string verb1, string adverb1, string adjective1) 
    { 
      MadLibsVariable myMadLibsVariable = new MadLibsVariable();
      myMadLibsVariable.Name1 = name1;
      myMadLibsVariable.Verb1 = verb1;
      myMadLibsVariable.Adverb1 = adverb1;
      myMadLibsVariable.Adjective1 = adjective1;
      return View(myMadLibsVariable); 
    }

    [Route("/animalForm")]
    public ActionResult AnimalForm()
    {
      return View();
    }


    [Route("/animalStory")]
    public ActionResult AnimalStory(string name1, string animal1, string verb1, string adjective1)
    {
      //name animal verb adjective
      MadLibsVariable myMadLibsVariable = new MadLibsVariable();
      myMadLibsVariable.Name1 = name1;
      myMadLibsVariable.Verb1 = verb1;
      myMadLibsVariable.Animal1 = animal1;
      myMadLibsVariable.Adjective1 = adjective1;
      return View();
    }
  }
}