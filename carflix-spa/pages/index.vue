<template>
  <div>
      <router-link class="btn btn-primary mb-4" to="/endereco">Novo</router-link>
    <div>
      <table id="table" class="table table-hover table-reponsive-md">
            <thead>
                <tr>
                  <th>
                      <strong>Cep</strong></th>
                  <th>
                      <strong>Logradouro</strong>
                  </th>
                  <th>
                      <strong>Complemento</strong>
                  </th>
                  <th>
                      <strong>Bairro</strong>
                  </th>
                  <th>
                    <strong>Localidade</strong>
                  </th>
                  <th>
                    <strong>Uf</strong>
                  </th>
                  <th>
                    <strong>IBGE</strong>
                  </th>
                  <th>
                    <strong>GIA</strong>
                  </th>
                  <th>
                    <strong>DDD</strong>
                  </th>
                  <th>
                    <strong>Siafi</strong>
                  </th>
                  <th>
                    <strong>Data Criação</strong>
                  </th>
                  <th width="200">
                    <strong>Ação</strong>
                  </th>
              </tr>
          </thead>
          <tbody>
              <tr v-for="(endereco, index) in enderecosPaginados" :key="index">
                <td>{{ endereco.cep }}</td>
                <td>{{ endereco.logradouro }}</td>
                <td>{{ endereco.complemento }}</td>
                <td>{{ endereco.bairro }}</td>
                <td>{{ endereco.localidade }}</td>
                <td>{{ endereco.uf }}</td>
                <td>{{ endereco.ibge }}</td>
                <td>{{ endereco.gia }}</td>
                <td>{{ endereco.ddd }}</td>
                <td>{{ endereco.siafi }}</td>
                <td>{{ endereco.dataCriacao ? $moment(endereco.dataCriacao).format('DD/MM/YYYY') : '' }}</td>
                <td>
                  <NuxtLink class="btn btn-info" :to="`endereco/editar/${endereco.enderecoId}`">Editar</NuxtLink>
                  <b-button variant="danger" @click.prevent="excluir(endereco)">Excluir</b-button>
                </td>
              </tr>
          </tbody>
      </table>
      <b-pagination v-model="currentPage" :items="enderecos" :current-page="currentPage" :per-page="itemsPerPage" :total-rows="enderecos.length"></b-pagination>
    </div>
  </div>
</template>

<script>
export default {
  data(){
    return {
      currentPage: 1,
      itemsPerPage: 10,
      enderecos: [],
      enderecosPaginados: []
    }
  },
  async mounted () {
      await this.asyncData();
  },
  watch: {
      currentPage () {
        const items = this.paginate(this.enderecos);
        this.enderecosPaginados = items;
      },
      itemsPerPage () {
        const items = this.paginate(this.enderecos);
        this.enderecosPaginados = items;
      }
  },
  methods:{
    async asyncData(){
      const response = await this.$axios.$get(`endereco`)

      this.enderecosPaginados = this.paginate(response)
      this.enderecos = response;
    },
    async excluir(endereco){
      const confirmed = await this.$bvModal.msgBoxConfirm(`Tem certeza que deseja excluir o CEP: ${endereco.cep}?`);

      if (!confirmed) return;

      const { enderecoId } = await this.$axios.$delete(`endereco/${endereco.enderecoId}`);

      this.$bvToast.toast('Excluido com sucesso', {
        title: `Atenção`,
        variant: 'success',
        solid: true,
      })

      this.asyncData();
    },
    editar(){

    },
    paginate (array) {
      return array.slice((this.currentPage - 1) * this.itemsPerPage, this.currentPage * this.itemsPerPage);
    },
  }
}
</script>
