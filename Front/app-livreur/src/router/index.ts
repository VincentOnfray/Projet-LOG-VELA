import { createRouter, createWebHashHistory, RouteRecordRaw } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import LogView from '../views/LogView.vue'
import SignView from '../views/SignView.vue'
import RechercheView from '../views/RechercheView.vue'
import UserView from '../views/UserView.vue'
import CommandView from '../views/CommandView.vue'
import CommandConsultView from '../views/CommandConsultView.vue'
import ChangeView from '../views/ChangeView.vue'

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
    path: '/user',
    name: 'user',
    component: UserView
  },
  {
    path: '/change',
    name: 'change',
    component: ChangeView
  },
  {
    path: '/command',
    name: 'command',
    component: CommandView
  },
  {
    path: '/consult',
    name: 'consult',
    component: CommandConsultView
  }
]

const router = createRouter({
  history: createWebHashHistory(),
  routes
})

export default router
