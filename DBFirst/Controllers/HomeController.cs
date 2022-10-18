using DBFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Xml.Linq;
using DB.EnumFields;
using System.Data;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace DBFirst.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private readonly SqlDbContext _context;
    public HomeController(ILogger<HomeController> logger, SqlDbContext sqlDbContext)
    {
      _logger = logger;
      _context = sqlDbContext;
    }

    public async Task<IActionResult> Index()
    {    
      var a1= await _context.Accounts.Where(x=>x.Status == AccountStatus.Available)
        .Select(x=>x.Gid)
        .ToListAsync();      

      var a2= await _context.Accounts.Where(x => x.Status == AccountStatus.Available)
        .OrderByDescending(x => x.CreatedAt)
        .Select(x => new { x.Gid , x.UserName})
        .Skip(10)
        .Take(10)
        .ToListAsync();      

      var a3 = await _context.Organizations.Where(x=>x.Name == "先進醫資展示服務機構")
        .Join(_context.OrganizeAuthorizations,p=>p.Id,s=>s.OrganizationId,(p,s)=>s.AccountGid)
        .ToListAsync();

      var a4 = await _context.Organizations.Where(x => x.Name == "先進醫資展示服務機構")
        .Join(_context.OrganizationKioskVideos,  p => p.Id, s => s.OrganizationId, (p,s) => s.FileId )
        .Join(_context.Files,p=>p,s=>s.Id, ( p, s) => s.FileUrl)
        .ToListAsync();

      var a5 = await _context.Organizations.Where(x => x.Name == "先進醫資展示服務機構")
        .Join(_context.Machines, p => p.Id, s => s.OrganizationId, (Organization p, Machine s) => s.Id)
        .ToListAsync();

      var a6 = await _context.Organizations.Where(x => x.Name == "先進醫資展示服務機構")
        .Join(_context.PatientGroups, p => p.Id, s => s.OrganizationId,      (p, s) => new { s.Name, s.Status })
        .Where(x => x.Status == PatientGroupStatus.Available)
        .Select(x => x.Name)
        .Skip(20)
        .Take(10)
        .ToListAsync();

      //var a7 = ((await _context.Organizations.Where(x => x.Name == "先進醫資展示服務機構")
      //  .Join(_context.PatientGroups, p => p.Id, s => s.OrganizationId, (p, s) => new { s.Name, s.Id })
      //  .Join(_context.PatientGroupDetails, p => p.Id, s => s.PatientGroupId, (p, s) => s.Status)
      //  .Where(x => x == PatientGroupOperation.Add)
      //  .ToListAsync())
      //  .GroupBy(x => x.)
      //  .Count(x => x.)
      //  .Select(x => new { x.PatientGroups.Name, x.count })
      //  .Take(1);

      var a8 = await _context.PatientGroups.Where(x => x.Name == "先進洗腎室關懷群")
        .Join(_context.PatientGroupDetails, p => p.Id, s => s.PatientGroupId, (p, s) => s.AccountGid)
        .Join(_context.AccountInformations, p => p, s => s.AccountGid, (p, s) => s.Mobile)
        .ToListAsync();

      var a9 = await _context.Accounts.Where(x => x.UserName == "路中廟社區時間銀行")
        .Join(_context.AccountRoles, p => p.Gid, s => s.AccountGid, (p, s) => s.RoleId)
        .Join(_context.Roles, p => p, s => s.Id, (p, s) => s.Name)
        .ToListAsync();


      var a10 = await _context.Accounts.Where(x => x.Gid == Guid.Parse("86f655dd-844f-4ae2-bb54-09281a85711e"))
        .Join(_context.AccountInformations, p => p.Gid, s => s.AccountGid, (p, s) => s.AccountGid)
        .Join(_context.AccountCertificates, p => p, s => s.AccountGid, (p, s) => s.CertiType)
        .ToListAsync();


      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}