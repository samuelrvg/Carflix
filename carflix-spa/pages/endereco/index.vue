<template>
    <div>
        <div class="py-3">
            <div class="row">
                <div class="col-md-6">
                    <b-form-input v-model="cep" placeholder="Digite o CEP"></b-form-input>
                </div>
                <div class="col-md-2">
                    <b-button @click="buscarEndereco()" variant="primary">Buscar</b-button>
                </div>
            </div>
        </div>
        <div class="py-3" v-if="endereco !== null">
            <crud-partial :endereco="endereco"></crud-partial>
        </div>
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
            cep: '01001000',
            endereco: null
        }
    },
    methods:{
        async buscarEndereco(){
            if(this.cep){
                await fetch(`https://viacep.com.br/ws/${this.cep}/json`, { method:'get' })
                .then(response => {
                    response.json().then(endereco => {
                        this.endereco = endereco;
                    })
                })
                .catch(err => {
                    console.log('err', err)
                })
            }
        }
    }
}
</script>