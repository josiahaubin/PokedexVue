<template>
  <div class="Pokemon col-6 mt-2 mx-auto">
    <div class="card shadow">
      <div class="card-body">
        <h6 class="card-text" @click="showButton = !showButton">{{pokeProp.name}}</h6>
        <div v-if="showButton">
          <button class="btn btn-outline-primary" @click="getPokemon()">View Pokemon</button>
        </div>
      </div>
    </div>
  </div>
</template>


<script>
export default {
  name: "Pokemon",
  data() {
    return {
      showButton: false
    };
  },
  props: ["pokeProp"],
  computed: {},
  methods: {
    getPokemon() {
      this.$store.dispatch("getPokemon", this.pokeProp.name);
    }
  },
  components: {}
};
</script>


<style scoped>
h6 {
  cursor: pointer;
}
</style>