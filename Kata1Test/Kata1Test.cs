using System;
using Kata1.Kata1Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata1Test
{
    [TestClass]
    public class Kata1Test
    {
        [TestMethod]
        public void WalletContentSimpleTest()
        {
            //Arrange
            Wallet MockWallet = new Wallet(10.90);

            //Act

            //Assert
            Assert.AreEqual(MockWallet.Content, 10.90);
        }

        [TestMethod]
        public void CheckSimpleTransaction()
        {
            //Arrange
            Wallet MockWallet = new Wallet(6.0);

            Item Carrot = new Item(3.01);

            //Act
            MockWallet.Transaction(Carrot);

            //Assert
            Assert.AreEqual(2.99, MockWallet.Content);
        }

        [TestMethod]
        public void CheckMinusPromotion()
        {
            //Arrange
            Wallet MockWallet = new Wallet(1.0);

            Item Banana = new Item(1.0);

            //Act
            Banana.MinusPromotion(0.5);
            MockWallet.Transaction(Banana);

            //Assert
            Assert.AreEqual(0.5, MockWallet.Content);
        }

        [TestMethod]
        public void CheckPercentPromotion()
        {
            //Arrange
            Wallet MockWallet = new Wallet(1.0);
            Item Fruit = new Item(1.0);

            //Act
            Fruit.PercentPromotion(10);
            MockWallet.Transaction(Fruit);

            //Assert
            Assert.AreEqual(0.1, MockWallet.Content, 0.0001);
        }
    }
}
