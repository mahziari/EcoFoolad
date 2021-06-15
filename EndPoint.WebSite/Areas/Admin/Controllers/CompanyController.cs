using Application.Interfaces.FacadPatterns.BackEnd.Admin;
using Application.Services.BackEnd.Admin.Company.Command;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Authorize(Policy = "Company")]
    [Area("Admin")]
    [Route("panel/admin/company/[action]/{id?}")]
    public class CompanyController:Controller
    {
          private readonly ICompanyFacad _companyFacad;

        public CompanyController(ICompanyFacad companyFacad)
        {
            _companyFacad = companyFacad;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = _companyFacad.GetIndexCompanyServices.Execute();
            return View(result);
        }
        
        [HttpGet]
        public IActionResult Details(int id)
        {
            var result = _companyFacad.GetDetailsCompanyServices.Execute(id);
            return View(result);
        }
        
        
        [HttpGet]
        public IActionResult Create()
        {
            var result = _companyFacad.GetCreateCompanyServices.Execute();
           
            return View(result);
        }
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateCompanyServicesDto createCompanyServicesDto)
        {
            
            if (!ModelState.IsValid)
            {
                return View("Create",_companyFacad.GetCreateCompanyServices.Execute());
            }
            
            var result = _companyFacad.CreateCompanyServices.Execute(createCompanyServicesDto);
        
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
            
        }
        
        
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _companyFacad.GetEditCompanyServices.Execute(id);
            return View(result);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EditCompanyDto editCompanyDto,int id)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit",_companyFacad.GetEditCompanyServices.Execute(id));
            }
            
            var result = _companyFacad.EditCompanyServices.Execute(editCompanyDto,id);
        
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
        }
        
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var result = _companyFacad.DeleteCompanyServices.Execute(id);
        
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
        }
        
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Active(int id)
        {
            var result = _companyFacad.ActiveCompanyServices.Execute(id);
        
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
        }
        
        [HttpGet]
        public IActionResult ConvertToFactories(int id)
        {
            var result = _companyFacad.ConvertToFactoriesCompanyServices.Execute(id);
        
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
        }
    }
}