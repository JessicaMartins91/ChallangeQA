## 🔍 Testes Adicionais Criados

Além dos testes obrigatórios, foram desenvolvidos mais quatro testes focados em cenários específicos da aplicação, para enriquecer a análise de performance:

| Script                   | Descrição |
|--------------------------|-----------|
| `criar-usuarios.js`      | Simula criação de múltiplos usuários simultaneamente.
| `login-mesmo-acesso.js`  | Simula múltiplos logins com o mesmo usuário, identificando possíveis falhas de sessão ou race conditions. |
| `pizza-personalizada.js` | Testa o endpoint de montagem de pizzas personalizadas, simulando várias combinações. |
| `pizza-please.js`        | Simula pedidos de pizza de forma repetitiva e intensa, útil para medir o impacto no backend de pedidos. |

Todos os relatórios em HTML desses testes podem ser encontrados em: `resultados e resultados-extra`
