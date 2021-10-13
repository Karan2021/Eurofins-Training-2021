using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using MyMovieLibrary;
namespace MyMovieApp
{
    public partial class WMoviePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            MovieDetailsEntities movieEntity = new MovieDetailsEntities();
            movie movieObj = new movie();
            //movieObj.Id = Convert.ToInt32(Id.Text);
            movieObj.Name = Name.Text;
            movieObj.MovieType = MovieType.Text;
            movieObj.MovieDesc = MovieDesc.Text;

            movieEntity.movies.Add(movieObj);
            movieEntity.SaveChanges();


        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            MovieDetailsEntities movieEntity = new MovieDetailsEntities();
            movie movieObj = new movie();
            movieObj.Id = Convert.ToInt32(Id.Text);
            movieObj.Name = Name.Text;
            movieObj.MovieType = MovieType.Text;
            movieObj.MovieDesc = MovieDesc.Text;

            movieEntity.Entry(movieObj).State = EntityState.Modified;
            movieEntity.SaveChanges();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            MovieDetailsEntities movieEntity = new MovieDetailsEntities();
            movie movieObj = new movie();
            movieObj.Id = Convert.ToInt32(Id.Text);
            movieObj.Name = Name.Text;
            movieObj.MovieType = MovieType.Text;
            movieObj.MovieDesc = MovieDesc.Text;

            movieEntity.Entry(movieObj).State = EntityState.Deleted;
            movieEntity.SaveChanges();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            MovieDetailsEntities movieEntity = new MovieDetailsEntities();
            var result = movieEntity.movies.ToList().Find(obj => obj.Id == Convert.ToInt32(Search.Text));
            Id.Text = result.Id.ToString();
            Name.Text = result.Name;
            MovieType.Text = result.MovieType;
            MovieDesc.Text = result.MovieDesc;
        }
    }
}