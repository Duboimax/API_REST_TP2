using Microsoft.VisualStudio.TestTools.UnitTesting;
using API_REST_TP2.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_REST_TP2.Models.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace API_REST_TP2.Controllers.Tests
{
    [TestClass()]
    public class SeriesControllerTests
    {
        [TestMethod()]
        public void SeriesControllerTest()
        {
           Assert.Fail();
        }

        [TestMethod()]
        public void GetSeriesTest()
        {
            var builder = new DbContextOptionsBuilder<SeriesDbContext>().UseNpgsql("Server=localhost;port=5432;Database=SeriesDB; uid=postgres; password=postgres;"); // Chaine de connexion à mettre dans les ( )
            SeriesDbContext context = new SeriesDbContext(builder.Options);

            SeriesController controller = new SeriesController(context);
            var maListe = controller.GetSeries().Result.Value.ToList();
            Assert.AreEqual(3, maListe.Where(s => s.Serieid <= 3).Count());
        }

        [TestMethod()]
        public void GetSerieTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PutSerieTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PostSerieTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteSerieTest()
        {
            var builder = new DbContextOptionsBuilder<SeriesDbContext>().UseNpgsql("Server=localhost;port=5432;Database=SeriesDB; uid=postgres; password=postgres;"); // Chaine de connexion à mettre dans les ( )
            SeriesDbContext context = new SeriesDbContext(builder.Options);

            SeriesController controller = new SeriesController(context);
            var result = controller.DeleteSerie(2);

           
            
        }
    }
}