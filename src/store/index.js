import Vue from 'vue'
import Vuex from 'vuex'
import axios from 'axios'

Vue.use(Vuex)

let pokeApi = axios.create({
  baseURL: "https://pokeapi.co/api/v2/pokemon/"
})

export default new Vuex.Store({
  state: {
    topPokemon: [],
    activePokemon: {}
  },
  mutations: {
    setTopPokemon(state, payload) {
      state.topPokemon = payload
    },
    setActivePokemon(state, payload) {
      state.activePokemon = payload
    }
  },
  actions: {
    async getTopPokemon({ commit, dispatch }) {
      try {
        let res = await pokeApi.get('')
        commit("setTopPokemon", res.data.results)
      } catch (error) {
        console.log(error)
      }
    },
    async getPokemon({ commit, dispatch }, payload) {
      try {
        let res = await pokeApi.get(payload)
        commit("setActivePokemon", res.data)
      } catch (error) {
        alert("Pokemon not found");
      }
    }
  }
})
