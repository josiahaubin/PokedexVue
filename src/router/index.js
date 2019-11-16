import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'home',
    component: Home
  },
  {
    path: '/pokedex',
    name: 'pokedex',
    // route level code-splitting
    // this generates a separate chunk (pokedex.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: function () {
      return import(/* webpackChunkName: "pokedex" */ '../views/Pokedex.vue')
    }
  }
]

const router = new VueRouter({
  routes
})

export default router
