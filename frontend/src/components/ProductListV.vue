<template>
  <div>
    <h1>Danh sách sản phẩm</h1>
    <ul>
      <li v-for="product in products" :key="product.productID">
        <h2>{{ product.productName }}</h2>
        <p>{{ product.description }}</p>
        <p>Giá: {{ product.price }}</p>
        <p>Số lượng tồn kho: {{ product.quantityStock }}</p>
      </li>
    </ul>
  </div>
  <div class="container mt-5">
    <h2>Đăng Ký</h2>
    <form @submit.prevent="handleRegister">
      <div class="mb-3">
        <label for="username" class="form-label">Tên người dùng</label>
        <input type="text" class="form-control" id="username" v-model="username" required>
      </div>
      <div class="mb-3">
        <label for="email" class="form-label">Email</label>
        <input type="email" class="form-control" id="email" v-model="email" required>
      </div>
      <div class="mb-3">
        <label for="password" class="form-label">Mật khẩu</label>
        <input type="password" class="form-control" id="password" v-model="password" required>
      </div>
      <button type="submit" class="btn btn-primary">Đăng Ký</button>
    </form>
  </div>
</template>

<script>
import axios from 'axios';

export default {
  data() {
    return {
      products: []
    };
  },
  created() {
    this.fetchProducts();
  },
  methods: {
    fetchProducts() {
      axios.get('http://localhost:5155/api/Product')
        .then(response => {
          this.products = response.data;
        })
        .catch(error => {
          console.error('There was an error fetching the products!', error);
        });
    }
  }
};
</script>

<style>
/* Add your styles here */
</style>


<style scoped>
@import url("@/assets/css/responsive.css");
@import url("@/assets/css/bootstrap.css");
@import url("@/assets/css/style.css");
</style>