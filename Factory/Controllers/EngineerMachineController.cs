using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using  System.Dynamic;

namespace Factory.Controllers
{
  public class EngineerMachineController : Controller
  {
    private readonly FactoryContext _db;
    public EngineerMachineController(FactoryContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      dynamic mymodel = new ExpandoObject();
      mymodel.Engineers = _db.Engineers.ToList();
      mymodel.Machines = _db.Machines.ToList();
      mymodel.EngineerMachine = _db.EngineerMachine.ToList();
      return View(mymodel);
    }
  }
}