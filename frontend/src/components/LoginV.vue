<template>
    <div class="container mt-5">
      <h2>Đăng Nhập</h2>
      <form @submit.prevent="handleLogin">
        <div class="mb-3">
          <label for="email" class="form-label">Email</label>
          <input type="email" class="form-control" id="email" v-model="email" required>
        </div>
        <div class="mb-3">
          <label for="password" class="form-label">Mật khẩu</label>
          <input type="password" class="form-control" id="password" v-model="password" required>
        </div>
        <button type="submit" class="btn btn-primary">Đăng Nhập</button>
      </form>
    </div>
</template>
  
  <script>
  export default {
    data() {
      return {
        email: '',
        password: ''
      }
    },
    methods: {
      handleLogin() {
        // Logic xử lý đăng nhập
        console.log('Đăng nhập với:', this.email, this.password);
      }
    }
  }
  </script>
  

<style scoped>
    @import url("@/assets/css/responsive.css");
    @import url("@/assets/css/bootstrap.css");
    @import url("@/assets/css/style.css");
</style>