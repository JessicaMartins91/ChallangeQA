Feature: Validação da aplicação MaisA
@ignore
 Scenario: CT001: Exibir opções ao selecionar graduação
  Given que o usuário esteja na tela de seleção de nível de graduação
  When selecionar a opção Graduação e clicar
  Then deve ser exibida a modal Selecione seu curso de graduação
@ignore
  Scenario: CT002: Confirmar seleção do curso de graduação
  Given que o usuário clique para selecionar curso
  When pesquisar o curso Engenharia de Software
  Then o curso Engenharia de Software deve ser exibido como selecionado
@ignore
  Scenario: CT003: Avançar após preencher todos os campos obrigatórios do cadastro
  Given que o usuário preencha o nível e o curso de graduação
  When tenha preenchido todos os campos obrigatórios do formulário de cadastro
  Then ao clicar em 'Avançar' deve ser direcionado para a tela que informa seu usuário e senha.
@ignore
  Scenario: CT004: Avançar sem preencher todos os campos obrigatórios do cadastro
  Given que o usuário tenha preenchido o nível e o curso de graduação
  When tenha preenchido os campos obrigatórios do formulário de cadastro exceto CPF
  Then ao clicar em avançar uma mensagem de alerta deve ser exibida informando que o campo é obrigatório.
  
  Scenario: CT005: Avançar sem preencher apenas o campo nome
  Given que o usuário tenha preenchido o nível e o curso de graduação
  When tenha preenchido os campos obrigatórios do formulário de cadastro exceto Nome
  Then ao clicar em avançar uma mensagem de alerta deve ser exibida informando que o campo é obrigatório.





