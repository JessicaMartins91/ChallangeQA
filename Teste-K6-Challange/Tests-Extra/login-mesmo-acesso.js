import http from 'k6/http';
import { check, sleep } from 'k6';

export const options = {
  vus: 100,
  iterations: 100,
};

export default function () {
  const url = 'https://quickpizza.grafana.com/api/users/token/login?set_cookie=true';

  const payload = JSON.stringify({
    username: 'default',
    password: '12345678',
    csrf: ''
  });

  const headers = {
    'accept': '*/*',
    'content-type': 'application/json',
    'origin': 'https://quickpizza.grafana.com',
    'referer': 'https://quickpizza.grafana.com/login',
  };

  const res = http.post(url, payload, { headers });

  check(res, {
    'login bem-sucedido': (r) => r.status === 200,
  });

  sleep(1);
}

// Geração de relatório HTML simples na pasta "Resultados-Extra"
export function handleSummary(data) {
  return {
    'Resultados-Extra/login-mesmo-acesso.json': JSON.stringify(data, null, 2),
    'Resultados-Extra/login-mesmo-acesso.html': `
      <html>
        <head>
          <title>Relatório - Login Mesmo Usuário</title>
          <style>
            body { font-family: Arial, sans-serif; padding: 20px; }
            h1 { color: #333; }
            pre { background: #f4f4f4; padding: 10px; border-radius: 5px; }
          </style>
        </head>
        <body>
          <h1>Resumo do Teste: Login com o mesmo usuário</h1>
          <p><strong>Execuções:</strong> ${data.metrics.iterations?.values?.count ?? 'N/A'}</p>
          <p><strong>Sucessos:</strong> ${data.metrics.checks?.values?.passes ?? 'N/A'}</p>
          <p><strong>Falhas:</strong> ${data.metrics.checks?.values?.fails ?? 'N/A'}</p>
          <h2>Métricas Detalhadas</h2>
          <pre>${JSON.stringify(data.metrics, null, 2)}</pre>
        </body>
      </html>
    `
  };
}
