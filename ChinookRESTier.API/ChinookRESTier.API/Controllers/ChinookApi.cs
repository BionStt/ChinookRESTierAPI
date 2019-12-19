using System;
using System.Linq;
using ChinookRESTier.API.Models;
using Microsoft.Restier.EntityFramework;

namespace ChinookRESTier.API.Controllers
{
    public class ChinookApi : EntityFrameworkApi<ChinookModel>
    {
        public ChinookApi(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
        
        protected internal IQueryable<Album> OnFilterAlbums(IQueryable<Album> entitySet)
        {
            return entitySet.Take(1);
        }
        
        protected internal void OnInsertingAlbum(Album entity)
        {
            Console.WriteLine("Inserting Album...");
        }


    }
}