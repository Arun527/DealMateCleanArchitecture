using Core.Domain.Aggregates;
using Microsoft.AspNetCore.Http;

namespace Core.Interfaces;

public interface IVehicleRepository
{
    Task<IEnumerable<Vehicle>> ExcelUpload(IFormFile file);
    Task<Vehicle> Update(string values, Vehicle vehicle);
    Task<Vehicle> Delete(int id);
}