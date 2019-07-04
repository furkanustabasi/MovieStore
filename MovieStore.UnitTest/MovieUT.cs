using System;
using MovieStore.Service;
using MovieStore.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MovieStore.UnitTest
{
    [TestClass]
    public class MovieUT 
    {
        private MovieService movieService;
        
        [TestInitialize]
        public void Setup()
        {
            movieService = new MovieService();
        }

        [TestMethod]
        public void Save()
        {
            MovieDTO movie = new MovieDTO
            {
               MovieName="organize işler",
               GenreId=2,
               DirectorName="yılmaz erdoğan",
               ReleaseDate=new DateTime(2019,3,1),
               ImdbScore=6,
               Quantity=50,
               UnitPrice=20,
               RecordStatusId=1,
               CreatedDate=DateTime.Now,
               CreatedBy=2
            };
            movie.ActorList = new System.Collections.Generic.List<MovieActorDTO>();
            MovieActorDTO actor1 = new MovieActorDTO
            {
                 FullName="kıvanç tatlıtuğ"

            };
            MovieActorDTO actor2 = new MovieActorDTO
            {
                FullName = "yılmaz erdoğan"

            };

            movie.ActorList.Add(actor1);
            movie.ActorList.Add(actor2);

            var result = movieService.Add(movie);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Update()
        {
            MovieDTO movie = new MovieDTO
            {
                MovieId=1,
                MovieName = "organize işler",
                GenreId = 2,
                DirectorName = "yılmaz erdoğan",
                ReleaseDate = new DateTime(2019, 3, 1),
                ImdbScore = 6,
                Quantity = 20,
                UnitPrice = 9,
                RecordStatusId = 1,
                CreatedDate = DateTime.Now,
                CreatedBy = 2,
                ModifiedBy=3,
                ModifiedDate=DateTime.Now
            };

            var result = movieService.Update(movie);

            Assert.IsTrue(result);

        }
        [TestMethod]
        public void List()
        {
            var result = movieService.List();
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Get()
        {
            int id = 1;
            var result = movieService.Get(id);
            Assert.IsNotNull(result);
        }
    }
}
