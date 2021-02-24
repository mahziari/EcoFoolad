using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Admin;
using ParsaPoolad.Application.Services.BackEnd.Admin.Company.Command;

namespace EndPoint.Web.Areas.Admin.Controllers
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


        public IActionResult Index()
        {
            var result = _companyFacad.GetIndexCompanyServices.Execute();
            return View(result);
        }
        
        
        public IActionResult Details(int id)
        {
            var result = _companyFacad.GetDetailsCompanyServices.Execute(id);
            return View(result);
        }
        
        
        
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
        
        
        public IActionResult Delete(int id)
        {
            var result = _companyFacad.DeleteCompanyServices.Execute(id);
        
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
        }
        
        
        public IActionResult Active(int id)
        {
            var result = _companyFacad.ActiveCompanyServices.Execute(id);
        
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
        }
    }
}