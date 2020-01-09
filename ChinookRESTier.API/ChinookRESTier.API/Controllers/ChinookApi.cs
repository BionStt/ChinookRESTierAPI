using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using ChinookRESTier.API.Models;
using Microsoft.Restier.AspNet.Model;
using Microsoft.Restier.EntityFramework;

namespace ChinookRESTier.API.Controllers
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class ChinookApi : EntityFrameworkApi<ChinookModel>
    {
        public ChinookApi(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        #region Album functions
        protected internal bool CanInsertAlbums()
        {
            return true;
        }

        protected internal bool CanDeleteAlbums()
        {
            return true;
        }

        protected internal bool CanUpdateAlbums()
        {
            // Use claims-based security
            return ClaimsPrincipal.Current.IsInRole("admin");

            // You can also use legacy role-based security, though it's harder to test.
            //return HttpContext.Current.User.IsInRole("admin");
        }

        protected internal IQueryable<Album> OnFilterAlbums(IQueryable<Album> entitySet)
        {
            //TraceEvent("Album", RestierOperationTypes.Filtered);

            //return only albums that have associated tracks
            return entitySet.Where(c => c.Tracks.Any()).AsQueryable();
        }
        
        protected internal void OnInsertingAlbum(Album entity)
        {
            //TrackEvent(entity, RestierOperationTypes.Inserting);
            Console.WriteLine("Inserting Album...");
        }

        protected void OnInsertedAlbum(Album entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.AlbumId} has been Inserted.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendAlbumAnnounce(entity);
        }

        protected internal void OnUpdatingAlbum(Album entity)
        {
            Console.WriteLine("Updating Album...");
        }

        protected void OnUpdatedAlbum(Album entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.AlbumId} has been Updated.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendAlbumUpdate(entity);
        }

        protected internal void OnDeletingAlbums(Album entity)
        {
            Console.WriteLine("Deleting Album...");
        }

        protected void OnDeletedAlbum(Album entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.AlbumId} has been Deleted.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendAlbumRemoved(entity);
        }
        #endregion

        #region Artist functions
        protected internal bool CanInsertArtists()
        {
            return true;
        }

        protected internal bool CanDeleteArtists()
        {
            return true;
        }

        protected internal bool CanUpdateArtists()
        {
            // Use claims-based security
            return ClaimsPrincipal.Current.IsInRole("admin");

            // You can also use legacy role-based security, though it's harder to test.
            //return HttpContext.Current.User.IsInRole("admin");
        }

        protected internal IQueryable<Artist> OnFilterArtists(IQueryable<Artist> entitySet)
        {
            //TraceEvent("Artist", RestierOperationTypes.Filtered);

            //return only Artists that have associated tracks
            return entitySet.Where(c => c.Albums.Any()).AsQueryable();
        }
        
        protected internal void OnInsertingArtist(Artist entity)
        {
            //TrackEvent(entity, RestierOperationTypes.Inserting);
            Console.WriteLine("Inserting Artist...");
        }

        protected void OnInsertedArtist(Artist entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.ArtistId} has been Inserted.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendArtistAnnounce(entity);
        }

        protected internal void OnUpdatingArtist(Artist entity)
        {
            Console.WriteLine("Updating Artist...");
        }

        protected void OnUpdatedArtist(Artist entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.ArtistId} has been Updated.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendArtistUpdate(entity);
        }

        protected internal void OnDeletingArtists(Artist entity)
        {
            Console.WriteLine("Deleting Artist...");
        }

        protected void OnDeletedArtist(Artist entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.ArtistId} has been Deleted.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendArtistRemoved(entity);
        }
        #endregion

        #region Customer functions
        protected internal bool CanInsertCustomers()
        {
            return true;
        }

        protected internal bool CanDeleteCustomers()
        {
            return true;
        }

        protected internal bool CanUpdateCustomers()
        {
            // Use claims-based security
            return ClaimsPrincipal.Current.IsInRole("admin");

            // You can also use legacy role-based security, though it's harder to test.
            //return HttpContext.Current.User.IsInRole("admin");
        }

        protected internal IQueryable<Customer> OnFilterCustomers(IQueryable<Customer> entitySet)
        {
            //TraceEvent("Customer", RestierOperationTypes.Filtered);

            //return only Customers that have associated tracks
            return entitySet.Where(c => c.State == null).AsQueryable();
        }
        
        protected internal void OnInsertingCustomer(Customer entity)
        {
            //TrackEvent(entity, RestierOperationTypes.Inserting);
            Console.WriteLine("Inserting Customer...");
        }

        protected void OnInsertedCustomer(Customer entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.CustomerId} has been Inserted.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendCustomerAnnounce(entity);
        }

        protected internal void OnUpdatingCustomer(Customer entity)
        {
            Console.WriteLine("Updating Customer...");
        }

        protected void OnUpdatedCustomer(Customer entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.CustomerId} has been Updated.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendCustomerUpdate(entity);
        }

        protected internal void OnDeletingCustomers(Customer entity)
        {
            Console.WriteLine("Deleting Customer...");
        }

        protected void OnDeletedCustomer(Customer entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.CustomerId} has been Deleted.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendCustomerRemoved(entity);
        }
        #endregion

        #region Employee functions
        protected internal bool CanInsertEmployees()
        {
            return true;
        }

        protected internal bool CanDeleteEmployees()
        {
            return true;
        }

        protected internal bool CanUpdateEmployees()
        {
            // Use claims-based security
            return ClaimsPrincipal.Current.IsInRole("admin");

            // You can also use legacy role-based security, though it's harder to test.
            //return HttpContext.Current.User.IsInRole("admin");
        }

        protected internal IQueryable<Employee> OnFilterEmployees(IQueryable<Employee> entitySet)
        {
            //TraceEvent("Employee", RestierOperationTypes.Filtered);

            //return only Employees that have associated tracks
            return entitySet.Where(c => c.ReportsTo != null).AsQueryable();
        }
        
        protected internal void OnInsertingEmployee(Employee entity)
        {
            //TrackEvent(entity, RestierOperationTypes.Inserting);
            Console.WriteLine("Inserting Employee...");
        }

        protected void OnInsertedEmployee(Employee entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.EmployeeId} has been Inserted.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendEmployeeAnnounce(entity);
        }

        protected internal void OnUpdatingEmployee(Employee entity)
        {
            Console.WriteLine("Updating Employee...");
        }

        protected void OnUpdatedEmployee(Employee entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.EmployeeId} has been Updated.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendEmployeeUpdate(entity);
        }

        protected internal void OnDeletingEmployees(Employee entity)
        {
            Console.WriteLine("Deleting Employee...");
        }

        protected void OnDeletedEmployee(Employee entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.EmployeeId} has been Deleted.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendEmployeeRemoved(entity);
        }
        #endregion

        #region Genre functions
        protected internal bool CanInsertGenres()
        {
            return true;
        }

        protected internal bool CanDeleteGenres()
        {
            return true;
        }

        protected internal bool CanUpdateGenres()
        {
            // Use claims-based security
            return ClaimsPrincipal.Current.IsInRole("admin");

            // You can also use legacy role-based security, though it's harder to test.
            //return HttpContext.Current.User.IsInRole("admin");
        }

        protected internal IQueryable<Genre> OnFilterGenres(IQueryable<Genre> entitySet)
        {
            //TraceEvent("Genre", RestierOperationTypes.Filtered);

            //return only Genres that have associated tracks
            return entitySet.Where(c => c.Tracks.Any()).AsQueryable();
        }
        
        protected internal void OnInsertingGenre(Genre entity)
        {
            //TrackEvent(entity, RestierOperationTypes.Inserting);
            Console.WriteLine("Inserting Genre...");
        }

        protected void OnInsertedGenre(Genre entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.GenreId} has been Inserted.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendGenreAnnounce(entity);
        }

        protected internal void OnUpdatingGenre(Genre entity)
        {
            Console.WriteLine("Updating Genre...");
        }

        protected void OnUpdatedGenre(Genre entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.GenreId} has been Updated.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendGenreUpdate(entity);
        }

        protected internal void OnDeletingGenres(Genre entity)
        {
            Console.WriteLine("Deleting Genre...");
        }

        protected void OnDeletedGenre(Genre entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.GenreId} has been Deleted.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendGenreRemoved(entity);
        }
        #endregion

        #region Invoice functions
        protected internal bool CanInsertInvoices()
        {
            return true;
        }

        protected internal bool CanDeleteInvoices()
        {
            return true;
        }

        protected internal bool CanUpdateInvoices()
        {
            // Use claims-based security
            return ClaimsPrincipal.Current.IsInRole("admin");

            // You can also use legacy role-based security, though it's harder to test.
            //return HttpContext.Current.User.IsInRole("admin");
        }

        protected internal IQueryable<Invoice> OnFilterInvoices(IQueryable<Invoice> entitySet)
        {
            //TraceEvent("Invoice", RestierOperationTypes.Filtered);

            //return only Invoices that have associated tracks
            return entitySet.Where(c => c.InvoiceLines.Any()).AsQueryable();
        }
        
        protected internal void OnInsertingInvoice(Invoice entity)
        {
            //TrackEvent(entity, RestierOperationTypes.Inserting);
            Console.WriteLine("Inserting Invoice...");
        }

        protected void OnInsertedInvoice(Invoice entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.InvoiceId} has been Inserted.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendInvoiceAnnounce(entity);
        }

        protected internal void OnUpdatingInvoice(Invoice entity)
        {
            Console.WriteLine("Updating Invoice...");
        }

        protected void OnUpdatedInvoice(Invoice entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.InvoiceId} has been Updated.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendInvoiceUpdate(entity);
        }

        protected internal void OnDeletingInvoices(Invoice entity)
        {
            Console.WriteLine("Deleting Invoice...");
        }

        protected void OnDeletedInvoice(Invoice entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.InvoiceId} has been Deleted.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendInvoiceRemoved(entity);
        }
        #endregion

        #region InvoiceLine functions
        protected internal bool CanInsertInvoiceLines()
        {
            return true;
        }

        protected internal bool CanDeleteInvoiceLines()
        {
            return true;
        }

        protected internal bool CanUpdateInvoiceLines()
        {
            // Use claims-based security
            return ClaimsPrincipal.Current.IsInRole("admin");

            // You can also use legacy role-based security, though it's harder to test.
            //return HttpContext.Current.User.IsInRole("admin");
        }

        protected internal IQueryable<InvoiceLine> OnFilterInvoiceLines(IQueryable<InvoiceLine> entitySet)
        {
            //TraceEvent("InvoiceLine", RestierOperationTypes.Filtered);

            //return only InvoiceLines that have associated tracks
            return entitySet.Where(c => c.Track.UnitPrice > (decimal) .50).AsQueryable();
        }
        
        protected internal void OnInsertingInvoiceLine(InvoiceLine entity)
        {
            //TrackEvent(entity, RestierOperationTypes.Inserting);
            Console.WriteLine("Inserting InvoiceLine...");
        }

        protected void OnInsertedInvoiceLine(InvoiceLine entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.InvoiceLineId} has been Inserted.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendInvoiceLineAnnounce(entity);
        }

        protected internal void OnUpdatingInvoiceLine(InvoiceLine entity)
        {
            Console.WriteLine("Updating InvoiceLine...");
        }

        protected void OnUpdatedInvoiceLine(InvoiceLine entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.InvoiceLineId} has been Updated.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendInvoiceLineUpdate(entity);
        }

        protected internal void OnDeletingInvoiceLines(InvoiceLine entity)
        {
            Console.WriteLine("Deleting InvoiceLine...");
        }

        protected void OnDeletedInvoiceLine(InvoiceLine entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.InvoiceLineId} has been Deleted.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendInvoiceLineRemoved(entity);
        }
        #endregion

        #region MediaType functions
        protected internal bool CanInsertMediaTypes()
        {
            return true;
        }

        protected internal bool CanDeleteMediaTypes()
        {
            return true;
        }

        protected internal bool CanUpdateMediaTypes()
        {
            // Use claims-based security
            return ClaimsPrincipal.Current.IsInRole("admin");

            // You can also use legacy role-based security, though it's harder to test.
            //return HttpContext.Current.User.IsInRole("admin");
        }

        protected internal IQueryable<MediaType> OnFilterMediaTypes(IQueryable<MediaType> entitySet)
        {
            //TraceEvent("MediaType", RestierOperationTypes.Filtered);

            //return only MediaTypes that have associated tracks
            return entitySet.Where(c => c.Tracks.Any()).AsQueryable();
        }
        
        protected internal void OnInsertingMediaType(MediaType entity)
        {
            //TrackEvent(entity, RestierOperationTypes.Inserting);
            Console.WriteLine("Inserting MediaType...");
        }

        protected void OnInsertedMediaType(MediaType entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.MediaTypeId} has been Inserted.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendMediaTypeAnnounce(entity);
        }

        protected internal void OnUpdatingMediaType(MediaType entity)
        {
            Console.WriteLine("Updating MediaType...");
        }

        protected void OnUpdatedMediaType(MediaType entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.MediaTypeId} has been Updated.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendMediaTypeUpdate(entity);
        }

        protected internal void OnDeletingMediaTypes(MediaType entity)
        {
            Console.WriteLine("Deleting MediaType...");
        }

        protected void OnDeletedMediaType(MediaType entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.MediaTypeId} has been Deleted.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendMediaTypeRemoved(entity);
        }
        #endregion

        #region Playlist functions
        protected internal bool CanInsertPlaylists()
        {
            return true;
        }

        protected internal bool CanDeletePlaylists()
        {
            return true;
        }

        protected internal bool CanUpdatePlaylists()
        {
            // Use claims-based security
            return ClaimsPrincipal.Current.IsInRole("admin");

            // You can also use legacy role-based security, though it's harder to test.
            //return HttpContext.Current.User.IsInRole("admin");
        }

        protected internal IQueryable<Playlist> OnFilterPlaylists(IQueryable<Playlist> entitySet)
        {
            //TraceEvent("Playlist", RestierOperationTypes.Filtered);

            //return only Playlists that have associated tracks
            return entitySet.Where(c => c.Tracks.Any()).AsQueryable();
        }
        
        protected internal void OnInsertingPlaylist(Playlist entity)
        {
            //TrackEvent(entity, RestierOperationTypes.Inserting);
            Console.WriteLine("Inserting Playlist...");
        }

        protected void OnInsertedPlaylist(Playlist entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.PlaylistId} has been Inserted.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendPlaylistAnnounce(entity);
        }

        protected internal void OnUpdatingPlaylist(Playlist entity)
        {
            Console.WriteLine("Updating Playlist...");
        }

        protected void OnUpdatedPlaylist(Playlist entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.PlaylistId} has been Updated.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendPlaylistUpdate(entity);
        }

        protected internal void OnDeletingPlaylists(Playlist entity)
        {
            Console.WriteLine("Deleting Playlist...");
        }

        protected void OnDeletedPlaylist(Playlist entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.PlaylistId} has been Deleted.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendPlaylistRemoved(entity);
        }
        #endregion

        #region Track functions
        protected internal bool CanInsertTracks()
        {
            return true;
        }

        protected internal bool CanDeleteTracks()
        {
            return true;
        }

        protected internal bool CanUpdateTracks()
        {
            // Use claims-based security
            return ClaimsPrincipal.Current.IsInRole("admin");

            // You can also use legacy role-based security, though it's harder to test.
            //return HttpContext.Current.User.IsInRole("admin");
        }

        protected internal IQueryable<Track> OnFilterTracks(IQueryable<Track> entitySet)
        {
            //TraceEvent("Track", RestierOperationTypes.Filtered);

            //return only Tracks that have associated tracks
            return entitySet.Where(c => c.InvoiceLines.Any()).AsQueryable();
        }
        
        protected internal void OnInsertingTrack(Track entity)
        {
            //TrackEvent(entity, RestierOperationTypes.Inserting);
            Console.WriteLine("Inserting Track...");
        }

        protected void OnInsertedTrack(Track entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.TrackId} has been Inserted.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendTrackAnnounce(entity);
        }

        protected internal void OnUpdatingTrack(Track entity)
        {
            Console.WriteLine("Updating Track...");
        }

        protected void OnUpdatedTrack(Track entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.TrackId} has been Updated.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendTrackUpdate(entity);
        }

        protected internal void OnDeletingTracks(Track entity)
        {
            Console.WriteLine("Deleting Track...");
        }

        protected void OnDeletedTrack(Track entity)
        {
            Trace.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}: {entity.TrackId} has been Deleted.");

            // Pseudocode that represents a real business process.
            // EmailManager.SendTrackRemoved(entity);
        }
        #endregion

        #region Operations

        [Operation(OperationType = OperationType.Action, EntitySet = "Albums")]
        public Album BuyAlbum(Album album)
        {
            if (album == null)
            {
                throw new ArgumentNullException(nameof(album));
            }
            Console.WriteLine($"Id = {album.AlbumId}");
            
            // Code would be here to actually place album into user's cart
            
            album.Title += " | placed in cart";
            return album;
        }

        [Operation(OperationType = OperationType.Action, EntitySet = "Tracks")]
        public Track BuyTrack(Track track)
        {
            if (track == null)
            {
                throw new ArgumentNullException(nameof(track));
            }
            Console.WriteLine($"Id = {track.TrackId}");
            
            // Code would be here to actually place track into user's cart
            
            track.Name += " | placed in cart";
            return track;
        }

        #endregion
    }
}