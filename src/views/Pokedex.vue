<template>
  <div class="Pokedex container-fluid">
    <div class="row mt-3">
      <div class="col-12">
        <h3>My Pokedex</h3>
      </div>
    </div>
    <div class="row">
      <PokedexPokemon v-for="pokemon in pokedex" :key="pokemon.id" :pokeProp="pokemon" />
    </div>
  </div>
</template>


<script>
import PokedexPokemon from "../components/PokedexPokemon";
export default {
  name: "Pokedex",
  mounted() {
    return this.getPokedex();
  },
  data() {
    return {};
  },
  computed: {
    pokedex() {
      return this.$store.state.pokedex;
    }
  },
  methods: {
    getPokedex() {
      this.$store.dispatch("getPokedex");
    }
  },
  components: { PokedexPokemon }
};
</script>


<style scoped>
.Pokedex {
  min-height: 86vh;
}
</style>