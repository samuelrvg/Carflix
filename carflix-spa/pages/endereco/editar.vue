<template>
    <div>
        <h2 class="pb-3">Edição Endereço</h2>
        <b-form @submit="onSubmit">
            <crud-partial :endereco="endereco"></crud-partial>
        </b-form>
    </div>
</template>

<script>
import crudPartial from '../../components/endereco/crud-partial'
export default {
    components:{
        'crud-partial': crudPartial
    },
    data(){
        return {
            endereco: null
        }
    },
    async asyncData ({ $axios, params, redirect }) {
        console.log('asdasd', params)
        if (!params.id) {
            redirect('/');
            return;
        }

        const endereco = await $axios.$get(`/endereco/${params.id}`);

        return { endereco };
    },
    methods:{
        async onSubmit(event){
            event.preventDefault()
            await this.$axios.$put(`endereco/${this.endereco.enderecoId}`, this.endereco)

            this.$router.push({ path: '/' });
        }
    }    
}
</script>
