<template>
  <div class="authentication-container">
    <div class="auth-content">
      <div class="auth-form">
        <h4 class="form-title">Đăng nhập vào tài khoản của bạn</h4>
        <form @submit.prevent="handleLogin">
          <div v-if="error" class="alert alert-danger">{{ error }}</div>
          <div class="form-group">
            <label for="email"><strong>Email người dùng</strong></label>
            <input v-model="email" type="text" id="email" name="email" class="form-control" placeholder="Email người dùng" required>
          </div>
          <div class="form-group">
            <label for="password"><strong>Mật khẩu</strong></label>
            <div class="password-input-container">
              <input v-model="password" :type="passwordFieldType" id="password" class="form-control" placeholder="Mật khẩu" required>
              <font-awesome-icon :icon="passwordIcon" class="toggle-password" @click="togglePasswordVisibility" />
            </div>
          </div>
          <div class="form-options">
            <div class="form-check">
              <input class="form-check-input" type="checkbox" id="rememberMe">
              <label class="form-check-label" for="rememberMe">Ghi nhớ tôi</label>
            </div>
            <div class="form-link">
              <a href="">Quên mật khẩu?</a>
            </div>
          </div>
          <div class="form-action">
            <button type="submit" class="btn btn-primary btn-block">Đăng nhập</button>
          </div>
        </form>
        <div class="new-account">
          <p>Chưa có tài khoản? <router-link class="text-primary" to="/register">Đăng ký</router-link></p>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import axios from 'axios';
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome';
import { faEye, faEyeSlash } from '@fortawesome/free-solid-svg-icons';

export default {
  components: {
    FontAwesomeIcon,
  },
  data() {
    return {
      email: '',
      password: '',
      error: '',  // Biến để lưu thông báo lỗi
      passwordFieldType: 'password',
      passwordIcon: faEye,
    };
  },
  methods: {
    async handleLogin() {
      this.error = '';  // Reset lỗi trước khi đăng nhập
      try {
        const response = await axios.post('https://localhost:7074/api/Login/loginCustomer', {
          email: this.email,
          password: this.password
        });

        // Lưu token vào localStorage (hoặc Vuex state nếu bạn sử dụng Vuex)
        localStorage.setItem('token', response.data.token);

        // Chuyển hướng đến trang sau khi đăng nhập thành công
        this.$router.push('/product');  // Chuyển hướng đến trang sản phẩm sau khi đăng nhập thành công
      } catch (error) {
        if (error.response && error.response.status === 400) {
          this.error = "Tên đăng nhập hoặc mật khẩu không đúng";  // Hiển thị thông báo lỗi cụ thể
        } else {
          this.error = "Đã xảy ra lỗi khi đăng nhập. Vui lòng thử lại.";
        }
        console.error('Lỗi đăng nhập:', error);
      }
    },
    togglePasswordVisibility() {
      if (this.passwordFieldType === 'password') {
        this.passwordFieldType = 'text';
        this.passwordIcon = faEyeSlash;
      } else {
        this.passwordFieldType = 'password';
        this.passwordIcon = faEye;
      }
    },
  },
};
</script>

<style scoped>
.authentication-container {
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100vh;
  background-image: url('/src/assets/brglg.jpg');
  background-size: cover;
}

.auth-content {
  background: #ffffff;
  padding: 40px;
  border-radius: 8px;
  box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
  max-width: 400px;
  width: 100%;
}

.auth-form {
  display: flex;
  flex-direction: column;
}

.form-title {
  margin-bottom: 20px;
  text-align: center;
  font-size: 24px;
  font-weight: 600;
  color: #333;
}

.form-group {
  margin-bottom: 20px;
}

.form-group label {
  display: block;
  margin-bottom: 8px;
  font-weight: 500;
  color: #555;
}

.form-group input {
  width: 100%;
  padding: 10px;
  border: 1px solid #ddd;
  border-radius: 4px;
}

.form-options {
  display: flex;
  justify-content: space-between;
  align-items: center;
  margin-bottom: 20px;
}

.form-check {
  display: flex;
  align-items: center;
}

.form-check-input {
  margin-right: 8px;
}

.form-check-label {
  font-size: 14px;
  color: #555;
}

.form-link a {
  font-size: 14px;
  color: #007bff;
  text-decoration: none;
}

.form-link a:hover {
  text-decoration: underline;
}

.form-action {
  text-align: center;
}

.btn-block {
  width: 100%;
  padding: 10px;
  background-color: #007bff;
  border: none;
  border-radius: 4px;
  color: #fff;
  font-size: 16px;
  cursor: pointer;
}

.btn-block:hover {
  background-color: #0056b3;
}

.new-account {
  text-align: center;
  margin-top: 20px;
}

.new-account p {
  font-size: 14px;
  color: #555;
}

.new-account .text-primary {
  color: #007bff;
}

.new-account .text-primary:hover {
  text-decoration: underline;
}

.password-input-container {
  position: relative;
}

.toggle-password {
  position: absolute;
  top: 50%;
  right: 10px;
  transform: translateY(-50%);
  cursor: pointer;
  color: #000; /* Màu sắc của icon */
  font-size: 16px;
}

.toggle-password:hover {
  color: #0056b3;
}
</style>
