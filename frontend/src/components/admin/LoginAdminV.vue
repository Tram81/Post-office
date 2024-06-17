<template>
  <div class="authentication-container">
    <div class="auth-content">
      <div class="auth-form">
        <h4 class="form-title">Đăng nhập vào tài khoản của bạn</h4>
        <form @submit.prevent="handleLogin">
          <div v-if="error" class="alert alert-danger">{{ error }}</div>
          <div class="form-group">
            <label for="username"><strong>Tên đăng nhập</strong></label>
            <input v-model="username" type="text" id="username" name="username" class="form-control" placeholder="Tên đăng nhập" required>
          </div>
          <div class="form-group">
            <label for="password"><strong>Mật khẩu</strong></label>
            <div class="password-input-container">
              <input v-model="password" :type="passwordFieldType" id="password" class="form-control" placeholder="Mật khẩu" required>
              <font-awesome-icon :icon="passwordIcon" class="toggle-password" @click="togglePasswordVisibility" />
            </div>
          </div>
          <div class="form-action">
            <button type="submit" class="btn btn-primary btn-block">Đăng nhập</button>
          </div>
        </form>
      </div>
    </div>
  </div>
</template>

<script>
import axios from 'axios';
import router from '../../router'; // Đảm bảo đường dẫn router đúng với cấu trúc thư mục của bạn
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome';
import { faEye, faEyeSlash } from '@fortawesome/free-solid-svg-icons';

export default {
  components: {
    FontAwesomeIcon,
  },
  data() {
    return {
      username: '',
      password: '',
      error: '', // Biến để lưu thông báo lỗi
      passwordFieldType: 'password',
      passwordIcon: faEye,
    };
  },
  methods: {
    async handleLogin() {
      this.error = ''; // Reset lỗi trước khi đăng nhập
      try {
        const response = await axios.post('https://localhost:7074/api/Auth/Login', {
          username: this.username,
          password: this.password,
        });

        // Lưu token vào localStorage (hoặc Vuex state nếu bạn sử dụng Vuex)
        localStorage.setItem('token', response.data.token);

        // Chuyển hướng đến trang admin sau khi đăng nhập thành công
        router.push('/admin/Dashboard');
      } catch (error) {
        if (error.response && error.response.status === 400) {
          this.error = 'Tên đăng nhập hoặc mật khẩu không đúng'; // Hiển thị thông báo lỗi cụ thể
        } else {
          this.error = 'Đã xảy ra lỗi trong quá trình đăng nhập. Vui lòng thử lại.';
        }
        console.error('Lỗi đăng nhập:', error);
      }
    },
    togglePasswordVisibility() {
      this.passwordFieldType = this.passwordFieldType === 'password' ? 'text' : 'password';
      this.passwordIcon = this.passwordFieldType === 'password' ? faEye : faEyeSlash;
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
  background: #3b3737;
}

.auth-content {
  background: #b5e9f8;
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
  border: 1px solid #ffe7e7;
  border-radius: 4px;
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
  color: #ffffff;
  font-size: 16px;
  cursor: pointer;
}

.btn-block:hover {
  background-color: #0056b3;
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
  color: #000; 
  font-size: 16px;
}

.toggle-password:hover {
  color: #0056b3;
}
</style>
