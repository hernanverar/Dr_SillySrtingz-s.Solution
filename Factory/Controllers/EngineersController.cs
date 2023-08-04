using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{

    public class EngineerController : Controller
    {
      private readonly FactoryContext _db;
      public EngineerController(FactoryContext db)
      {
        _db = db;
      }
    }
}