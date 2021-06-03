using CarRentalApp.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApp.Server.IRepository
{
    public interface IUnitOfWork: IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Make> MakesRepository { get; }
        IGenericRepository<Model> ModelsRepository { get;  }
        IGenericRepository<Vehicle> VehiclesRepository { get; }
        IGenericRepository<Colour> ColoursRepository { get;  }
        IGenericRepository<Customer> CustomersRepository { get;  }
        IGenericRepository<Booking> BookingsRepository { get; } 

    }
}
