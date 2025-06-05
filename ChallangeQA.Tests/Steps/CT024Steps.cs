using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using FluentAssertions;
using Xunit;


//Retornar para tela selecione seu nível de ensino
namespace ChallangeQA.Steps
{
    [Binding]
    public class CT024Steps
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public CT024Steps()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [Given(@"que o usuário esteja na tela selecione seu curso de Graduação")]
        public void GivenQueOUsuarioEstejaNaTelaSelecioneSeuCursoDeGraduacao()
        {
            driver.Navigate().GoToUrl("https://developer.grupoa.education/subscription/");

            var comboBox = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='education-level-select']"))
            );
                comboBox.Click();

            var opcaoGraduacao = wait.Until(d =>
                d.FindElement(By.XPath("//div[@data-radix-vue-collection-item][contains(., 'Graduação')]"))
            );
                 opcaoGraduacao.Click();
        }

         [When(@"clicar no botão voltar")]
        public void WhenClicarNoBotaoVoltar()
        {
            var botaoVoltar = wait.Until(d =>
                 d.FindElement(By.CssSelector("[data-testid='back-button']"))
            );
                 botaoVoltar.Click();
        } 

        [Then(@"o sistema deve retornar para a tela de Selecione seu nível de ensino")]
         public void ThenOSistemaDeveRetornarParaATelaDeSelecioneSeuNivelDeEnsino()
        {   
            Assert.True(
            driver.PageSource.Contains("Escolha o seu nível de ensino e embarque nessa aventura!"), 
            "O texto esperado foi encontrado na tela."
            );
        }

        [AfterScenario]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
