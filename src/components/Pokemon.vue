<template>
  <div class="Pokemon col-6 m-auto">
    <div class="card">
      <div class="card-body">{{pokeProp.name}}</div>
    </div>
  </div>
</template>


<script>
export default {
  name: "Pokemon",
  data() {
    return {};
  },
  props: ["pokeProp"],
  computed: {},
  methods: {},
  components: {}
};
</script>


<style scoped>
</style>