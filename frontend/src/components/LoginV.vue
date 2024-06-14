<template>
  <div class="authincation h-100">
    <div class="container-fluid h-100">
      <div class="row justify-content-center h-100 align-items-center">
        <div class="col-md-6">
          <div class="authincation-content">
            <div class="row no-gutters">
              <div class="col-xl-12">
                <div class="auth-form">
                  <h4 class="text-center mb-4">Sign in your account</h4>
                  <form @submit.prevent="handleLogin">
                    <div v-if="error" class="alert alert-danger">{{ error }}</div>
                    <div class="form-group">
                      <label for="username"><strong>Tên đăng nhập</strong></label>
                      <input v-model="username" type="text" id="username" name="username" class="form-control" required>
                    </div>
                    <div class="form-group">
                      <label><strong>Password</strong></label>
                      <input v-model="password" type="password" class="form-control" required>
                    </div>
                    <div class="form-row d-flex justify-content-between mt-4 mb-2">
                      <div class="form-group">
                        <div class="form-check ml-2">
                          <input class="form-check-input" type="checkbox" id="rememberMe">
                          <label class="form-check-label" for="rememberMe">Remember me</label>
                        </div>
                      </div>
                      <div class="form-group">
                        <a href="page-forgot-password.html">Forgot Password?</a>
                      </div>
                    </div>
                    <div class="text-center">
                      <button type="submit" class="btn btn-primary btn-block">Sign me in</button>
                    </div>
                  </form>
                  <div class="new-account mt-3">
                    <p>Don't have an account? <router-link class="text-primary" to="/register">Sign up</router-link></p>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import axios from 'axios';
import router from '../router'; // Đảm bảo import router từ Vue Router

export default {
  data() {
    return {
      username: '',
      password: '',
      error: ''  // Biến để lưu thông báo lỗi
    };
  },
  methods: {
    async handleLogin() {
      this.error = '';  // Reset lỗi trước khi đăng nhập
      try {
        const response = await axios.post('https://localhost:7074/api/Auth/Login', {
          username: this.username,
          password: this.password
        });

        // Lưu token vào localStorage (hoặc Vuex state nếu bạn sử dụng Vuex)
        localStorage.setItem('token', response.data.token);

        // Chuyển hướng đến trang sau khi đăng nhập thành công
        router.push('/');
      } catch (error) {
        if (error.response && error.response.status === 400) {
          this.error = "Tên đăng nhập hoặc mật khẩu không đúng";  // Hiển thị thông báo lỗi cụ thể
        } else {
          this.error = "An error occurred during login. Please try again.";
        }
        console.error('Login error:', error);
      }
    }
  }
};
</script>


<style scoped>
body {
  font-family: "Roboto", sans-serif;
  font-size: 0.875rem;
  font-weight: 400;
  line-height: 1.5;
  color: #BDBDC7;
  text-align: left;
}

.auth-form {
  padding: 50px 50px;
}

*, *::before, *::after {
  box-sizing: border-box;
}
</style>
