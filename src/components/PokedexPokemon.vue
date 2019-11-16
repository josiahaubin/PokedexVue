<template>
  <div class="PokedexPokemon col-4 mt-2">
    <div class="card shadow">
      <img :src="pokeProp.img" class="card-img-top" />
      <div class="card-body">
        <h4 class="card-title">{{pokeProp.name}}</h4>
        <h5>Height: {{pokeProp.height}} -- Weight: {{pokeProp.weight}}</h5>
      </div>
    </div>
  </div>
</template>


<script>
export default {
  name: "PokedexPokemon",
  props: ["pokeProp"],
  data() {
    return {};
  },
  computed: {},
  methods: {},
  components: {}
};
</script>


<style scoped>
</style>