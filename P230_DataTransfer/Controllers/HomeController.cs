using Microsoft.AspNetCore.Mvc;
using P230_DataTransfer.Models;
using P230_DataTransfer.ViewModels;

namespace P230_DataTransfer.Controllers
{
    public class HomeController:Controller
    {
        public List<Series> Series;
        public List<Category> Categories;
        public HomeController()
        {
            Series = new List<Series>()
            {
                new Series()
                {
                    Id = 1,
                    Name = "Game of Thrones",
                    CoverPhoto = "https://i1.sndcdn.com/artworks-W8KXhQeXZrv2YSJO-ctOyHA-t500x500.jpg",
                    Imdb = 9.9,
                    Desc = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                 new Series()
                {
                    Id = 2,
                    Name = "Last of Us",
                    CoverPhoto = "https://m.media-amazon.com/images/M/MV5BZGUzYTI3M2EtZmM0Yy00NGUyLWI4ODEtN2Q3ZGJlYzhhZjU3XkEyXkFqcGdeQXVyNTM0OTY1OQ@@._V1_.jpg",
                    Imdb = 9.2,
                    Desc = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                  new Series()
                {
                    Id = 3,
                    Name = "How I Met your mother",
                    CoverPhoto = "https://m.media-amazon.com/images/M/MV5BNjg1MDQ5MjQ2N15BMl5BanBnXkFtZTYwNjI5NjA3._V1_.jpg",
                    Imdb = 8.9,
                    Desc = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                   new Series()
                {
                    Id = 4,
                    Name = "Chernobyl",
                    CoverPhoto = "https://m.media-amazon.com/images/M/MV5BMmI2OTMxZTUtMTM5OS00MGNiLWFhNGMtYzJiODUwYjRmODA5XkEyXkFqcGdeQXVyMTM0NTc2NDgw._V1_.jpg",
                    Imdb = 9.9,
                    Desc = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                    new Series()
                {
                    Id = 5,
                    Name = "Breaking bad",
                    CoverPhoto = "https://m.media-amazon.com/images/M/MV5BN2VjOTkwMjgtYWEyMy00MzNmLTllMjktNDI1ZmRhYTAwYTg1XkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1000_.jpg",
                    Imdb = 9.9,
                    Desc = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                     new Series()
                {
                    Id = 6,
                    Name = "Stranger Things",
                    CoverPhoto = "https://m.media-amazon.com/images/M/MV5BMDZkYmVhNjMtNWU4MC00MDQxLWE3MjYtZGMzZWI1ZjhlOWJmXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_.jpg",
                    Imdb = 9.0,
                    Desc = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                     new Series()
                {
                    Id = 7,
                    Name = "Dark",
                    CoverPhoto = "https://m.media-amazon.com/images/M/MV5BOTk2NzUyOTctZDdlMS00MDJlLTgzNTEtNzQzYjFhNjA0YjBjXkEyXkFqcGdeQXVyMjg1NDcxNDE@._V1_.jpg",
                    Imdb = 9.0,
                    Desc = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                }

            };

            Category cat1 = new Category()
            {
                Id = 1,
                Name = "Fantasy"
            };
            Category cat2 = new Category()
            {
                Id = 2,
                Name = "Sci-Fi"
            };
            Category cat3 = new Category()
            {
                Id = 3,
                Name = "Action"
            };
            Categories = new List<Category>()
            {
                cat1,
                cat2,
                cat3
            };
        }
        public IActionResult Index()
        {
            //ViewBag.Series = Series;
            //ViewData["Series"] = Series;
            //ViewData["Count1"] = 20;
            //TempData["Count2"] = 30;
            //ViewBag.Data = "Ugurla qeydiyyatdan kecdiniz";
            //TempData["TempData"] = "Ugurla qeydiyyatdan kecdiniz";
            //int num = 5;
            //if (num < 10)
            //{
            //    return RedirectToAction(nameof(About));
            //}
            HomeVM model = new HomeVM
            {
                Categories = Categories,
                Series = Series,
                Total = 10,
                Skip = 20,
                Limit = 30
            };
            //return Json(model);
            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
