# 🐞 Relatório de Bugs

Abaixo está a lista detalhada de bugs encontrados na aplicação, com descrição, passos para reprodução, comportamento esperado e gravidade.

---

### ⚠️ Bug 1: Página inicial pré-seleciona nível graduação e não exibe botão "Avançar"
- **Descrição:** A página inicial carrega com "Graduação" pré-selecionado, mas sem exibir o botão "Avançar".
- **Comportamento Esperado:** Nenhuma opção deve estar pré-selecionada, o botão "Avançar" só deve aparecer após seleção válida.
- **Passos para Reproduzir:** Acessar a página inicial "Escolha o seu nível de ensino e embarque nessa aventura!".
- **Gravidade:** Média

---

### ⚠️ Bug 2: Seleção "Graduação" exibe cursos de outros níveis
- **Descrição:** Ao selecionar "Graduação", aparecem cursos de Mestrado, Doutorado e Especialização.
- **Comportamento Esperado:** Exibir apenas cursos de graduação.
- **Passos para Reproduzir:** Selecionar "Graduação" → verificar a listagem de cursos exibidos.
- **Gravidade:** Alta

---

### ⚠️ Bug 3: Após voltar de um curso, botão "Avançar" não aparece
- **Descrição:** Ao clicar em "Voltar" após selecionar um curso de graduação, o botão "Avançar" não aparece.
- **Comportamento Esperado:** O botão "Avançar" deve estar visível sempre que o nível de ensino for informado independente da   navegação.
- **Passos para Reproduzir:** Selecionar curso → clicar em "Voltar" → observar o botão "Avançar" não é exibido.
- **Gravidade:** Média

---

### ⚠️ Bug 4: Campo "Selecione seu curso de graduação" considera espaços na validação
- **Descrição:** Espaços extras no início/fim invalidam o curso inserido.
- **Comportamento Esperado:** Ignorar espaços em branco na validação.
- **Passos para Reproduzir:** Inserir curso com espaços → verificar validação incorreta.
- **Gravidade:** Baixa

---

### ⚠️ Bug 5: Campo "CPF" permite caracteres não numéricos
- **Descrição:** O campo aceita letras e símbolos.
- **Comportamento Esperado:** Aceitar apenas números.
- **Passos para Reproduzir:** Digitar letras ou símbolos no campo CPF.
- **Gravidade:** Média

---

### ⚠️ Bug 6: Campo "CPF" não possui máscara para limitar caracteres
- **Descrição:** É possível inserir mais de 11 dígitos.
- **Comportamento Esperado:** Limitar entrada a 11 números.
- **Passos para Reproduzir:** Inserir mais de 11 caracteres no campo CPF.
- **Gravidade:** Média

---

### ⚠️ Bug 7: Campo "Nome" aceita caracteres inválidos
- **Descrição:** Permite inserir números e símbolos.
- **Comportamento Esperado:** Aceitar apenas letras e caracteres de nome válidos.
- **Passos para Reproduzir:** Inserir números ou símbolos.
- **Gravidade:** Baixa

---

### ⚠️ Bug 8: Campo "Data de Nascimento" permite datas futuras
- **Descrição:** É possível selecionar datas futuras.
- **Comportamento Esperado:** Limitar seleção a datas passadas.
- **Passos para Reproduzir:** Selecionar data futura.
- **Gravidade:** Média

---

### ⚠️ Bug 9: Campo "Celular" permite caracteres não numéricos
- **Descrição:** Aceita letras e símbolos.
- **Comportamento Esperado:** Aceitar apenas números com formatação.
- **Passos para Reproduzir:** Inserir letras ou símbolos.
- **Gravidade:** Média

---

### ⚠️ Bug 10: Campo "Telefone" permite caracteres não numéricos
- **Descrição:** Aceita caracteres inválidos.
- **Comportamento Esperado:** Aceitar somente números e caracteres como parênteses e traços.
- **Passos para Reproduzir:** Inserir letras ou símbolos.
- **Gravidade:** Média

---

### ⚠️ Bug 11: Campo "Telefone" considera válido apenas caracteres especiais
- **Descrição:** Valida corretamente apenas entradas com caracteres especiais.
- **Comportamento Esperado:** O campo deve aceitar apenas números e formatar o telefone corretamente.
- **Passos para Reproduzir:** Inserir apenas caracteres especiais.
- **Gravidade:** Alta

---

### ⚠️ Bug 12: Campo "Endereço" não possui campo separado para número do imóvel
- **Descrição:** No campo "Endereço", não há um campo separado para inserir o número do imóvel, causando confusão no preenchimento.
- **Comportamento Esperado:** Deve existir um campo específico para o número do imóvel.
- **Passos para Reproduzir:** Acessar campo "Endereço".
- **Gravidade:** Baixa

---

### ⚠️ Bug 13: Campo "CEP" aceita somente caracteres especiais como válidos
- **Descrição:** Caracteres especiais são aceitos como válidos.
- **Comportamento Esperado:** Aceitar apenas números no formato correto de CEP.
- **Passos para Reproduzir:** Inserir caracteres especiais no campo.
- **Gravidade:** Alta

---

### ⚠️ Bug 14: Página carrega com nível "Graduação" pré-selecionado
- **Descrição:** "Graduação" já está selecionado ao abrir a página.
- **Comportamento Esperado:** Nenhuma opção deve estar selecionada inicialmente.
- **Passos para Reproduzir:** Acessar página inicial.
- **Gravidade:** Média

---

### ⚠️ Bug 15: Sistema informa se erro no login é de usuário ou senha
- **Descrição:** Mensagem de erro especifica o campo incorreto.
- **Comportamento Esperado:** Exibir mensagem genérica ("Usuário ou senha inválidos").
- **Passos para Reproduzir:** Informar usuário ou senha incorretos.
- **Gravidade:** Alta

---

### ⚠️ Bug 16: Sistema não permite visualizar senha
- **Descrição:** O sistema não oferece a opção de visualizar a senha, caso o usuário informe algum dado errado não é possível quais informações foram digitadas.
- **Comportamento Esperado:** Permitir visualização da senha
- **Passos para Reproduzir:** Fazer login com erro e observar os campos.
- **Gravidade:** Média

---

### ⚠️ Bug 17: Ao acessar "Financeiro", opção de voltar não aparece
- **Descrição:** Não há botão para retornar à home.
- **Comportamento Esperado:** Exibir botão de retorno como em "Minhas inscrições".
- **Passos para Reproduzir:** Logar → acessar "Financeiro" → verificar ausência de botão.
- **Gravidade:** Média

---