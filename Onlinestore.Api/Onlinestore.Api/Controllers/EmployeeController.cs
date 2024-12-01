using System.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Onlinestore.Api.Context;
using Onlinestore.Api.Response;

namespace Onlinestore.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController(ILogger<EmployeeController> logger, StoreDbContext context) : Controller
{
    private readonly ILogger<EmployeeController> _logger = logger;

    private readonly StoreDbContext _context = context;

    // GET
    [HttpGet]
    public EmployeeResponse GetAllEmployees(int? bussinessId)
    {
        EmployeeResponse response = new EmployeeResponse();
        try
        {
            var employees = _context.Employees
                .FirstOrDefault(x => x.BusinessEntityId == bussinessId);
            if (employees == null) return response;
            response.BusinessEntityId = employees.BusinessEntityId;
            response.BusinessEntityId = employees.BusinessEntityId;
            response.Rowguid = employees.Rowguid;
            response.ModifiedDate = employees.ModifiedDate;
            response.Gender = employees.Gender;
            response.BirthDate = employees.BirthDate;
            response.HireDate = employees.HireDate;
            response.NationalIdnumber = employees.NationalIdnumber;
            response.LoginId = employees.LoginId;
            response.MaritalStatus = employees.MaritalStatus;
            response.SalariedFlag = employees.SalariedFlag;
            response.VacationHours = employees.VacationHours;
            response.SickLeaveHours = employees.SickLeaveHours;
            response.CurrentFlag = employees.CurrentFlag;
            response.JobTitle = employees.JobTitle;
            response.OrganizationLevel = employees.OrganizationLevel;
            return response;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            return response;
        }
    }


    [HttpGet("GetAllEmployeesAsync")]
    public async Task<EmployeeResponse> GetAllEmployeesAsync(int? bussinessId)
    {
        EmployeeResponse response = new EmployeeResponse();
        try
        {
            var employees = await _context.Employees
                .FirstOrDefaultAsync(x => x.BusinessEntityId == bussinessId).ConfigureAwait(false);
            if (employees == null) return response;
            response.BusinessEntityId = employees.BusinessEntityId;
            response.BusinessEntityId = employees.BusinessEntityId;
            response.Rowguid = employees.Rowguid;
            response.ModifiedDate = employees.ModifiedDate;
            response.Gender = employees.Gender;
            response.BirthDate = employees.BirthDate;
            response.HireDate = employees.HireDate;
            response.NationalIdnumber = employees.NationalIdnumber;
            response.LoginId = employees.LoginId;
            response.MaritalStatus = employees.MaritalStatus;
            response.SalariedFlag = employees.SalariedFlag;
            response.VacationHours = employees.VacationHours;
            response.SickLeaveHours = employees.SickLeaveHours;
            response.CurrentFlag = employees.CurrentFlag;
            response.JobTitle = employees.JobTitle;
            response.OrganizationLevel = employees.OrganizationLevel;
            return response;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            return response;
        }
    }

    [HttpGet("GetAllEmployees")]
    public async Task<EmployeeResponse> AllEmployees(int? bussinessId)
    {
        var response = new EmployeeResponse();
        try
        {
            var employees = 
                await EntityFrameworkQueryableExtensions
                .FirstOrDefaultAsync(QueryableExtensions
                    .AsNoTracking(_context.Employees).Where(x => x.BusinessEntityId == bussinessId));
            if (employees == null) return response;
            response.BusinessEntityId = employees.BusinessEntityId;
            response.Rowguid = employees.Rowguid;
            response.ModifiedDate = employees.ModifiedDate;
            response.Gender = employees.Gender;
            response.BirthDate = employees.BirthDate;
            response.HireDate = employees.HireDate;
            response.NationalIdnumber = employees.NationalIdnumber;
            response.LoginId = employees.LoginId;
            response.MaritalStatus = employees.MaritalStatus;
            response.SalariedFlag = employees.SalariedFlag;
            response.VacationHours = employees.VacationHours;
            response.SickLeaveHours = employees.SickLeaveHours;
            response.CurrentFlag = employees.CurrentFlag;
            response.JobTitle = employees.JobTitle;
            response.OrganizationLevel = employees.OrganizationLevel;
            return response;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            return response;
        }
    }
}