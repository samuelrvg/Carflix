<template>
  <div>
      <router-link class="btn btn-primary mb-4" to="/endereco">Novo</router-link>
    <div>
      <b-table striped hover :items="enderecos"></b-table>
    </div>
  </div>
</template>

<script>
export default {
  data(){
    return {
      enderecos: [{
        cep: '01001-000',
        logradouro: 'Praça da Sé',
        complemento: 'lado ímpar',
        bairro: 'Sé',
        localidade: 'São Paulo',
        uf: 'SP',
        ibge: 3550308,
        gia: 1004,
        ddd: 11,
        siafi: 7107
      },
      {
        cep: '01001-000',
        logradouro: 'Praça da Sé',
        complemento: 'lado ímpar',
        bairro: 'Sé',
        localidade: 'São Paulo',
        uf: 'SP',
        ibge: 3550308,
        gia: 1004,
        ddd: 11,
        siafi: 7107
      },
      {
        cep: '01001-000',
        logradouro: 'Praça da Sé',
        complemento: 'lado ímpar',
        bairro: 'Sé',
        localidade: 'São Paulo',
        uf: 'SP',
        ibge: 3550308,
        gia: 1004,
        ddd: 11,
        siafi: 7107
      },
      ]
    }
  },
  methods:{
    async asyncData(){

    }
  }
}
</script>
