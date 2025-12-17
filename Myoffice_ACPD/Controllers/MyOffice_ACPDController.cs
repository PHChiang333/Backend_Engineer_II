using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Myoffice_ACPD.Migrations;
using Myoffice_ACPD.Model;
using Myoffice_ACPD.Model.Dto;

namespace Myoffice_ACPD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyOffice_ACPDController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MyOffice_ACPDController(AppDbContext context)
        {
            _context = context;
        }


        public async Task <IActionResult> CreateAcpd([FromBody] MyOffice_ACPD_CreateDto dto)
        {
            //傳入的 dto 物件 轉成 json 字串
            var json  = JsonSerializer.Serialize(dto);
            //使用 ADO.NET 直接呼叫 存儲過程
            var conn = _context.Database.GetDbConnection();
            await conn.OpenAsync();

            //建立命令物件
            using var command = conn.CreateCommand();





            return Ok();
        }




        #region CRUD original template


        // GET: api/MyOffice_ACPD
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MyOffice_ACPD>>> GetMyOffice_ACPD()
        {
            return await _context.MyOffice_ACPD.ToListAsync();
        }

        // GET: api/MyOffice_ACPD/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MyOffice_ACPD>> GetMyOffice_ACPD(string id)
        {
            var myOffice_ACPD = await _context.MyOffice_ACPD.FindAsync(id);

            if (myOffice_ACPD == null)
            {
                return NotFound();
            }

            return myOffice_ACPD;
        }

        // PUT: api/MyOffice_ACPD/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMyOffice_ACPD(string id, MyOffice_ACPD myOffice_ACPD)
        {
            if (id != myOffice_ACPD.ACPD_SID)
            {
                return BadRequest();
            }

            _context.Entry(myOffice_ACPD).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MyOffice_ACPDExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MyOffice_ACPD
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MyOffice_ACPD>> PostMyOffice_ACPD(MyOffice_ACPD myOffice_ACPD)
        {
            _context.MyOffice_ACPD.Add(myOffice_ACPD);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MyOffice_ACPDExists(myOffice_ACPD.ACPD_SID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMyOffice_ACPD", new { id = myOffice_ACPD.ACPD_SID }, myOffice_ACPD);
        }

        // DELETE: api/MyOffice_ACPD/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMyOffice_ACPD(string id)
        {
            var myOffice_ACPD = await _context.MyOffice_ACPD.FindAsync(id);
            if (myOffice_ACPD == null)
            {
                return NotFound();
            }

            _context.MyOffice_ACPD.Remove(myOffice_ACPD);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MyOffice_ACPDExists(string id)
        {
            return _context.MyOffice_ACPD.Any(e => e.ACPD_SID == id);
        }

        #endregion






    }
}
