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

    // public ActionResult (int id)
    // {
    //   var thisEngineerMachine = _db.EngineerMachine.FirstOrDefault(x => x.EngineerMachine == id);
    //   var thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == thisEngineerMachine.EngineerId);
    //   var thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == thisEngineerMachine.MachineId);

    //   (EngineerMachine engineermachine, Engineer engineer, Machine machine) model = (thisEngineerMachine, thisEngineer, thisMachine);
    //   return View(model);
    // }
  }
}