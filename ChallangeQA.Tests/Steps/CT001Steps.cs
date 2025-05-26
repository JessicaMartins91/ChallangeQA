using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace ChallangeQA.Steps
{
    [Binding]
    public class CT001Steps
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public CT001Steps()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
                    // Selecionar o nível de ensiono
        [Given(@"que o usuário esteja na tela de seleção de nível de graduação")]
        public void DadoQueOUsuarioEstejaNaTelaDeSelecaoDeNivelDeGraduacao()
        {
            driver.Navigate().GoToUrl("https://developer.grupoa.education/subscription/");
        }
                // Selecionar a opção graduação
        [When(@"selecionar a opção Graduação e clicar")]
        public void QuandoSelecionarOpcaoGraduacao()
        {
            var comboBox = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='education-level-select']"))
            );
            comboBox.Click();

            var opcaoGraduacao = wait.Until(d =>
                d.FindElement(By.XPath("//div[@data-radix-vue-collection-item][contains(., 'Graduação')]"))
            );
                opcaoGraduacao.Click();
        }
            // Modal selecione se curso deve ser exibida
        [Then(@"deve ser exibida a modal Selecione seu curso de graduação")]
        public void EntaoDeveSerExibidaAModalSelecioneSeuCursoDeGraduacao()
        {
        var modalTitulo = wait.Until(d =>
                d.FindElement(By.XPath("//h2[contains(text(), 'Selecione seu curso de graduação')]"))
    );
                modalTitulo.Displayed.Should().BeTrue();
}
        [AfterScenario]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
}}