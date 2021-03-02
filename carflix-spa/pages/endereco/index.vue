<template>
    <div>
        <div class="py-3">
            <div class="row">
                <div class="col-md-6">
                    <input class="form-control" minlength="8" type="text" v-model="cep" placeholder="Digite o CEP" />
                </div>
                <div class="col-md-2">
                    <b-button @click="buscarEndereco()" variant="primary">Buscar</b-button>
                </div>
            </div>
        </div>
        <div class="py-3" v-if="endereco !== null">
            <b-form @submit="onSubmit">
                <crud-partial :endereco="endereco"></crud-partial>
            </b-form>
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
            if(this.cep.length >= 8){
                const formatCep = this.cep.replace('-','');
                await fetch(`https://viacep.com.br/ws/${formatCep}/json`, { method:'get' })
                .then(response => {
                    response.json().then(endereco => {
                        const { erro } = endereco
                        if(erro){
                            this.showToast(erro);
                            this.endereco = null;
                        }
                        else
                            this.endereco = endereco;
                    })
                })
                .catch(err => {
                    console.log('err', err)
                })
            }
            else{
                this.showToast();
                this.endereco = null;
            }
        },
        async onSubmit(event) {
            event.preventDefault()
            await this.$axios.$post(`endereco`, this.endereco)

            // this.$bvToast.toast('Endereço salvo com sucesso!', {
            //   title: `Sucesso`,
            //   variant: 'success',
            //   solid: true,
            // })

            this.$router.push({ path: '/' });
        },
        showToast(erro = false){
            const message = erro ? 'CEP não encontrado' : 'CEP Inválido!'
            const variant = erro ? 'danger' : 'warning'
            this.$bvToast.toast(message, {
                    title: `Atenção`,
                    variant: variant,
                    solid: true,
            })
        }
    }
}
</script>