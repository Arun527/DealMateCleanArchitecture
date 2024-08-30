using Core.Domain.Aggregates;
using Microsoft.AspNetCore.Http;

namespace DataContext.ExcelService;

public interface IExcelService
{
    List<Vehicle> VehicleProcess(IFormFile file);
}
