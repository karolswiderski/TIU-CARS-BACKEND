using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zadangular234.DTO;
using zadangular234.Models;
using zadangular234.Models.Data;

namespace zadangular234.Repository
{
    public class SamochodyRepository : ISamochodyRepository
    {
        private readonly SamochodyContext samochodyContext;

        public SamochodyRepository(SamochodyContext _context)
        {
            samochodyContext = _context;
        }

        public async Task<Guid> addCar(SamochodyPostDTO SamochodyPostDTO)
        {
           Samochody car = new Samochody()
            {
                Id = Guid.NewGuid(),
                Marka = SamochodyPostDTO.Marka,
                Model = SamochodyPostDTO.Model,
                KM = SamochodyPostDTO.KM,
                Silnik = SamochodyPostDTO.Silnik,
                Sciezka = SamochodyPostDTO.Sciezka
            };

            await samochodyContext.Samochody.AddAsync(car);
            await saveAll();
            return car.Id;

        }

        public async Task<bool> deleteCar(Samochody samochody)
        {
            samochodyContext.Samochody.Remove(samochody);
            await saveAll();
            return true;
        }

        public async Task<IEnumerable<Samochody>> getAllCars()
        {
            return await samochodyContext.Samochody.ToListAsync();
        }

        public async Task<Samochody> getCarById(Guid id)
        {
            var samochody = await samochodyContext.Samochody.FirstOrDefaultAsync(x => x.Id == id);
            return samochody;
        }

        public async Task<Boolean> saveAll()
        {
            return await samochodyContext.SaveChangesAsync() > 0;
        }
    }
}
