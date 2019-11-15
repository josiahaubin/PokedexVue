<template>
  <div class="home container-fluid">
    <div class="row justify-content-center">
      <div class="col-12 col-md-6 mt-3">
        <div class="input-group mb-3 shadow">
          <input type="text" class="form-control" placeholder="Search for a Pokemon" />
          <div class="input-group-append">
            <button class="btn btn-success" type="button" id="search">Search</button>
          </div>
        </div>
      </div>
    </div>
    <div class="row mt-4">
      <div class="col-12 col-md-6">
        <h3>Top 20 Pokemon</h3>
        <small>Click on name to view Pokemon</small>
        <Pokemon v-for="pokemon in topPokemon" :key="pokemon.id" :pokeProp="pokemon" />
      </div>
      <div class="col-12 col-md-6">
        <h3>Pokemon Details</h3>
        <ActivePokemon />
      </div>
    </div>
  </div>
</template>

<script>
import Pokemon from "../components/Pokemon";
import ActivePokemon from "../components/ActivePokemon";

export default {
  name: "home",
  mounted() {
    return this.getTopPokemon();
  },
  computed: {
    topPokemon() {
      return this.$store.state.topPokemon;
    }
  },
  methods: {
    getTopPokemon() {
      this.$store.dispatch("getTopPokemon");
    }
  },
  components: { Pokemon, ActivePokemon }
};
</script>

<style scoped>
</style>
