using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LAB_1_PER_3.Tests
{
    [TestClass]
    public class LAB_1_PER_3Tests
    {
        [TestMethod]
        public void MoveInnerClock_1_0_dot_2()
        {
            // arange
            Flower flower = new Flower("Мак", (Color)1, 5, 12, 5000);
            decimal expected = 0.2M;

            // actual
            flower.MoveInnerClock(4);
            decimal actually = (decimal)(flower.State);

            // assert
            Assert.AreEqual(expected, actually);
        }
        [TestMethod]
        public void RealPrice_5000_1000()
        {
            // arange
            Flower flower = new Flower("Ромашка", (Color)1, 5, 12, 5000);
            decimal expected = 1000M;
            // actual
            flower.MoveInnerClock(4);
            decimal actually = (decimal)(flower.RealPrice());
            // assert
            Assert.AreEqual(expected, actually);
        }
        [TestMethod]
        public void GetBasePrice_149_149()
        {
            // arange
            Bouqet bouquet = new Bouqet();
            Flower flower = new Flower();
            bouquet.AddFlower("Ромашка", Color.Red, 5, 12, 123);
            bouquet.AddFlower("Роза", Color.Blue, 4, 3, 23);
            bouquet.AddFlower("Лилия", Color.Green, 6, 3, 3);
            decimal expected = 149M;
            // actual
            decimal actually=(decimal)(bouquet.GetBasePrice()); 
            // assert
            Assert.AreEqual(expected,actually);
        }
        [TestMethod]
        public void GetRealPrice_15000_3000()
        {
            //arange
            Bouqet bouquet = new Bouqet();
            Flower flower = new Flower();
            bouquet.AddFlower("Ромашка", Color.Red, 5,12, 5000);
            bouquet.AddFlower("Роза", Color.Blue, 5, 8, 5000);
            bouquet.AddFlower("Лилия", Color.Green, 5, 3, 5000);
            decimal expected = 3000M;
            //actual
            bouquet.MoveInnerClock(4);
            decimal actually=(decimal)(bouquet.GetRealPrice());
            //assert
            Assert.AreEqual(expected, actually);
        }
        [TestMethod]
        public void NumOfWithered_4_2()
        {
            //arange
            Bouqet bouquet = new Bouqet();
            Flower flower = new Flower();
            bouquet.AddFlower("Ромашка", Color.Red, 8, 12, 5000);
            bouquet.AddFlower("Роза", Color.Blue, 2, 8, 5000);
            bouquet.AddFlower("Лилия", Color.Green, 124, 3, 5000);
            bouquet.AddFlower("Хризантема", Color.Green, 3, 3, 5000);
            int expected = 2;
            //actual
            bouquet.MoveInnerClock(5);
            int actually = bouquet.NumOfWithered();
            //assert
            Assert.AreEqual(expected, actually);   
        }
        [TestMethod]
        public void GetState_1_0_dot_25()
        {
            //arange
            Bouqet bouquet = new Bouqet();
            Flower flower = new Flower();
            bouquet.AddFlower("Ромашка", Color.Red, 8, 12, 5000);
            bouquet.AddFlower("Роза", Color.Blue, 2, 8, 5000);
            decimal expected = 0.25M;
            //actual
            bouquet.MoveInnerClock(4);
            decimal actually = (decimal)(bouquet.GetState());
            //assert
            Assert.AreEqual(expected, actually);
        }
    }
}
