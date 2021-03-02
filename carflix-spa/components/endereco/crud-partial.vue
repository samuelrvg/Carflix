<template>
    <div class="row">
        <div class="col-md-12">
            <b-form @submit="onSubmit">
                <div class="row">
                    <div class="col-md-6">
                        <b-form-group
                            id="cep"
                            label="Cep:"
                            label-for="cep"
                        >
                        <b-form-input
                            id="endereco"
                            v-model="endereco.cep"
                            type="text"
                            placeholder="Cep"
                            required
                            ></b-form-input>
                        </b-form-group>
                    </div>

                    <div class="col-md-6">
                        <b-form-group
                            id="logradouro"
                            label="Logradouro:"
                            label-for="logradouro"
                        >
                        <b-form-input
                            id="logradouro"
                            v-model="endereco.logradouro"
                            type="text"
                            placeholder="Logradouro"
                            required
                            ></b-form-input>
                        </b-form-group>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-6">
                        <b-form-group
                            id="complemento"
                            label="Complemento:"
                            label-for="complemento"
                        >
                        <b-form-input
                            id="complemento"
                            v-model="endereco.complemento"
                            type="text"
                            placeholder="Complemento"
                            required
                            ></b-form-input>
                        </b-form-group>
                    </div>

                    <div class="col-md-6">
                        <b-form-group
                            id="Bairro"
                            label="Bairro:"
                            label-for="Bairro"
                        >
                        <b-form-input
                            id="Bairro"
                            v-model="endereco.bairro"
                            type="text"
                            placeholder="Bairro"
                            required
                            ></b-form-input>
                        </b-form-group>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-6">
                        <b-form-group
                            id="localidade"
                            label="Localidade:"
                            label-for="localidade"
                        >
                        <b-form-input
                            id="localidade"
                            v-model="endereco.localidade"
                            type="text"
                            placeholder="Localidade"
                            required
                            ></b-form-input>
                        </b-form-group>
                    </div>

                    <div class="col-md-6">
                        <b-form-group
                            id="uf"
                            label="Uf:"
                            label-for="uf"
                        >
                        <b-form-input
                            id="uf"
                            v-model="endereco.uf"
                            type="text"
                            placeholder="Uf"
                            required
                            ></b-form-input>
                        </b-form-group>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-6">
                        <b-form-group
                            id="ibge"
                            label="Ibge:"
                            label-for="ibge"
                        >
                        <b-form-input
                            id="ibge"
                            v-model="endereco.ibge"
                            type="number"
                            placeholder="ibge"
                            required
                            ></b-form-input>
                        </b-form-group>
                    </div>

                    <div class="col-md-6">
                        <b-form-group
                            id="gia"
                            label="Gia:"
                            label-for="gia"
                        >
                        <b-form-input
                            id="gia"
                            v-model="endereco.gia"
                            type="number"
                            placeholder="gia"
                            required
                            ></b-form-input>
                        </b-form-group>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-6">
                        <b-form-group
                            id="ddd"
                            label="DDD:"
                            label-for="ddd"
                        >
                        <b-form-input
                            id="ddd"
                            v-model="endereco.ddd"
                            type="number"
                            placeholder="DDD"
                            required
                            ></b-form-input>
                        </b-form-group>
                    </div>

                    <div class="col-md-6">
                        <b-form-group
                            id="siafi"
                            label="Siafi:"
                            label-for="siafi"
                        >
                        <b-form-input
                            id="siafi"
                            v-model="endereco.siafi"
                            type="number"
                            placeholder="Siafi"
                            required
                            ></b-form-input>
                        </b-form-group>
                    </div>
                </div>

                <b-button type="submit" variant="primary">Salvar</b-button>
                <!-- <b-button type="reset" variant="danger">Limpar</b-button> -->
            </b-form>
        </div>
    </div>
</template>
<script>
export default {
    props: ['endereco'],
    data(){
        return {
        }
    },
    methods: {
      async onSubmit(event) {
        event.preventDefault()
        await this.$axios.$post(`endereco`, this.endereco)
      },
    }
}
</script>