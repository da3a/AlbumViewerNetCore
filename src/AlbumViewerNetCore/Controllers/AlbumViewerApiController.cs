using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AlbumViewerBusiness;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AlbumViewerNetCore.Controllers
{

    public class AlbumViewerApiController : Controller
    {
        private AlbumViewerContext Context;

        public AlbumViewerApiController(AlbumViewerContext context)
        {
            Context = context;
        }

        [HttpGet("api/helloworld")]
        public object Get(string name)
        {
            return new
            {
                message = $"Hello world, {name}.",
                time = DateTime.Now
            };
        }

        [HttpGet("api/artists")]
        public async Task<List<Artist>> GetArtists()
        {
            return await Context.Artists
                .OrderBy(a => a.ArtistName)
                .ToListAsync();
        }
    }

}
