using CoreMVC_1_MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC_1_MovieApp.Data
{
    public static class MovieRepository
    {
        private static readonly List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie
                {
                    Id = 1,
                    Name = "The Lord Of The Rings: The Return of The King",
                    ShortDescription = "The Lord Of The Rings: The Return of The King",
                    Description = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec a enim libero. Curabitur eu lacus tristique, porta diam ac, ultricies velit. Pellentesque et augue quis velit laoreet tempor. Suspendisse potenti. Phasellus lectus enim, mollis eu nibh et, tincidunt fermentum dui. Morbi vel tincidunt risus, sit amet sodales neque. Nulla eu orci ut mauris fringilla congue sed fringilla mi.</p>",
                    ImageUrl = "1.jpg",
                    CategoryId = 13
                },
                new Movie { 
                    Id = 2,
                    Name = "The Matrix Revolutions",
                    ShortDescription = "The Matrix Revolutions",
                    Description = "<p>Nunc vitae quam in ex ornare iaculis id eu lacus. Pellentesque rhoncus eget nunc a vehicula. Vivamus lacinia urna id porta facilisis. Suspendisse commodo et odio at tempus. Cras venenatis sem vitae tellus rutrum ultricies. Curabitur egestas purus non semper dictum. Mauris ac quam sed sem molestie hendrerit ut nec odio.</p>",
                    ImageUrl = "2.jpg",
                    CategoryId = 1
                },
                new Movie
                { 
                    Id = 3,
                    Name = "The Expendables",
                    ShortDescription = "The Expendables",
                    Description = "<p>Nam condimentum arcu at venenatis lacinia. Aliquam tellus dolor, tincidunt nec aliquet ac, sagittis nec metus. Morbi quis arcu sed urna consectetur pellentesque. Quisque efficitur sapien quis ultricies varius. Nam velit augue, fermentum congue dui sit amet, maximus venenatis nisl. Nam rutrum dapibus eros, non volutpat nulla malesuada sodales.</p>",
                    ImageUrl = "3.jpg",
                    CategoryId = 1
                },
                new Movie
                {
                    Id = 4,
                    Name = "1408",
                    ShortDescription = "1408",
                    Description = "<p>Proin porta, massa non ornare elementum, lorem nisi ultricies leo, sit amet maximus lacus risus eu odio. Aliquam ut eros sit amet mauris rhoncus dignissim. Suspendisse volutpat tortor ac mauris gravida sagittis. In mattis varius nunc at lacinia. Fusce ultricies varius tortor, nec porttitor magna sodales eu.</p>",
                    ImageUrl = "4.jpg",
                    CategoryId = 3
                },
                new Movie
                {
                    Id = 5,
                    Name = "Doom",
                    ShortDescription = "Doom",
                    Description = "<p>Maecenas augue dui, porta ut tempus porttitor, faucibus non risus. Etiam venenatis, ex ultricies dignissim commodo, risus odio molestie dolor, vitae ultricies nisl mauris eget eros. Nulla placerat ipsum vitae dui aliquet dapibus. Nunc euismod tellus sit amet lobortis fringilla. Pellentesque venenatis lacus odio, sodales congue odio efficitur nec.</p>",
                    ImageUrl = "5.jpg",
                    CategoryId = 1
                },
                new Movie
                {
                    Id = 6,
                    Name = "Silent Hill",
                    ShortDescription = "Silent Hill",
                    Description = "<p>Duis sagittis quam ac libero volutpat aliquet. Proin risus nulla, mattis in volutpat id, dapibus ut mauris. Proin sed neque metus. Praesent ex purus, consectetur et libero vestibulum, commodo feugiat felis.</p>",
                    ImageUrl = "6.jpg",
                    CategoryId = 3
                },
                new Movie
                {
                    Id = 7,
                    Name = "Resident Evil Vendetta",
                    ShortDescription = "Resident Evil Vendetta",
                    Description = "<p>Vestibulum mauris risus, vehicula id sem sed, feugiat vehicula orci. Ut porta felis nisi, nec hendrerit arcu gravida a. Maecenas ut lectus et augue efficitur volutpat. Duis ut ornare dui, et malesuada ex. Cras at purus dui. Etiam vitae ipsum placerat, tincidunt metus quis, varius lectus.</p>",
                    ImageUrl = "7.jpg",
                    CategoryId = 4
                },
                new Movie
                {
                    Id = 8,
                    Name = "Zombieland Double Tap",
                    ShortDescription = "Zombieland Double Tap",
                    Description = "<p>Aliquam in ex malesuada, eleifend justo ac, dapibus massa. Etiam ultrices ultricies vehicula. Vivamus mollis sollicitudin lorem eget fermentum. Donec in mattis velit, non condimentum erat. Sed malesuada blandit tristique. Proin lobortis laoreet fringilla. In hac habitasse platea dictumst.</p>",
                    ImageUrl = "8.jpg",
                    CategoryId = 5
                },
                new Movie
                {
                    Id = 9,
                    Name = "I am Legend",
                    ShortDescription = "I am Legend",
                    Description = "<p>Suspendisse potenti. In laoreet dignissim nisi, viverra sodales dolor tincidunt ac. Fusce orci massa, suscipit at efficitur vel, mattis in velit. Interdum et malesuada fames ac ante ipsum primis in faucibus. Mauris ut magna id diam rhoncus convallis vitae ut mi. Etiam suscipit accumsan ullamcorper.</p>",
                    ImageUrl = "9.jpg",
                    CategoryId = 2
                },
                new Movie
                {
                    Id = 10,
                    Name = "Avengers: Infinity War",
                    ShortDescription = "Avengers: Infinity War",
                    Description = "<p>Pellentesque vel imperdiet urna, non mollis est. Donec fermentum, neque quis euismod aliquam, nunc sapien porttitor magna, vel rhoncus ligula turpis at magna. Nullam vitae purus eu dolor rutrum pellentesque ac et nisi. Mauris dapibus ex erat, eget auctor libero interdum id.</p>",
                    ImageUrl = "10.jpg",
                    CategoryId = 1
                }
            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}