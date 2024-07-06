using APITienda.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace APITienda.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TenisController : Controller
    {
        private readonly BdtenisContext _baseDatos;

        public TenisController(BdtenisContext baseDatos)
        {
            this._baseDatos = baseDatos;
        }


        [HttpGet]
        [Route("GetTenis")]
        public async Task<IActionResult> Lista()
        {
            var listaTenis = await _baseDatos.Tenis.ToListAsync();
            return Ok(listaTenis);
        }


        [HttpGet]
        [Route("GetTenis/{categoria}")]
        public async Task<IActionResult> ListaFiltrada(string categoria)
        {
            var listaTenis = await _baseDatos.Tenis
                                        .Where(v => v.Categoria == categoria)
                                        .ToListAsync();
            return Ok(listaTenis);
        }

    }
}
