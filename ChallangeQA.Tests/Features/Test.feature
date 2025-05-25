Feature: Validação da aplicação MaisA

 Scenario: CT001: Exibir opções ao selecionar graduação
  Given que o usuário esteja na tela de seleção de nível de graduação
  When selecionar a opção Graduação e clicar
  Then deve ser exibida a modal Selecione seu curso de graduação

  Scenario: CT002: Confirmar seleção do curso de graduação
  Given que o usuário clique para selecionar curso
  When pesquisar o curso Engenharia de Software
  Then o curso Engenharia de Software deve ser exibido como selecionado
