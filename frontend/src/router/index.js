import { createRouter, createWebHistory } from 'vue-router'

import HomePageView from '@/views/HomePageView.vue'
import ProductListView from '@/views/ProductListView.vue'
import ServiceView from '@/views/ServiceView.vue'
import ShopView from '@/views/ShopView.vue'
import CompanyView from '@/views/CompanyView.vue'
import RegisterView from '@/views/RegisterView.vue'
import LoginView from '@/views/LoginView.vue'

import AboutView from '@/views/AboutView.vue'
import ContactView from '@/views/ContactView.vue'

import DashboardView from '@/views/admin/DashboardView.vue'
import LoginAdminView from '@/views/admin/LoginAdminView.vue'
import CustomerManagerView from '@/views/admin/CustomerManagerView.vue'
import ProductListManagerView from '@/views/admin/ProductListManagerView.vue'

// import ProductListAddView from '@/views/admin/ProductListAddView.vue'
// import ProductListAddView from '@/views/admin/ProductListAddView.vue'

const routes = [
  {
    path: '/',
    name: 'HomePageView',
    component: HomePageView,
  },
  {
    path: '/Product',
    name: 'ProductListView',
    component: ProductListView,
    meta: { requiresAuth: true }, // Thêm meta để yêu cầu xác thực
  },
  {
    path: '/Service',
    name: 'ServiceView',
    component: ServiceView
  },
  {
    path: '/Shop',
    name: 'ShopView',
    component: ShopView
  },
  {
    path: '/Company',
    name: 'CompanyView',
    component: CompanyView
  },
  {
    path: '/Register',
    name: 'RegisterView',
    component: RegisterView
  },
  {
    path: '/Login',
    name: 'LoginView',
    component: LoginView
  },
  {
    path: '/About',
    name: 'AboutView',
    component: AboutView
  },
  {
    path: '/Contact',
    name: 'ContactView',
    component: ContactView
  },
  {
    path: '/admin/LoginAdmin',
    name: 'LoginAdminView',
    component: LoginAdminView
  },
  {
    path: '/admin/Dashboard',
    name: 'DashboardView',
    component: DashboardView
  },
  {
    path: '/admin/CustomerManager',
    name: 'CustomerManagerView',
    component: CustomerManagerView
  },
  {
    path: '/admin/ProductListManager',
    name: 'ProductListManagerView',
    component: ProductListManagerView
  },
]
const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})
export default router
