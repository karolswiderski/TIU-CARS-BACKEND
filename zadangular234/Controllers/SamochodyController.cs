using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using zadangular234.DTO;
using zadangular234.Models;
using zadangular234.Repository;
using zadangular234.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zadangular234.Controllers
{
    [Route("Samochody")]
    [ApiController]
    public class SamochodyController : ControllerBase
    {
        private readonly ISamochodyRepository samochodyRepository;
        private readonly ISamochodyService samochodyService;

        public SamochodyController(ISamochodyRepository _samochodyRepository, ISamochodyService _samochodyService) 
        {
            samochodyRepository = _samochodyRepository;
            samochodyService = _samochodyService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCar(SamochodyPostDTO samochodyToAdd)
        {
            try
            {
                var guid = await samochodyRepository.addCar(samochodyToAdd);
                return guid == Guid.Empty ? (IActionResult)StatusCode(500) : Ok(guid);
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("all")]
        public async Task<IActionResult> getAllCars()
        {
            var samochody = await samochodyRepository.getAllCars();
            return Ok(samochody.ToList());
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> getCarById(Guid id)
        {
            var samochody = await samochodyRepository.getCarById(id);
            return Ok(samochody);
        }

        [HttpPut]
        public async Task<IActionResult> updateCar(Samochody samochody)
        {
            var _samochody = await samochodyService.updateCars(samochody);
            return Ok(_samochody);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteCar(Guid id)
        {
            var samochody = samochodyService.deleteByCarId(id);
            return Ok(samochody);
        }
    }
}
