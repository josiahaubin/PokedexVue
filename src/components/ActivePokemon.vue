<template>
  <div class="ActivePokemon">
    <div class="card shadow">
      <img :src="pokemon.sprites.front_default" class="card-img-top" />
      <div class="card-body">
        <h2 class="card-title">{{pokemon.name}}</h2>
        <h5>Height: {{pokemon.height}} -- Weight: {{pokemon.weight}}</h5>
        <button class="btn btn-outline-success my-2" @click="savePokemon()">Save Pokemon</button>
        <br />
        <h5>Moves:</h5>
        <ol>
          <li v-for="move in pokemon.moves" :key="move.id" class="text-left">{{move.move.name}}</li>
        </ol>
      </div>
    </div>
  </div>
</template>


<script>
export default {
  name: "ActivePokemon",
  mounted() {},
  data() {
    return {};
  },
  computed: {
    pokemon() {
      return this.$store.state.activePokemon;
    }
  },
  methods: {
    savePokemon() {
      this.$store.dispatch("savePokemon", {
        Name: this.pokemon.name,
        Height: this.pokemon.height,
        Weight: this.pokemon.weight,
        Img: this.pokemon.sprites.front_default
      });
    }
  },
  components: {}
};
</script>


<style scoped>
</style>