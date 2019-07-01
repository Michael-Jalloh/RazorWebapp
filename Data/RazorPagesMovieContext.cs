using Microsoft.EntityFrameworkCore;

namespace RazorWebapp.Models
{
    public class RazorWebappMovieContext : DbContext 
    {
        public RazorWebappMovieContext( DbContextOptions<RazorWebappMovieContext> options) :base(options){

        }

        public DbSet<RazorWebapp.Models.Movie> Movie {get; set;}
    }  

}