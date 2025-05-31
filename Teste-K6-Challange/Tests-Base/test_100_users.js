import http from 'k6/http';
import { check, sleep } from 'k6';

export const options = {
  vus: 100, // 100 usuários virtuais
  duration: '30s', // duração do teste
};

export default function () {
  const baseUrl = 'https://quickpizza.grafana.com';

  // Testar endpoint /flip_coin.php
  const res1 = http.get(`${baseUrl}/flip_coin.php`);
  check(res1, {
    'status 200 em /flip_coin.php': (r) => r.status === 200,
  });

  // Testar endpoint /my_messages.php
  const res2 = http.get(`${baseUrl}/my_messages.php`);
  check(res2, {
    'status 200 em /my_messages.php': (r) => r.status === 200,
  });

  sleep(1); // simula comportamento real do usuário
}

// ✅ Geração de relatório JSON + HTML básico ao final do teste
export function handleSummary(data) {
  return {
    'resultados/summary-100.json': JSON.stringify(data, null, 2),
    'resultados/summary-100.html': `
      <html>
        <head>
          <title>Relatório de Performance - 100 usuários</title>
        </head>
        <body>
          <h1>Resumo do Teste com 100 Usuários</h1>
          <p><strong>Duração:</strong> ${data.state.testRunDurationMs / 1000}s</p>
          <h2>Métricas</h2>
          <pre>${JSON.stringify(data.metrics, null, 2)}</pre>
        </body>
      </html>
    `
  };
}
