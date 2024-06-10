import { createRouter, createWebHistory } from 'vue-router'

import Home from '@/views/HomePage.vue'
import Test from '@/views/TestView.vue'
import Company from '@/components/CompanyV.vue'
import Service from '@/components/ServiceV.vue'
import Shop from '@/components/ShopV.vue'
import Product from '@/components/ProductListV.vue'
import Register from '@/components/RegisterV.vue'
import Login from '@/components/LoginV.vue'
import crud from '@/components/CRUD.vue'




const routes = [
  {
    path: '/crud',
    name: 'CRUD',
    component: crud
  },
  {
    path: '/Register',
    name: 'RegisterV',
    component: Register
  },
  {
    path: '/Login',
    name: 'LoginV',
    component: Login
  },
  {
    path: '/home',
    name: 'HomePage',
    component: Home,
    // meta: { requiresAuth: true } // Thêm meta data để chỉ định rằng trang cần đăng nhập
  },
  {
    path: '/Company',
    name: 'CompanyV',
    component: Company
  },
  {
    path: '/Service',
    name: 'ServiceV',
    component: Service
  },
  {
    path: '/Shop',
    name: 'ShopV',
    component: Shop
  },
  {
    path: '/Product',
    name: 'ProductListV',
    component: Product
  },
  {
    path: '/test',
    name: 'Test',
    component: Test
  },
]


const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})
// bắt đăng nhập với vào được trang 
// router.beforeEach((to, from, next) => {
//   const token = localStorage.getItem('token');

//   // Kiểm tra meta data của trang yêu cầu đăng nhập
//   if (to.meta.requiresAuth) {
//     if (!token) {
//       // Chưa đăng nhập, chuyển hướng đến trang đăng nhập phù hợp
//       if (to.path.startsWith('/admin')) {
//         next('/admin/singin');
//       } else {
//         next('/login');
//       }
//     } else {
//       // Đã đăng nhập, cho phép truy cập vào trang
//       next();
//     }
//   } else {
//     // Trang không yêu cầu đăng nhập, cho phép truy cập
//     next();
//   }
//});



export default router
