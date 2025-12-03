namespace DapperDemoCSharp_63;

public interface IDepartmentRepository
{
    public IEnumerable<Department> GetAllDepartments();
    public void InsertDepartment(string newDepartmentName);
}