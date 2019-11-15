import Vue from 'vue'
import Vuex from 'vuex'
import axios from 'axios'

Vue.use(Vuex)

let pokeApi = axios.create({
  baseURL: "https://pokeapi.co/api/v2/pokemon"
})

export default new Vuex.Store({
  state: {
    topPokemon: []
  },
  mutations: {
    setTopPokemon(state, payload) {
      state.topPokemon = payload
    }
  },
  actions: {
    async getTopPokemon({ commit, dispatch }) {
      let res = await pokeApi.get('')
      commit("setTopPokemon", res.data.results)
    }
  }
})
