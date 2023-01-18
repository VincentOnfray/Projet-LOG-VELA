import { createRouter, createWebHistory } from '@ionic/vue-router';
import { RouteRecordRaw } from 'vue-router';
const routes: Array<RouteRecordRaw> = [
  {
    path: '',
    redirect: '/folder/Profil',
    
  },
  {
    path: '/folder/:id',
    component: () => import ('../views/FolderPage.vue'
    )
  },
  {
    path: '/folder/Profil',
    component: () => import ('../views/ProfilPage.vue')
  },
  {
    path: '/folder/Restaurant',
    component: () => import ('../views/RestaurantPage.vue')
  },
  {
    path: '/folder/Restaurant/Article',
    component: () => import ('../views/ArticlePage.vue')
  },
  {
    path: '/folder/Restaurant/Article/Ajout',
    component: () => import ('../views/AjoutArticlePage.vue')
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
