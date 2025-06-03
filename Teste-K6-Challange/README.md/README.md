## 🔍 Testes Adicionais Criados

Além dos testes obrigatórios, foram desenvolvidos mais quatro testes focados em cenários específicos da aplicação:

## 📊 Resumo do Teste de Carga com K6 (100 usuários)

- **Usuários simultâneos (VUs):** 100  
- **Duração total do teste:** ~31 segundos  
- **Requisições realizadas:** 4.456  
- **Tempo médio de resposta:** 153 ms  
- **Taxa de erro:** 0% (nenhuma falha)  
- **Conclusão:** O sistema manteve estabilidade e bom desempenho mesmo com 100 usuários simultâneos.

## 📊 Resumo do Teste de Carga com K6 (500 usuários)

- **Usuários simultâneos (VUs):** 500  
- **Duração total do teste:** ~31s  
- **Requisições realizadas:** 17.834  
- **Iterações:** 8.917  
- **Tempo médio de resposta:** 166.8 ms  
- **Tempo máximo de resposta:** 576.56 ms  
- **Taxa de erro:** ~0% (apenas 1 falha)  
- **Dados recebidos:** 26.3 MB  
- **Dados enviados:** 3.01 MB 

## 📊 Resumo do Teste de Carga com K6 (1000 usuários)

- **Usuários simultâneos (VUs):** 1000  
- **Duração total do teste:** ~32.9s  
- **Requisições realizadas:** 34.410  
- **Iterações:** 17.205  
- **Tempo médio de resposta:** 287.4 ms  
- **Tempo máximo de resposta:** 2.727 ms  
- **Taxa de erro:** ~0,15% (53 falhas)  
- **Falhas:** 53 respostas inesperadas no `expected_response:true`  
- **Dados recebidos:** 51 MB  
- **Dados enviados:** 5.81 MB  

| Script                   | Descrição |
|--------------------------|-----------|
| `criar-usuarios.js`      | Simula criação de múltiplos usuários simultaneamente.
| `login-mesmo-acesso.js`  | Simula múltiplos logins com o mesmo usuário, identificando possíveis falhas de sessão ou race conditions. |
| `pizza-personalizada.js` | Testa o endpoint de montagem de pizzas personalizadas, simulando várias combinações. |
| `pizza-please.js`        | Simula pedidos de pizza de forma repetitiva e intensa, útil para medir o impacto no backend de pedidos. |

Todos os relatórios em HTML desses testes podem ser encontrados em: `resultados e resultados-extra`

