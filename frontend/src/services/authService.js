// src/services/authService.js

import axios from 'axios';

const API_URL = 'http://localhost:7074/auth/';

class AuthService {
  async register(user) {
    try {
      const response = await axios.post(API_URL + 'register', {
        username: user.username,
        email: user.email,
        password: user.password
      });

      if (response.data.token) {
        localStorage.setItem('user', JSON.stringify(response.data));
      }

      return response.data;
    } catch (error) {
      throw error;
    }
  }

  logout() {
    localStorage.removeItem('user');
  }
}

export default new AuthService();
