# Carflix

### Requisitos

- [x] Sistema Web.
- [x] Usar C# ou outra linguagem orientada a objetos.
- [x] Usar API do site [ViaCEP](https://viacep.com.br).
    - [x] Retornar endereço com base no CEP.
    - [x] Salvar no banco de dados.
    - [x] Listar em tela os endereços cadastrados.
	
### Funcionalidades adicionais

- [x] Documentação com Swagger.
- [x] Paginação.
- [x] Atualizar.
- [x] Excluir.

### Principais Tecnologias

- Asp.Net Core 3.1
- NuxtJS
- SqlServer

### Back-End
Executar o comando abaixo para gerar o banco de dados com base nas migrations.
```bash
 Update-Database
```

### Front-End

```bash
# install dependencies
$ yarn install

# serve with hot reload at localhost:3000
$ yarn dev

# build for production and launch server
$ yarn build
$ yarn start

# generate static project
$ yarn generate
```

For detailed explanation on how things work, check out [Nuxt.js docs](https://nuxtjs.org).
