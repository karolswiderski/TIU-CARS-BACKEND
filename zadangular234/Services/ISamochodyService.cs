using System;
using System.Threading.Tasks;
using zadangular234.Models;

namespace zadangular234.Services
{
    public interface ISamochodyService
    {
        public Task<Samochody> updateCars(Samochody samochody);
        public Task<Samochody> deleteByCarId(Guid Id);
    }
}
