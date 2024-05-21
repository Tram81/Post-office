import { createRouter, createWebHistory } from 'vue-router'

import Home from '@/views/HomePage.vue'
import Test from '@/views/TestView.vue'
import Company from '@/components/CompanyV.vue'
import Contact from '@/components/ContactV.vue'
import Service from '@/components/ServiceV.vue'
import Shop from '@/components/ShopV.vue'
import About from '@/components/CompanyV.vue'



const routes = [
  // {
  //   path: '/register',
  //   name: 'Register',
  //   component: Register
  // },

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
    path: '/Contact',
    name: 'ContactV',
    component: Contact
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
    path: '/About',
    name: 'AboutV',
    component: About
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