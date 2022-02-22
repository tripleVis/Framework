using OpenQA.Selenium;
using System.Collections.Generic;
using TraderBox.io.Util;

namespace TraderBox.io.Pages
{
    class QuizPage : Page
    {
        private By firstAnswerOnFirstQuestionLocator = By.XPath("//label[@for = 'qa-1_1']");
        private By firstAnswerOnSecondQuestionLocator = By.XPath("//label[@for = 'qa-2_1']");
        private By firstAnswerOnThirdQuestionLocator = By.XPath("//label[@for = 'qa-3_1']");
        private By firstAnswerOnFourthQuestionLocator = By.XPath("//label[@for = 'qa-4_1']");
        private By firstAnswerOnFifthQuestionLocator = By.XPath("//label[@for = 'qa-5_1']");
        private By firstAnswerOnSixthQuestionLocator = By.XPath("//label[@for = 'qa-6_1']");
        private By firstAnswerOnSeventhQuestionLocator = By.XPath("//label[@for = 'qa-7_1']");
        private By nextBtnsLocator = By.XPath("//a[@class = 'button-quiz w-button']");
        private By sendResultsOfQuizBtnLocator = By.XPath("//button[@class = 'button-quiz w-button js-track']");

        public QuizPage(IWebDriver driver) : base(driver)
        {
        }

        public QuizPage ChooseFirstAnswerOnFirstQuestion()
        {
            IWebElement firstQuestion = FindElementWithWaitElementToBeClickable(firstAnswerOnFirstQuestionLocator, 600);
            firstQuestion.Click();

            Log.Info("First answer on first question is chosen");

            return this;
        }

        public QuizPage ClickNextOnFirstQuestion()
        {
            List<IWebElement> nextBtns = GetElements(nextBtnsLocator);
            nextBtns[0].Click();

            Log.Info("Next button on first question is clicked");

            return this;
        }

        public QuizPage ChooseFirstAnswerOnSecondQuestion()
        {
            IWebElement firstQuestion = FindElementWithWaitElementToBeClickable(firstAnswerOnSecondQuestionLocator, 600);
            firstQuestion.Click();

            Log.Info("First answer on second question is chosen");

            return this;
        }

        public QuizPage ClickNextOnSecondQuestion()
        {
            List<IWebElement> nextBtns = GetElements(nextBtnsLocator);
            nextBtns[1].Click();

            Log.Info("Next button on second question is clicked");

            return this;
        }

        public QuizPage ChooseFirstAnswerOnThirdQuestion()
        {
            IWebElement firstQuestion = FindElementWithWaitElementToBeClickable(firstAnswerOnThirdQuestionLocator, 600);
            firstQuestion.Click();

            Log.Info("First answer on third question is chosen");

            return this;
        }

        public QuizPage ClickNextOnThirdQuestion()
        {
            List<IWebElement> nextBtns = GetElements(nextBtnsLocator);
            nextBtns[2].Click();

            Log.Info("Next button on third question is clicked");

            return this;
        }

        public QuizPage ChooseFirstAnswerOnFourthQuestion()
        {
            IWebElement firstQuestion = FindElementWithWaitElementToBeClickable(firstAnswerOnFourthQuestionLocator, 600);
            firstQuestion.Click();

            Log.Info("First answer on fourth question is chosen");

            return this;
        }

        public QuizPage ClickNextOnFourthQuestion()
        {
            List<IWebElement> nextBtns = GetElements(nextBtnsLocator);
            nextBtns[3].Click();

            Log.Info("Next button on fourth question is clicked");

            return this;
        }

        public QuizPage ChooseFirstAnswerOnFifthQuestion()
        {
            IWebElement firstQuestion = FindElementWithWaitElementToBeClickable(firstAnswerOnFifthQuestionLocator, 600);
            firstQuestion.Click();

            Log.Info("First answer on fifth question is chosen");

            return this;
        }

        public QuizPage ClickNextOnFifthQuestion()
        {
            List<IWebElement> nextBtns = GetElements(nextBtnsLocator);
            nextBtns[4].Click();

            Log.Info("Next button on fifth question is clicked");

            return this;
        }

        public QuizPage ChooseFirstAnswerOnSixthQuestion()
        {
            IWebElement firstQuestion = FindElementWithWaitElementToBeClickable(firstAnswerOnSixthQuestionLocator, 600);
            firstQuestion.Click();

            Log.Info("First answer on sixth question is chosen");

            return this;
        }

        public QuizPage ClickNextOnSixthQuestion()
        {
            List<IWebElement> nextBtns = GetElements(nextBtnsLocator);
            nextBtns[5].Click();

            Log.Info("Next button on sixth question is clicked");

            return this;
        }

        public QuizPage ChooseFirstAnswerOnSeventhQuestion()
        {
            IWebElement firstQuestion = FindElementWithWaitElementToBeClickable(firstAnswerOnSeventhQuestionLocator, 600);
            firstQuestion.Click();

            Log.Info("First answer on seventh question is chosen");

            return this;
        }

        public QuizPage ClickNextOnSeventhQuestion()
        {
            List<IWebElement> nextBtns = GetElements(nextBtnsLocator);
            nextBtns[6].Click();

            Log.Info("Next button on seventh question is clicked");

            return this;
        }

        public IWebElement GetButtonOfSendingQuizResults()
        {
            return FindElementWithWaitElementToBeClickable(sendResultsOfQuizBtnLocator, 600);
        }
    }
}
