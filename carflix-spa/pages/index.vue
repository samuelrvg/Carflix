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
      enderecos: []
    }
  },
  async mounted () {
      await this.asyncData();
  },
  methods:{
    async asyncData(){
      const response = await this.$axios.$get(`endereco`)
      
      this.enderecos = response;
    }
  }
}
</script>
