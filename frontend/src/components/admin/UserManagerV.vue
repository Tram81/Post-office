<template>
  <div class="container mt-4">
    <h2>User Manager</h2>

    <!-- Form for creating or editing users -->
    <form @submit.prevent="handleSubmit">
      <div class="mb-3">
        <label for="username" class="form-label">Username</label>
        <input v-model="user.name" type="text" class="form-control" id="username" required>
      </div>
      <div class="mb-3">
        <label for="email" class="form-label">Email address</label>
        <input v-model="user.email" type="email" class="form-control" id="email" required>
      </div>
      <div class="mb-3">
        <label for="address" class="form-label">Address</label>
        <input v-model="user.address" type="text" class="form-control" id="address" required>
      </div>
      <div class="mb-3">
        <label for="phone" class="form-label">Phone</label>
        <input v-model="user.phone" type="text" class="form-control" id="phone" required>
      </div>
      <div class="mb-3">
        <label for="password" class="form-label">Password</label>
        <div class="input-group">
          <input v-model="user.password" :type="passwordFieldType" class="form-control" id="password" required>
          <button class="btn btn-outline-secondary" type="button" @click="togglePasswordVisibility">
            <font-awesome-icon :icon="passwordIcon" class="toggle-password"></font-awesome-icon>
          </button>
        </div>
      </div>
      <button type="submit" class="btn btn-primary">{{ editingUser !== null ? 'Update' : 'Create' }} User</button>
    </form>

    <!-- User list -->
    <div class="mt-4">
      <h3>User List</h3>
      <table class="table">
        <thead>
          <tr>
            <th>Username</th>
            <th>Email</th>
            <th>Address</th>
            <th>Phone</th>
            <th>Action</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="(user, index) in userList" :key="index">
            <td>{{ user.name }}</td>
            <td>{{ user.email }}</td>
            <td>{{ user.address }}</td>
            <td>{{ user.phone }}</td>
            <td>
              <button class="btn btn-sm btn-primary" @click="editUser(user)">Edit</button>
              <button class="btn btn-sm btn-danger" @click="deleteUser(index)">Delete</button>
            </td>
          </tr>
        </tbody>
      </table>
    </div>
  </div>
</template>

<script>
import axios from 'axios';
import { ref, onMounted } from 'vue';
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome';
import { faEye, faEyeSlash } from '@fortawesome/free-solid-svg-icons';
import CryptoJS from 'crypto-js';

export default {
  name: 'UserManagerV',
  components: {
    FontAwesomeIcon,
  },
  setup() {
    const user = ref({
      name: '',
      email: '',
      address: '',
      phone: '',
      password: '',
    });

    const userList = ref([]);
    const editingUser = ref(null);
    const showPassword = ref(false);
    const passwordIcon = ref(faEye);
    const passwordFieldType = ref('password');

    const apiUrl = 'https://localhost:7074/api/Customer'; // Thay đổi URL API tương ứng với backend của bạn

    // Function to fetch initial user list from backend
    const fetchUsers = async () => {
      try {
        const response = await axios.get(`${apiUrl}/GetAll`);
        userList.value = response.data; // Assume API returns an array of users
      } catch (error) {
        console.error('Failed to fetch users:', error);
      }
    };

    // Fetch initial user list when component is mounted
    onMounted(fetchUsers);

    const handleSubmit = async () => {
      try {
        // Hash the password using MD5 (for demonstration purposes)
        const hashedPassword = CryptoJS.MD5(user.value.password).toString();

        // Create a copy of the user object with the hashed password
        const userToSubmit = { ...user.value, password: hashedPassword };

        if (editingUser.value !== null) {
          // Update existing user
          const userId = userList.value[editingUser.value].id; // Assuming there's an 'id' field in user object
          await axios.put(`${apiUrl}/Update/${userId}`, userToSubmit);
          userList.value[editingUser.value] = { ...user.value };
          editingUser.value = null;
        } else {
          // Add new user
          await axios.post(`${apiUrl}/Create`, userToSubmit);
          await fetchUsers(); // Fetch the updated user list after adding a new user
        }
        clearForm();
      } catch (error) {
        console.error('Failed to create/update user:', error);
      }
    };

    const deleteUser = async (index) => {
      try {
        const userId = userList.value[index].id;
        await axios.delete(`${apiUrl}/Delete/${userId}`);
        userList.value.splice(index, 1);
      } catch (error) {
        console.error('Failed to delete user:', error);
      }
    };

    const editUser = (userToEdit) => {
      user.value = { ...userToEdit };
      editingUser.value = userList.value.indexOf(userToEdit);
    };

    const togglePasswordVisibility = () => {
      showPassword.value = !showPassword.value;
      updatePasswordIcon();
    };

    const updatePasswordIcon = () => {
      passwordIcon.value = showPassword.value ? faEyeSlash : faEye;
      passwordFieldType.value = showPassword.value ? 'text' : 'password';
    };

    const clearForm = () => {
      user.value = {
        name: '',
        email: '',
        address: '',
        phone: '',
        password: '',
      };
      editingUser.value = null;
      showPassword.value = false;
      updatePasswordIcon();
    };

    return {
      user,
      userList,
      editingUser,
      handleSubmit,
      editUser,
      deleteUser,
      togglePasswordVisibility,
      passwordIcon,
      passwordFieldType,
    };
  },
};
</script>

<style scoped>
/* Global container style */
.container {
  max-width: 800px;
  margin: 20px auto;
  padding: 20px;
  background-color: #f8f9fa;
  border: 1px solid #ddd;
  border-radius: 8px;
  box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
}

/* Form style */
form {
  background-color: #fff;
  padding: 20px;
  border: 1px solid #ccc;
  border-radius: 8px;
  box-shadow: 0 0 5px rgba(0, 0, 0, 0.1);
}

form .form-label {
  font-weight: bold;
}

form input[type="text"],
form input[type="email"],
form input[type="password"] {
  width: 100%;
  padding: 10px;
  font-size: 16px;
  border: 1px solid #ccc;
  border-radius: 4px;
}

form .input-group {
  position: relative;
}

form .input-group button {
  position: absolute;
  right: 0;
  top: 50%;
  transform: translateY(-50%);
}

/* Table style */
.table {
  width: 100%;
  margin-top: 20px;
  border-collapse: collapse;
}

.table th,
.table td {
  border: 1px solid #ddd;
  padding: 8px;
}

.table th {
  background-color: #007bff;
  color: #fff;
}

.table td {
  background-color: #fff;
}

.table .btn {
  margin-right: 5px;
}

/* Button style */
.btn {
  padding: 8px 16px;
  font-size: 14px;
  border-radius: 4px;
  cursor: pointer;
}

.btn-primary {
  background-color: #007bff;
  color: #fff;
  border: none;
}

.btn-primary:hover {
  background-color: #0056b3;
}

.btn-danger {
  background-color: #dc3545;
  color: #fff;
  border: none;
}

.btn-danger:hover {
  background-color: #c82333;
}

/* Responsive adjustments */
@media (max-width: 768px) {
  .container {
    padding: 10px;
  }

  form,
  .table {
    padding: 15px;
  }
}
</style>

