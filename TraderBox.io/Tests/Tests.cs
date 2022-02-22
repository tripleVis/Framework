using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TraderBox.io.Pages;

namespace TraderBox.io.Tests
{
    [TestFixture]
    public class MainPageTests : CommonConditions
    {
        [TestCase(5)]
        public void BuyPolkadotsTest(int testValueForDots)
        {
            string expectedNumberOfDots = mainPage.CloseWindowWithMessageAboutSettingUpTwoFactorAuthentication()
                .ViewCoinsOfDemoAcc()
                .GetExpectedNumberOfDots(testValueForDots);
            string finishNumberOfDotsBeforeDotIndex = mainPage.SearchForAllPolkadotTradingPairs()
                .ChooseDotBtcTradingPair()
                .InputNumberOfDots(Convert.ToString(testValueForDots))
                .SubmitCurrnecyExchange()
                .GetFinishNumberOfDots();

            Assert.That(finishNumberOfDotsBeforeDotIndex, Is.EqualTo(expectedNumberOfDots));
        }

        [Test]
        public void OpenFullscreenModTest()
        {
            IWebElement fullscreenMod = mainPage.CloseWindowWithMessageAboutSettingUpTwoFactorAuthentication()
            .OpenFullscreenMod()
            .GetFullscreenModeOpen();

            Assert.That(fullscreenMod, Is.Not.Null);
        }

    }

    [TestFixture]
    public class ProfilePageTests : CommonConditions
    {
        [Test]
        public void ChangeThemeOnLightTest()
        {
            ProfilePage themeSwitch = mainPage.CloseWindowWithMessageAboutSettingUpTwoFactorAuthentication()
            .GoToProfilePage()
            .ChooseLightTheme();

            Assert.Multiple(() =>
            {
                Assert.That(themeSwitch.GetNotActiveDarkThemeSwitchText(), Is.Not.Null);
                Assert.That(themeSwitch.GetActiveLightThemeSwitchText(), Is.Not.Null);
            });
        }


        [Test]
        public void ChangeLanguageOnEnglishTest()
        {
            ProfilePage langChanger = mainPage.CloseWindowWithMessageAboutSettingUpTwoFactorAuthentication()
            .GoToProfilePage()
            .GoToProfileMenu()
            .ChangeLanguageOnEnglish();

            Assert.That(langChanger.GetUSLangIconOnMainHeader, Is.Not.Null);
        }
    }

    [TestFixture]
    public class OtherPagesTests : CommonConditions
    {
        [Test]
        public void OpenHelpInformationTest()
        {
            IWebElement answerOnFirstQuetion = mainPage.CloseWindowWithMessageAboutSettingUpTwoFactorAuthentication()
                .GoToHelpPage()
                .ChooseFirstQuestion()
                .GetAnswerOnFirstQuetion();

            Assert.That(answerOnFirstQuetion, Is.Not.Null);
        }

        [Test]
        public void ChooseTariffWithBigDiscountTest()
        {
            IWebElement chosenTariffWithBigDiscount = mainPage.CloseWindowWithMessageAboutSettingUpTwoFactorAuthentication()
                .GoToHelpPage()
                .GoToTariffPage()
                .ChooseTariffWithBigDiscount()
                .GetChosenTariffWithBigDiscount();

            Assert.That(chosenTariffWithBigDiscount, Is.Not.Null);
        }

        [Test]
        public void OpenInstructionalInformationTest()
        {
            IWebElement answerOnSecondInstructionalQuetion = mainPage.CloseWindowWithMessageAboutSettingUpTwoFactorAuthentication()
                .GoToHelpPage()
                .GoToInstructionPage()
                .ChooseSecondInstructionalQuestion()
                .GetAnswerOnSecondInstructionalQuetion();

            Assert.That(answerOnSecondInstructionalQuetion, Is.Not.Null);
        }

        [Test]
        public void PassQuizTest()
        {
            IWebElement buttonOfSendingQuizResults = mainPage.CloseWindowWithMessageAboutSettingUpTwoFactorAuthentication()
                .GoToHelpPage()
                .GoToQuizPage()
                .ChooseFirstAnswerOnFirstQuestion()
                .ClickNextOnFirstQuestion()
                .ChooseFirstAnswerOnSecondQuestion()
                .ClickNextOnSecondQuestion()
                .ChooseFirstAnswerOnThirdQuestion()
                .ClickNextOnThirdQuestion()
                .ChooseFirstAnswerOnFourthQuestion()
                .ClickNextOnFourthQuestion()
                .ChooseFirstAnswerOnFifthQuestion()
                .ClickNextOnFifthQuestion()
                .ChooseFirstAnswerOnSixthQuestion()
                .ClickNextOnSixthQuestion()
                .ChooseFirstAnswerOnSeventhQuestion()
                .ClickNextOnSeventhQuestion()
                .GetButtonOfSendingQuizResults();

            Assert.That(buttonOfSendingQuizResults, Is.Not.Null);
        }
    }
}
