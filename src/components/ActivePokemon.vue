<template>
  <div class="ActivePokemon">
    <div class="card">
      <img :src="pokemon.sprites.front_default" class="card-img-top" />
      <div class="card-body">
        <h2 class="card-title">{{pokemon.name}}</h2>

        <ol>
          <li v-for="move in pokemon.moves" :key="move.id">{{move.move.name}}</li>
        </ol>
      </div>
    </div>
  </div>
</template>


<script>
export default {
  name: "ActivePokemon",
  data() {
    return {};
  },
  computed: {
    pokemon() {
      return this.$store.state.activePokemon;
    }
  },
  methods: {},
  components: {}
};
</script>


<style scoped>
</style>