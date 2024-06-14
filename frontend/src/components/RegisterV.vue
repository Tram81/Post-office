<template>
  <div class="container">
    <h2>Register</h2>
    <form @submit.prevent="register" id="register-form">
      <div v-if="error" class="error-message">{{ error }}</div>

      <label for="username">Username:</label>
      <input v-model="username" placeholder="username" type="username" id="username" name="username" required />

      <label for="email">Email:</label>
      <input v-model="email" placeholder="Email" type="email" id="email" name="email" required />

      <label for="password">Password:</label>
      <input v-model="password" placeholder="Password" type="password" id="password" name="password" required />
      
      <button type="submit">Register</button>
      <div class="new-account mt-3">
        <p>have an account? <a class="text-primary" href="/login">Sign up</a></p>
      </div>
    </form>
  </div>
</template>


<script>
import axios from 'axios'
import { mapActions } from 'vuex';

export default {
  data() {
    return {
      username: '',
      email: '',
      password: '',
      error: '',  // Thêm biến error để lưu trữ thông báo lỗi
    };
  },
  methods: {
    ...mapActions(['register']),
    async register() {
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
          this.error = error.response.data;  // Hiển thị thông báo lỗi từ phản hồi API
        } else {
          this.error = "An error occurred during registration. Please try again.";
        }
        console.error("Registration error:", error);
      }
    },
  },
};
</script>



<style scoped>
  body {
    font-family: Arial, sans-serif;
    background-color: #f2f2f2;
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    margin: 0;
}

.container {
    width: 300px;
    padding: 20px;
    background-color: white;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    border-radius: 10px;
}

h2 {
    text-align: center;
    margin-bottom: 20px;
}

label {
    display: block;
    margin: 10px 0 5px;
}

input {
    width: 100%;
    padding: 10px;
    margin-bottom: 20px;
    border: 1px solid #ccc;
    border-radius: 5px;
}

button {
    width: 100%;
    padding: 10px;
    background-color: #4CAF50;
    color: white;
    border: none;
    border-radius: 5px;
    cursor: pointer;
    font-size: 16px;
}

button:hover {
    background-color: #45a049;
}

.error-message {
    color: red;
    margin-bottom: 20px;
    text-align: center;
}
</style>
