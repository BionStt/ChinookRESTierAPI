using System;
using System.Diagnostics;
using System.Globalization;
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
        
        #region Album functions
        protected internal IQueryable<Album> OnFilterAlbums(IQueryable<Album> entitySet)
        {
            return entitySet.Take(1);
        }
        
        protected internal void OnInsertingAlbum(Album entity)
        {
            Console.WriteLine("Inserting Album...");
        }

        protected void OnInsertedAlbum(Album entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.AlbumId} has been Inserted.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendTripWelcome(trip);
        }

        protected internal void OnUpdatingAlbum(Album entity)
        {
            Console.WriteLine("Updating Album...");
        }

        protected void OnUpdatedAlbum(Album entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.AlbumId} has been Updated.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendTripWelcome(trip);
        }

        protected internal void OnDeletingAlbums(Album entity)
        {
            Console.WriteLine("Deleting Album...");
        }

        protected void OnDeletedAlbum(Album entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.AlbumId} has been Deleted.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendTripWelcome(trip);
        }
        #endregion

    }
}