import { createRouter, createWebHashHistory, RouteRecordRaw } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import LogView from '../views/LogView.vue'
import SignView from '../views/SignView.vue'
import RechercheView from '../views/RechercheView.vue'

const routes: Array<RouteRecordRaw> = [
  {
    path: '/',
    name: 'home',
    component: HomeView
  },
  {
    path: '/about',
    name: 'about',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/AboutView.vue')
  },
  {
    path: '/login',
    name: 'login',
    component: LogView
  },
  {
    path: '/signin',
    name: 'signin',
    component: SignView
  },
  {
    path: '/search',
    name: 'sigsearchnin',
    component: RechercheView
  }
]

const router = createRouter({
  history: createWebHashHistory(),
  routes
})

export default router