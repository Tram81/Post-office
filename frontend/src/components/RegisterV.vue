<template>
  <div class="authentication-container">
    <div class="auth-content">
      <div class="auth-form">
        <h4 class="form-title">Đăng ký tài khoản mới</h4>
        <form @submit.prevent="register" id="register-form">
          <div v-if="error" class="alert alert-danger">{{ error }}</div>
          
          <div class="form-group">
            <label for="username"><strong>Tên đăng nhập</strong></label>
            <input v-model="username" type="text" id="username" name="username" class="form-control" placeholder="Tên đăng nhập" required />
          </div>
          
          <div class="form-group">
            <label for="email"><strong>Email</strong></label>
            <input v-model="email" type="email" id="email" name="email" class="form-control" placeholder="Email" required />
          </div>
          
          <div class="form-group">
            <label for="password"><strong>Mật khẩu</strong></label>
            <div class="password-input-container">
              <input v-model="password" :type="passwordFieldType" id="password" name="password" class="form-control" placeholder="Mật khẩu" required />
              <font-awesome-icon :icon="passwordIcon" class="toggle-password" @click="togglePasswordVisibility('password')" />
            </div>
          </div>
          
          <div class="form-group">
            <label for="confirmPassword"><strong>Xác nhận mật khẩu</strong></label>
            <div class="password-input-container">
              <input v-model="confirmPassword" :type="confirmPasswordFieldType" id="confirmPassword" name="confirmPassword" class="form-control" placeholder="Xác nhận mật khẩu" required />
              <font-awesome-icon :icon="confirmPasswordIcon" class="toggle-password" @click="togglePasswordVisibility('confirmPassword')" />
            </div>
          </div>
          
          <div class="form-action">
            <button type="submit" class="btn btn-primary btn-block">Đăng ký</button>
          </div>
        </form>
        
        <div class="new-account">
          <p>Đã có tài khoản? <router-link class="text-primary" to="/login">Đăng nhập</router-link></p>
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
      username: '',
      email: '',
      password: '',
      confirmPassword: '',
      error: '',
      passwordFieldType: 'password',
      confirmPasswordFieldType: 'password',
      passwordIcon: faEye,
      confirmPasswordIcon: faEye,
    };
  },
  methods: {
    async register() {
      if (this.password !== this.confirmPassword) {
        this.error = 'Mật khẩu và xác nhận mật khẩu không khớp.';
        return;
      }

      try {
        const response = await axios.post('https://localhost:7074/api/Auth/Register', {
          username: this.username,
          email: this.email,
          password: this.password,
          Role: 'CUSTOMER'
        });
        localStorage.setItem('token', response.data.token);
        this.$router.push('/login');
      } catch (error) {
        if (error.response && error.response.data) {
          if (error.response.data === 'Username already exists') {
            this.error = 'Tên đăng nhập đã tồn tại.';
          } else if (error.response.data === 'Email already exists') {
            this.error = 'Email đã tồn tại.';
          } else {
            this.error = error.response.data;
          }
        } else {
          console.error("Registration error:", error);
        }
      }
    },
    togglePasswordVisibility(field) {
      if (field === 'password') {
        this.passwordFieldType = this.passwordFieldType === 'password' ? 'text' : 'password';
        this.passwordIcon = this.passwordFieldType === 'password' ? faEye : faEyeSlash;
      } else if (field === 'confirmPassword') {
        this.confirmPasswordFieldType = this.confirmPasswordFieldType === 'password' ? 'text' : 'password';
        this.confirmPasswordIcon = this.confirmPasswordFieldType === 'password' ? faEye : faEyeSlash;
      }
    }
  },
};
</script>

<style scoped>
.authentication-container {
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100vh;
  background: #f7f7f7;
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