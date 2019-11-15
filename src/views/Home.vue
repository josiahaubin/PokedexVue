<template>
  <div class="home container-fluid">
    <div class="row justify-content-center">
      <div class="col-12 col-md-6 mt-3">
        <div class="input-group mb-3">
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
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "home",
  components: {}
};
</script>
