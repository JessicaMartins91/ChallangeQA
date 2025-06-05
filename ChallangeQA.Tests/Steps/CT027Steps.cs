using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using FluentAssertions;
using Xunit;


//Acessar com credenciais invalidas
namespace ChallangeQA.Steps
{
    [Binding]
    public class CT027Steps
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public CT027Steps()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }
    
        [Given(@"que o usuário avançou todas as etapas de cadastrais")]
        public void GivenQueOUsuarioAvancouTodasAsEtapasCadastrais()
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
                d.FindElement(By.CssSelector("[data-testid='next-button']")));
            botaoAvancar.Click();

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
            emailInput.SendKeys("jessica@teste.com.br");

            var celularInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='cellphone-input']")));
            celularInput.SendKeys("31975030000"); 

            var telefoneInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='phone-input']")));
            telefoneInput.SendKeys("3132320032");

            var cepInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='cep-input']")));
            cepInput.SendKeys("30330000");

            var enderecoInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='address-input']")));
            enderecoInput.SendKeys("Rua A");

            var bairroInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='neighborhood-input']")));
            bairroInput.SendKeys("São Pedro");

            var cidadeInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='city-input']")));
            cidadeInput.SendKeys("Belo Horizonte");

            var estadoInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='state-input']")));
            estadoInput.SendKeys("Minas Gerais");

            var paisInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='country-input']")));
            paisInput.SendKeys("Brasil");

            var botaoAvancarParaLogin = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='next-button']")));
            botaoAvancarParaLogin.Click();
        }
    
        [When(@"avançar para tela area do candidato")]
        public void WhenAvancarParaTelaAreaDoCandidato()
        {
            var acessarAreaCandidato = wait.Until(d => 
                d.FindElement(By.CssSelector("[data-testid='next-button']")));
                acessarAreaCandidato.Click();
        }

        [Then(@"ao informar login e senha incorretos deve exibir alerta informado credenciais invalidas")]
        public void ThenAoInformarLoginESenhaIncorretosDeveExibirAlertaInformandoCredenciaisInvalidas()
        {
            var informarLogin = wait.Until(d => 
                    d.FindElement(By.CssSelector("[data-testid='username-input']")));
                    informarLogin.SendKeys("candidat@");

                var informarSenha = wait.Until(d =>
                    d.FindElement(By.CssSelector("[data-testid='password-input']")));
                    informarSenha.SendKeys("subscripti@n");

                var botaoLogin = wait.Until(d =>
                    d.FindElement(By.CssSelector("[data-testid='login-button']")));
                    botaoLogin.Click();
                
                var alertaUsuarioInvalido = wait.Until(d =>
                    d.FindElement(By.XPath("//p[@role='alert' and contains(text(), 'Usuário inválido')]"))
            );
                   alertaUsuarioInvalido.Text.Should().Contain("Usuário inválido");
                
                var alertaSenhaInvalida = wait.Until(d =>
                     d.FindElement(By.XPath("//p[@role='alert' and contains(text(), 'Senha inválida')]"))
            );
                    alertaSenhaInvalida.Text.Should().Contain("Senha inválida");
        }
        
        [AfterScenario]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}