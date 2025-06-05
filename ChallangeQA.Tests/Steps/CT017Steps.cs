using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using FluentAssertions;

// Validar formato do email inválido
namespace ChallangeQA.Steps
{
    [Binding]
    public class CT017Steps
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public CT017Steps()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [Given(@"que o usuário informe os dados cadastrais")]
         public void GivenQueOUsuarioInformeOsDadosCadastrais()
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
                        var comboCurso = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='graduation-combo']"))
            );
            comboCurso.Click();

            var cursoInput = wait.Until(d =>
             d.FindElement(By.CssSelector("input.h-9"))         
            );
                cursoInput.Click();
                cursoInput.SendKeys("Engenharia de Software");
                cursoInput.SendKeys(Keys.Enter);
            
            var botaoAvancar = wait.Until(d =>
               d.FindElement(By.CssSelector("button.inline-flex.items-center.justify-center.bg-primary"))
             );
                 botaoAvancar.Click();
        }

        [When(@"preencher o campo email com o valor invalido")]
        public void WhenPreencherOCampoEmailComOValorInvalido()
        {
            var cpfInput = wait.Until(d => 
            d.FindElement(By.CssSelector("[data-testid='cpf-input']")));
            cpfInput.SendKeys("11495607623");

            var nomeInput = wait.Until(d => 
            d.FindElement(By.CssSelector("[data-testid='name-input']")));
            nomeInput.SendKeys("Jéssica");

            var sobrenomeInput = wait.Until(d => 
            d.FindElement(By.CssSelector("[data-testid='surname-input']")));
            sobrenomeInput.SendKeys("Martins");

            var emailInput = wait.Until(d => 
            d.FindElement(By.CssSelector("[data-testid='email-input']")));
            emailInput.SendKeys("teste.com.br");

            var celularInput = wait.Until(d => 
            d.FindElement(By.CssSelector("[data-testid='cellphone-input']")));
            celularInput.SendKeys("31975000000");

            var telefoneInput = wait.Until(d => 
            d.FindElement(By.CssSelector("[data-testid='phone-input']")));
            telefoneInput.SendKeys("3132320032");

            var cepInput = wait.Until(d => 
            d.FindElement(By.CssSelector("[data-testid='cep-input']")));
            cepInput.SendKeys("30330000");

            var enderecoInput = wait.Until(d => 
            d.FindElement(By.CssSelector("[data-testid='address-input']")));
            enderecoInput.SendKeys("Rua A");

            var complementoInput = wait.Until(d => 
            d.FindElement(By.CssSelector("[data-testid='complement-input']")));
            complementoInput.SendKeys("");

            var bairroInput = wait.Until(d => 
            d.FindElement(By.CssSelector("[data-testid='neighborhood-input']")));
            bairroInput.SendKeys("São Pedro");

            var cidadeInput = wait.Until(d => 
            d.FindElement(By.CssSelector("[data-testid='city-input']")));
            cidadeInput.SendKeys("Belo Horizonte");

            var estadoInput = wait.Until(d => 
            d.FindElement(By.CssSelector("[data-testid='state-input']")));
            estadoInput.SendKeys("Belo Horizonte");

            var paisInput = wait.Until(d => 
            d.FindElement(By.CssSelector("[data-testid='country-input']")));
            paisInput.SendKeys("Brasil");
        }

        [Then(@"uma mensagem de alerta deve ser exibida informando Email inválido")]
        public void ThenUmaMensagemDeAlertaDeveSerExibidaInformandoEmailInvalido()

        {
            var botaoAvancar = wait.Until(d => d.FindElement(By.CssSelector("[data-testid='next-button']")));
            botaoAvancar.Click();

            var alertaEmail = wait.Until(d => 
            d.FindElement(By.XPath("//p[@role='alert' and contains(text(), 'Email inválido')]"))
            );
            alertaEmail.Text.Should().Contain("Email inválido");
        }
    

        [AfterScenario]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
        
}