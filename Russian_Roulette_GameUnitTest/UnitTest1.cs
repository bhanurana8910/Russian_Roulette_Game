using System;
using Russian_Roulette_Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Russian_Roulette_GameUnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            RussianRoulette russianRoulette = new RussianRoulette();
            russianRoulette.SpinChamber();
            russianRoulette.LoadGun();
            Assert.IsTrue(russianRoulette.IsGunSpunAndLoaded());
        }

        [TestMethod]
        public void TestMaxAwayChoices()
        {
            RussianRoulette russianRoulette = new RussianRoulette();
            russianRoulette.SpinChamber();
            russianRoulette.LoadGun();
            russianRoulette.PlayArea = new Russian_Roulette_Game.view.PlayArea();

            int awayChoices = 0;

            while (true)
            {
                awayChoices++;
                if (russianRoulette.FireShot(true))
                {
                    break;
                }
            }

            bool result = awayChoices <= 2;

            Assert.IsTrue(result);
        }
    }
}
