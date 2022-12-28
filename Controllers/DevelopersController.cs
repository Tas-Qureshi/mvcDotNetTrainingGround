using Microsoft.AspNetCore.Mvc;
using mvcDotNetTrainingGround.Models;
using webapiDotNetTrainingGround.Models;


public class DevelopersController : Controller
{
    private readonly Db _db;
    public DevelopersController(Db db)
    {
        _db = db;

    }
    public IActionResult Index()
    {   
        
        List<GetAllDataVM> DevelopersList = new List<GetAllDataVM>();
        foreach (var items in _db.Developers){
            
            var GDVM = new GetAllDataVM(){
                Id = items.Id,
                Name =items.Name,
                Email = items.Email
            };
            DevelopersList.Add(GDVM);
        }
        return View(DevelopersList);
    }

    //Details
    public IActionResult Details(int id)
    {
        DetailsViewModel DVM = new DetailsViewModel();
        DVM.DeveloperVM = _db.Developers.Find(d => d.Id == id);
        return View(DVM);
    }

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(CreateNewDeveloperViewModel viewModel)
    {
        var nextId = _db.Developers.Count + 1;
        if (ModelState.IsValid)
        {
            var developerToAdd = new Developer()
            {
                Id = nextId,
                Name = viewModel.Name,
                Email = viewModel.Email
            };
            _db.Developers.Add(developerToAdd);
            TempData["success"] = "Developer Created Successfully";
            return RedirectToAction(nameof(Index));
        }
        return View(viewModel);
    }

    
}