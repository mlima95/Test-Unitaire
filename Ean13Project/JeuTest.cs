using JeuAGratter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Ean13Project
{


    /// <summary>
    ///Classe de test pour JeuTest, destinée à contenir tous
    ///les tests unitaires JeuTest
    ///</summary>
    [TestClass()]
    public class JeuTest
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
        ///Test pour Constructeur Jeu
        ///</summary>
        [TestMethod()]
        public void JeuConstructorTest()
        {
            Jeu target = new Jeu(new int[,] { { 3, 3, 2 }, { 3, 1, 3 }, { 1, 3, 3 } }); 
        }

        /// <summary>
        ///Test pour Gagne
        ///</summary>
        [TestMethod()]
        public void GagneTest_6()
        {
            Jeu target = new Jeu(new int[,] { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } }); // TODO: initialisez à une valeur appropriée
            int expected = 50; // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.Gagne();
            Assert.AreEqual(expected, actual);
        }

        public void GagneTest_6()
        {
            Jeu target = new Jeu(new int[,] { { 3, 3, 2 }, { 3, 1, 3 }, { 1, 3, 3 } }); // TODO: initialisez à une valeur appropriée
            int expected = 50; // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.Gagne();
            Assert.AreEqual(expected, actual);
        }

        public void GagneTest_diagonale()
        {
            Jeu target = new Jeu(new int[,] { { 3, 2, 2 }, { 2, 3, 3 }, { 1, 3, 3 } }); // TODO: initialisez à une valeur appropriée
            int expected = 100; // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.Gagne();
            Assert.AreEqual(expected, actual);
        }

        public void GagneTest_ligne()
        {
            Jeu target = new Jeu(new int[,] { { 3, 3, 3 }, { 2, 1, 1 }, { 1, 3, 3 } }); // TODO: initialisez à une valeur appropriée
            int expected = 100; // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.Gagne();
            Assert.AreEqual(expected, actual);
        }

        public void GagneTest_colonne()
        {
            Jeu target = new Jeu(new int[,] { { 1, 2, 3 }, { 1, 3, 2 }, { 1, 2, 3 } }); // TODO: initialisez à une valeur appropriée
            int expected = 100; // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.Gagne();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test pour ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            Jeu target = new Jeu(new int[,] { { 3, 3, 2 }, { 3, 1, 3 }, { 1, 3, 3 } }); // TODO: initialisez à une valeur appropriée
            string expected = "332\n313\n133"; // TODO: initialisez à une valeur appropriée
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
