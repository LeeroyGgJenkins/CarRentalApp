using CarRentalApp.Server.Data;
using CarRentalApp.Server.IRepository;
using CarRentalApp.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CarRentalApp.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Make> _makes;
        private IGenericRepository<Model> _models;
        private IGenericRepository<Vehicle> _vehicles;
        private IGenericRepository<Booking> _bookings;
        private IGenericRepository<Colour> _colours;
        private IGenericRepository<Customer> _customers;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        //if _makes is equal to null make a new generic repository of type Make
        public IGenericRepository<Make> MakesRepository => _makes ??= new GenericRepository<Make>(_context);


        public IGenericRepository<Model> ModelsRepository => _models ??= new GenericRepository<Model>(_context);

        public IGenericRepository<Vehicle> VehiclesRepository => _vehicles ??= new GenericRepository<Vehicle>(_context);

        public IGenericRepository<Colour> ColoursRepository => _colours ??=new GenericRepository<Colour>(_context);

        public IGenericRepository<Customer> CustomersRepository => _customers ??=new GenericRepository<Customer>(_context);

        public IGenericRepository<Booking> BookingsRepository => _bookings ??=new GenericRepository<Booking>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        //Automatically takes care of audit (ish)
        public async Task Save(HttpContext httpContext)
        {
            var user = httpContext.User.Identity.Name;
            var entries = _context.ChangeTracker.Entries().
                Where(query => query.State == EntityState.Modified || query.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                  ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                  ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }

            }
            await _context.SaveChangesAsync();
        }
    }
}
