<template>
    <div class="row">
        <div class="col-md-12">
            <input id="enderecoId" v-model="endereco.enderecoId" type="hidden" name="enderecoId" class="form-control" required />
            <div class="row">
                <div class="col-md-6">
                    <b-form-group
                        id="cep"
                        label="Cep:"
                        label-for="cep"
                    >
                        <b-form-input
                            id="cep"
                            v-model="endereco.cep"
                            type="text"
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
                        required
                        ></b-form-input>
                    </b-form-group>
                </div>

                <div class="col-md-6">
                    <b-form-group
                        id="bairro"
                        label="Bairro:"
                        label-for="Bairro"
                    >
                    <b-form-input
                        id="bairro"
                        v-model="endereco.bairro"
                        type="text"
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
                        type="text"
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
                        type="text"
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
                        type="text"
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
                        type="text"
                        required
                        ></b-form-input>
                    </b-form-group>
                </div>
            </div>

            <b-button type="submit" variant="primary">Salvar</b-button>
        </div>
    </div>
</template>
<script>
export default {
    props: ['endereco'],
}
</script>