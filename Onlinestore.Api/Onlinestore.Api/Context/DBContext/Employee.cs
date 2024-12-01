using System.ComponentModel.DataAnnotations.Schema;
using Onlinestore.Api.DBContext;

namespace Onlinestore.Api.Context.DBContext;
 
public class Employee
{
    public int BusinessEntityId { get; set; }
 
    public string NationalIdnumber { get; set; } = null!;
 
    public string LoginId { get; set; } = null!;
 
    public short? OrganizationLevel { get; set; }

 
    public string JobTitle { get; set; } = null!;
 
    public DateOnly BirthDate { get; set; }

    /// <summary>
    /// M = Married, S = Single
    /// </summary>
    public string MaritalStatus { get; set; } = null!;

    /// <summary>
    /// M = Male, F = Female
    /// </summary>
    public string Gender { get; set; } = null!;

    /// <summary>
    /// Employee hired on this date.
    /// </summary>
    public DateOnly HireDate { get; set; }

    /// <summary>
    /// Job classification. 0 = Hourly, not exempt from collective bargaining. 1 = Salaried, exempt from collective bargaining.
    /// </summary>
    public bool SalariedFlag { get; set; }

    /// <summary>
    /// Number of available vacation hours.
    /// </summary>
    public short VacationHours { get; set; }

    /// <summary>
    /// Number of available sick leave hours.
    /// </summary>
    public short SickLeaveHours { get; set; }

    /// <summary>
    /// 0 = Inactive, 1 = Active
    /// </summary>
    public bool CurrentFlag { get; set; }

    /// <summary>
    /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
    /// </summary>
    public Guid Rowguid { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    public DateTime ModifiedDate { get; set; }

    [NotMapped]
    public virtual Person BusinessEntity { get; set; } = null!;
    [NotMapped]
    public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; } = new List<EmployeeDepartmentHistory>();
    [NotMapped]
    public virtual ICollection<EmployeePayHistory> EmployeePayHistories { get; set; } = new List<EmployeePayHistory>();
    [NotMapped]
    public virtual ICollection<JobCandidate> JobCandidates { get; set; } = new List<JobCandidate>();
    [NotMapped]
    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; } = new List<PurchaseOrderHeader>();
    [NotMapped]
    public virtual SalesPerson? SalesPerson { get; set; }
}
