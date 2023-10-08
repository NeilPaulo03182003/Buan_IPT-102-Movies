using System.Diagnostics;
using Buan_IPT102_Movies_SelfApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Buan_IPT102_Movies_SelfApplication.Controllers
{
	public class buan_MovieController : Controller
	{
		private readonly List<buan_MovieModel> buan_movies;
		
		
		public buan_MovieController()
		{
			buan_movies = new List<buan_MovieModel>
			{
				
				new buan_MovieModel{Movie_ID = 4, Movie_Title ="SpiderMan", Movie_ReleaseYear = "2000", Movie_Rating = "5", Movie_Genre = "Action", Movie_TrailerLink = "https://youtu.be/dQw4w9WgXcQ?si=hBwdPJPDp8Lj_WRQ"},
				new buan_MovieModel{Movie_ID = 5, Movie_Title ="SpiderMan", Movie_ReleaseYear = "2000", Movie_Rating = "5", Movie_Genre = "Action", Movie_TrailerLink = "https://youtu.be/dQw4w9WgXcQ?si=hBwdPJPDp8Lj_WRQ"},
				new buan_MovieModel{Movie_ID = 6, Movie_Title ="SpiderMan", Movie_ReleaseYear = "2000", Movie_Rating = "5", Movie_Genre = "Action", Movie_TrailerLink = "https://youtu.be/dQw4w9WgXcQ?si=hBwdPJPDp8Lj_WRQ"},
				new buan_MovieModel{Movie_ID = 7, Movie_Title ="SpiderMan", Movie_ReleaseYear = "2000", Movie_Rating = "5", Movie_Genre = "Action", Movie_TrailerLink = "https://youtu.be/dQw4w9WgXcQ?si=hBwdPJPDp8Lj_WRQ"},
				new buan_MovieModel{Movie_ID = 8, Movie_Title ="SpiderMan", Movie_ReleaseYear = "2000", Movie_Rating = "5", Movie_Genre = "Action", Movie_TrailerLink = "https://youtu.be/dQw4w9WgXcQ?si=hBwdPJPDp8Lj_WRQ"},
				new buan_MovieModel{Movie_ID = 9, Movie_Title ="SpiderMan", Movie_ReleaseYear = "2000", Movie_Rating = "5", Movie_Genre = "Action", Movie_TrailerLink = "https://youtu.be/dQw4w9WgXcQ?si=hBwdPJPDp8Lj_WRQ"},
				new buan_MovieModel{Movie_ID = 10, Movie_Title ="SpiderMan", Movie_ReleaseYear = "2000", Movie_Rating = "5", Movie_Genre = "Action", Movie_TrailerLink = "https://youtu.be/dQw4w9WgXcQ?si=hBwdPJPDp8Lj_WRQ"},
				new buan_MovieModel{Movie_ID = 11, Movie_Title ="SpiderMan", Movie_ReleaseYear = "2000", Movie_Rating = "5", Movie_Genre = "Action", Movie_TrailerLink = "https://youtu.be/dQw4w9WgXcQ?si=hBwdPJPDp8Lj_WRQ"},
				new buan_MovieModel{Movie_ID = 12, Movie_Title ="SpiderMan", Movie_ReleaseYear = "2000", Movie_Rating = "5", Movie_Genre = "Action", Movie_TrailerLink = "https://youtu.be/dQw4w9WgXcQ?si=hBwdPJPDp8Lj_WRQ"},
				new buan_MovieModel{Movie_ID = 13, Movie_Title ="SpiderMan", Movie_ReleaseYear = "2000", Movie_Rating = "5", Movie_Genre = "Action", Movie_TrailerLink = "https://youtu.be/dQw4w9WgXcQ?si=hBwdPJPDp8Lj_WRQ"},
				new buan_MovieModel{Movie_ID = 14, Movie_Title ="SpiderMan", Movie_ReleaseYear = "2000", Movie_Rating = "5", Movie_Genre = "Action", Movie_TrailerLink = "https://youtu.be/dQw4w9WgXcQ?si=hBwdPJPDp8Lj_WRQ"},
				new buan_MovieModel{Movie_ID = 15, Movie_Title ="SpiderMan", Movie_ReleaseYear = "2000", Movie_Rating = "5", Movie_Genre = "Action", Movie_TrailerLink = "https://youtu.be/dQw4w9WgXcQ?si=hBwdPJPDp8Lj_WRQ"},
			};
		}
		//Public class that fetch movie data from the model

		public ActionResult buan_Movies(int id)
		{
			var movie = buan_movies.Find(m => m.Movie_ID == id);
			if (movie == null)
				return NotFound();
			return View(movie);
		
		}

	
		//public ActionResult Random()
		//{
		//	var movie = new buan_MovieModel() { Movie_Title = "Avatar", Movie_Rating = "5" };
		//	return View(movie);
		//}

	}
}
