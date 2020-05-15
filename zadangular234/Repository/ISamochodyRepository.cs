using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zadangular234.DTO;
using zadangular234.Models;

namespace zadangular234.Repository
{
    public interface ISamochodyRepository
    {
        Task<IEnumerable<Samochody>> getAllCars();

        Task<Guid> addCar(SamochodyPostDTO samochodyPostDTO);

        Task<Samochody> getCarById(Guid Id);

        Task<Boolean> saveAll();

        Task<Boolean> deleteCar(Samochody samochody);
    }
}
