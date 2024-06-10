<template>
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
export default {
  data() {
    return {
      username: '',
      email: '',
      password: ''
    }
  },
  methods: {
    handleRegister() {
      // Logic xử lý đăng ký
      console.log('Đăng ký với:', this.username, this.email, this.password);
    }
  }
}
</script>


<style scoped>
@import url("@/assets/css/responsive.css");
@import url("@/assets/css/bootstrap.css");
@import url("@/assets/css/style.css");
</style>