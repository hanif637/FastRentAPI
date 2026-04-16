using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FastRentAPI.Data;
using FastRentAPI.Models;

namespace FastRentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public VehiclesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Vehicles
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _context.Vehicles.ToListAsync();

            return Ok(new
            {
                status = true,
                message = "Data kendaraan berhasil diambil",
                data = data
            });
        }

        // GET: api/Vehicles/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var vehicle = await _context.Vehicles.FindAsync(id);

            if (vehicle == null)
            {
                return NotFound(new
                {
                    status = false,
                    message = "Data kendaraan tidak ditemukan"
                });
            }

            return Ok(new
            {
                status = true,
                message = "Data kendaraan ditemukan",
                data = vehicle
            });
        }

        // POST: api/Vehicles
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Vehicle vehicle)
        {
            if (vehicle == null)
            {
                return BadRequest(new
                {
                    status = false,
                    message = "Data kendaraan tidak valid"
                });
            }

            _context.Vehicles.Add(vehicle);
            await _context.SaveChangesAsync();

            return StatusCode(201, new
            {
                status = true,
                message = "Data kendaraan berhasil ditambahkan",
                data = vehicle
            });
        }

        // PUT: api/Vehicles/1
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Vehicle vehicle)
        {
            var data = await _context.Vehicles.FindAsync(id);

            if (data == null)
            {
                return NotFound(new
                {
                    status = false,
                    message = "Data kendaraan tidak ditemukan"
                });
            }

            data.VehicleName = vehicle.VehicleName;
            data.PlateNumber = vehicle.PlateNumber;
            data.PricePerDay = vehicle.PricePerDay;

            await _context.SaveChangesAsync();

            return Ok(new
            {
                status = true,
                message = "Data kendaraan berhasil diperbarui",
                data = data
            });
        }

        // DELETE: api/Vehicles/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var vehicle = await _context.Vehicles.FindAsync(id);

            if (vehicle == null)
            {
                return NotFound(new
                {
                    status = false,
                    message = "Data kendaraan tidak ditemukan"
                });
            }

            _context.Vehicles.Remove(vehicle);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                status = true,
                message = "Data kendaraan berhasil dihapus"
            });
        }
    }
}