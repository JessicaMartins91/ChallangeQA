import http from 'k6/http';
import { check } from 'k6';

// Valida interação com Pizza, Please
export const options = {
  vus: 100, // número de usuários virtuais simultâneos
  iterations: 100, // total de requisições (cliques)
};

export default function () {
  const url = 'https://quickpizza.grafana.com/api/pizza';
  const payload = JSON.stringify({
    maxCaloriesPerSlice: 1000,
    mustBeVegetarian: false,
    excludedIngredients: ["Pimenta"],
    excludedTools: ["Microondas"],
    maxNumberOfToppings: 5,
    minNumberOfToppings: 2,
    customName: "DesafioQA"
  });

  const params = {
    headers: {
      'Content-Type': 'application/json',
      'Accept': '*/*',
      'Authorization': 'Token HrF1yuxE90cjFgnD',
      'User-Agent': 'k6-load-test',
      'Origin': 'https://quickpizza.grafana.com',
      'Referer': 'https://quickpizza.grafana.com/',
    },
  };

  const res = http.post(url, payload, params);
  check(res, {
    'status is 200': (r) => r.status === 200,
  });
}

// Geração de relatório HTML simples na pasta "Resultados-Extra"
export function handleSummary(data) {
  return {
    'Resultados-Extra/pizza-please.json': JSON.stringify(data, null, 2),
    'Resultados-Extra/pizza-please.html': `
      <html>
        <head>
          <title>Relatório - Pizza por favor </title>
          <style>
            body { font-family: Arial, sans-serif; padding: 20px; }
            h1 { color: #333; }
            pre { background: #f4f4f4; padding: 10px; border-radius: 5px; }
          </style>
        </head>
        <body>
          <h1>Resumo do Teste: Pizza por favor</h1>
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