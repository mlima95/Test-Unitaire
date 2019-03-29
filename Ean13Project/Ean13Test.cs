using Ean13Project;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Ean13Project
{


    /// <summary>
    ///Classe de test pour Ean13Test, destinée à contenir tous
    ///les tests unitaires Ean13Test
    ///</summary>
    [TestClass()]
    public class Ean13Test
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Test pour Constructeur Ean13
        ///</summary>
        [TestMethod()]
        public void Ean13ConstructorTest_13()
        {
            try
            {
                Ean13 target = new Ean13(new int[] { 4, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8, 8, 0 });
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "Un code Ean 13 doit être un tableau de 12 entiers");
                return;
            }
            Assert.Fail("Aucune exception n'a été soulevée");
        }

        [TestMethod()]
        public void Ean13ConstructorTest_11()
        {
            try
            {
                Ean13 target = new Ean13(new int[] { 4, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8 });
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "Un code Ean 13 doit être un tableau de 11 entiers");
                return;
            }
            Assert.Fail("Aucune exception n'a été soulevée");
        }

        [TestMethod()]
        public void Ean13ConstructorTest_09()
        {
            try
            {
                Ean13 target = new Ean13(new int[] { 4, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8,140 });
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "Un élément du gencode n'est pas compris entre 0 et 9");
                return;
            }
            Assert.Fail("Aucune exception n'a été soulevée");
        }

        /// <summary>
        ///Test pour Cle
        ///</summary>
        [TestMethod()]
        public void CleTest()
        {
            Ean13 target = new Ean13(new int[] { 4, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8, 8 });
            int expected = 9;
            int actual;
            actual = target.Cle();
            Assert.AreEqual(expected, actual);
        }
        // [TestMethod()]
       // public void CleTest_0()
        //{
        //    Ean13 target = new Ean13(new int[] { 4, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8, 8 });
        //    int expected = 0;
          //  int actual;
         //   actual = target.Cle();
          //  Assert.AreEqual(expected, actual);
       // }

        /// <summary>
        ///Test pour PoidsImpair
        ///</summary>
        [TestMethod()]
        public void PoidsImpairTest()
        {
            Ean13 target = new Ean13(new int[] { 4, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8, 8 });
            int expected = 20;
            int actual;
            actual = target.PoidsImpair();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test pour PoidsPair
        ///</summary>
        [TestMethod()]
        public void PoidsPairTest()
        {
            Ean13 target = new Ean13(new int[] { 4, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8, 8 });
            int expected = 81;
            int actual;
            actual = target.PoidsPair();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test pour Reste
        ///</summary>
        [TestMethod()]
        public void ResteTest()
        {
            Ean13 target = new Ean13(new int[] { 4, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8, 8 });
            int expected = 1;
            int actual;
            actual = target.Reste();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test pour ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            Ean13 target = new Ean13(new int[] { 4, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8, 8 });
            string expected = "4719-5120-0288-9";
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
