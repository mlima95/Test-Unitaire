using Ean13;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Ean13Test
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
        ///Test pour ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            int[] ean13 = null; // TODO: initialisez à une valeur appropriée
            Ean13 target = new Ean13(ean13); // TODO: initialisez à une valeur appropriée
            string expected = string.Empty; // TODO: initialisez à une valeur appropriée
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour Reste
        ///</summary>
        [TestMethod()]
        public void ResteTest()
        {
            int[] ean13 = null; // TODO: initialisez à une valeur appropriée
            Ean13 target = new Ean13(ean13); // TODO: initialisez à une valeur appropriée
            int expected = 0; // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.Reste();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour PoidsPair
        ///</summary>
        [TestMethod()]
        public void PoidsPairTest()
        {
            int[] ean13 = null; // TODO: initialisez à une valeur appropriée
            Ean13 target = new Ean13(ean13); // TODO: initialisez à une valeur appropriée
            int expected = 0; // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.PoidsPair();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour PoidsImpair
        ///</summary>
        [TestMethod()]
        public void PoidsImpairTest()
        {
            int[] ean13 = null; // TODO: initialisez à une valeur appropriée
            Ean13 target = new Ean13(ean13); // TODO: initialisez à une valeur appropriée
            int expected = 0; // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.PoidsImpair();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour Cle
        ///</summary>
        [TestMethod()]
        public void CleTest()
        {
            int[] ean13 = null; // TODO: initialisez à une valeur appropriée
            Ean13 target = new Ean13(ean13); // TODO: initialisez à une valeur appropriée
            int expected = 0; // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.Cle();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour Constructeur Ean13
        ///</summary>
        [TestMethod()]
        public void Ean13ConstructorTest()
        {
            int[] ean13 = null; // TODO: initialisez à une valeur appropriée
            Ean13 target = new Ean13(ean13);
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }
    }
}
