import http from 'k6/http';
import { check, sleep } from 'k6';

export let options = {
  vus: 1,
  iterations: 10, // 10 usuários
};

export default function () {
  const url = 'http://quickpizza.grafana.com/api/users';

  // Gerar nome simples sem caractere especial
  const username = `usuario${__ITER + 1}`; // __ITER é a iteração atual (0 a 9)
  const password = 'senha1234'; // senha sem caractere especial

  const payload = JSON.stringify({
    username,
    password,
  });

  const params = {
    headers: {
      'Content-Type': 'application/json',
    },
  };

  const res = http.post(url, payload, params);

  check(res, {
    'status é 201': (r) => r.status === 201,
  });

  if (res.status === 201) {
    console.log(`Usuário criado: ${username}`);
  } else {
    console.log(`Erro ao criar usuário: ${username} | Status: ${res.status}`);
  }

  sleep(1);
}
