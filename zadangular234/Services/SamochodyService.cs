using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zadangular234.Models;
using zadangular234.Repository;

namespace zadangular234.Services
{
    public class SamochodyService : ISamochodyService
    {
        private readonly ISamochodyRepository samochodyRepository;

        public SamochodyService(ISamochodyRepository _samochodyRepository)
        {
            samochodyRepository = _samochodyRepository;
        }

        public async Task<Samochody> deleteByCarId(Guid Id)
        {
            var samochodyy = await samochodyRepository.getCarById(Id);
            await samochodyRepository.deleteCar(samochodyy);
            return samochodyy;
        }

        public async Task<Samochody> updateCars(Samochody samochody)
        {
            var samochodyy = await samochodyRepository.getCarById(samochody.Id);
            samochodyy.Marka = samochody.Marka;
            samochodyy.Model = samochody.Model;
            samochodyy.KM = samochody.KM;
            samochodyy.Silnik = samochody.Silnik;

            await samochodyRepository.saveAll();
            return samochodyy;
        }
    }
}
