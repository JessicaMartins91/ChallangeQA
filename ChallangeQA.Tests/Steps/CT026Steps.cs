using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using FluentAssertions;
using Xunit;


// Acessar com credenciais válidas
namespace ChallangeQA.Steps
{
    [Binding]
    public class CT026Steps
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public CT026Steps()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }

        [Given(@"que o usuário tenha realizado o cadastro")]
        public void GivenQueOUsuarioTenhaRealizadoOCadastro()
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

        [When(@"clicar no botão acessar área do candidato")]
        public void WhenClicarNoBotaoAcessarAreaDoCandidato()
            {
                var acessarAreaCandidato = wait.Until(d => 
                    d.FindElement(By.CssSelector("[data-testid='next-button']")));
                    acessarAreaCandidato.Click();
            }
        
         [Then(@"ao informar login e senha corretamente deve ser direcionado para area do candidato")]
         public void ThenAoInformarLoginESenhaCorretamenteDeveSerDirecionadoParaAreaDoCandidato()
            {
                var informarLogin = wait.Until(d => 
                    d.FindElement(By.CssSelector("[data-testid='username-input']")));
                    informarLogin.SendKeys("candidato");

                var informarSenha = wait.Until(d =>
                    d.FindElement(By.CssSelector("[data-testid='password-input']")));
                    informarSenha.SendKeys("subscription");

                var botaoLogin = wait.Until(d =>
                    d.FindElement(By.CssSelector("[data-testid='login-button']")));
                    botaoLogin.Click();
                
                // Aguarda a página esperada e verifica o conteúdo
                var elemento = wait.Until(d =>
                    d.FindElement(By.CssSelector("h1.text-lg.font-semibold.md\\:text-2xl")));
                    string texto = elemento.Text.Trim();
                    Assert.True(texto.Contains("Bem-vindo, Candidato!"), $"Texto real encontrado: {texto}");
            }
    }
}
