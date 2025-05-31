import http from 'k6/http';
import { check } from 'k6';

// Valida interação para personalizar pizza
export const options = {
  vus: 50,        // 50 usuários simultâneos
  iterations: 50, // cada usuário faz 1 requisição
};

const url = 'https://quickpizza.grafana.com/api/pizza';

const payload = JSON.stringify({
  maxCaloriesPerSlice: 1000,
  mustBeVegetarian: false,
  excludedIngredients: [],
  excludedTools: ["Knife"],
  maxNumberOfToppings: 5,
  minNumberOfToppings: 2,
  customName: "DESAFIOQA"
});

const params = {
  headers: {
    'Content-Type': 'application/json',
    'Authorization': 'Token jtyNidKMzxFGb0Mi',  // seu token de autenticação
  },
};

export default function () {
  const res = http.post(url, payload, params);

  check(res, {
    'status 201 ou 200': (r) => r.status === 201 || r.status === 200,
  });
}

// Geração de relatório HTML simples na pasta "Resultados-Extra"
export function handleSummary(data) {
  return {
    'Resultados-Extra/personalizar-pizza.json': JSON.stringify(data, null, 2),
    'Resultados-Extra/personalizar-pizza.html': `
      <html>
        <head>
          <title>Relatório - Personalização de Pizza</title>
          <style>
            body { font-family: Arial, sans-serif; padding: 20px; }
            h1 { color: #333; }
            pre { background: #f4f4f4; padding: 10px; border-radius: 5px; }
          </style>
        </head>
        <body>
          <h1>Resumo do Teste: Personalização de Pizza</h1>
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
