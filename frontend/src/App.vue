<template>
  <!-- <nav>
    <router-link to="/register">Đăng ký</router-link> |
    <router-link to="/login">Đăng nhập</router-link>
  </nav> -->
  <!-- <div>
    <h1>Xin chào các bạn </h1>
  </div> -->
  <router-view />
  <!-- <div>
    fotter
  </div> -->
  <div id="app">
    <ProductList />
  </div>

</template>

<script>
import ProductList from '@/components/ProductListV.vue';


export default {
  name: 'App',
  components: {
    ProductList,
    
  }
};
</script>


<style>
/* Add your styles here */
</style>


