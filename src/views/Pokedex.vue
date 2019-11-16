<template>
  <div class="Pokedex"></div>
</template>


<script>
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
  components: {}
};
</script>


<style scoped>
</style>