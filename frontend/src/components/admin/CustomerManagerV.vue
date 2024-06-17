<template>
  <div class="layout">
    <NavbarAdmin />
    <div class="main-content">
      <SidebarAdmin />
      <div class="container mt-4">
        <h2>Quản lý Người dùng</h2>

        <!-- Form để tạo hoặc chỉnh sửa người dùng -->
        <form @submit.prevent="handleSubmit">
          <div class="mb-3">
            <label for="username" class="form-label">Tên người dùng</label>
            <input v-model="user.name" type="text" class="form-control" id="username" required>
          </div>
          <div class="mb-3">
            <label for="email" class="form-label">Địa chỉ Email</label>
            <input v-model="user.email" type="email" class="form-control" id="email" required>
          </div>
          <div class="mb-3">
            <label for="address" class="form-label">Địa chỉ</label>
            <input v-model="user.address" type="text" class="form-control" id="address" required>
          </div>
          <div class="mb-3">
            <label for="phone" class="form-label">Điện thoại</label>
            <input v-model="user.phone" type="text" class="form-control" id="phone" required>
          </div>
          <div class="mb-3">
            <label for="password" class="form-label">Mật khẩu</label>
            <div class="input-group">
              <input v-model="user.password" :type="passwordFieldType" class="form-control" id="password" required>
              <button class="btn btn-outline-secondary" type="button" @click="togglePasswordVisibility">
                <font-awesome-icon :icon="passwordIcon" class="toggle-password"></font-awesome-icon>
              </button>
            </div>
          </div>
          <button type="submit" class="btn btn-primary">{{ editingUser !== null ? 'Cập nhật' : 'Tạo mới' }} Người dùng</button>
        </form>

        <!-- Danh sách người dùng -->
        <div class="mt-4">
          <h3>Danh sách Người dùng</h3>
          <table class="table">
            <thead>
              <tr>
                <th>ID</th>
                <th>Tên người dùng</th>
                <th>Email</th>
                <th>Địa chỉ</th>
                <th>Điện thoại</th>
                <th>Hành động</th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="user in userList" :key="user.id">
                <td>{{ user.id }}</td>
                <td>{{ user.name }}</td>
                <td>{{ user.email }}</td>
                <td>{{ user.address }}</td>
                <td>{{ user.phone }}</td>
                <td>
                  <button class="btn btn-sm btn-primary" @click="editUser(user)">Sửa</button>
                  <button class="btn btn-sm btn-danger" @click="deleteUser(user.id)">Xóa</button>
                </td>
              </tr>
            </tbody>
          </table>
        </div>
      </div>
    </div>
    <FooterAdmin />
  </div>
</template>

<script>
import axios from 'axios';
import { ref, onMounted } from 'vue';
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome';
import { faEye, faEyeSlash } from '@fortawesome/free-solid-svg-icons';
import CryptoJS from 'crypto-js';
import SidebarAdmin from './SidebarAdminV.vue';
import NavbarAdmin from './NavbarAdminV.vue';
import FooterAdmin from './FooterAdminV.vue';

export default {
  name: 'CustomerManagerV',
  components: {
    FontAwesomeIcon,
    SidebarAdmin,
    NavbarAdmin,
    FooterAdmin
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
        userList.value = response.data; // Giả sử API trả về một mảng các người dùng
      } catch (error) {
        console.error('Lỗi khi tải danh sách người dùng:', error);
      }
    };

    // Fetch initial user list when component is mounted
    onMounted(fetchUsers);

    const handleSubmit = async () => {
      try {
        // Hash mật khẩu sử dụng MD5 (cho mục đích minh họa)
        const hashedPassword = CryptoJS.MD5(user.value.password).toString();

        // Tạo một bản sao của đối tượng người dùng với mật khẩu đã hash
        const userToSubmit = { ...user.value, password: hashedPassword };

        if (editingUser.value !== null) {
          // Cập nhật người dùng đã có
          const userId = userList.value[editingUser.value].id; // Giả sử có trường 'id' trong đối tượng người dùng
          await axios.put(`${apiUrl}/Update/${userId}`, userToSubmit);
          userList.value[editingUser.value] = { ...user.value, id: userId };
          editingUser.value = null;
        } else {
          // Thêm người dùng mới
          const response = await axios.post(`${apiUrl}/Create`, userToSubmit);
          userToSubmit.id = response.data.id; // Giả sử API trả về ID của người dùng đã được tạo
          userList.value.push(userToSubmit);
        }
        clearForm();
      } catch (error) {
        console.error('Lỗi khi tạo/cập nhật người dùng:', error);
      }
    };

    const deleteUser = async (userId) => {
      try {
        await axios.delete(`${apiUrl}/Delete/${userId}`);
        userList.value = userList.value.filter(user => user.id !== userId);
      } catch (error) {
        console.error('Lỗi khi xóa người dùng:', error);
      }
    };

    const editUser = (userToEdit) => {
      user.value = { ...userToEdit };
      editingUser.value = userList.value.findIndex(u => u.id === userToEdit.id);
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
/* Định dạng chung cho layout */
.layout {
  display: flex;
  flex-direction: column;
  min-height: 100vh;
}

.main-content {
  display: flex;
  flex: 1;
  background-color: #f7f7f7;
}

/* Định dạng cho sidebar */
.sidebar {
  width: 250px;
  background-color: #ffffff;
  padding: 20px;
  border-right: 1px solid #ddd;
  display: flex;
  flex-direction: column;
}

.sidebar h2 {
  margin-bottom: 20px;
}

.sidebar-link {
  text-decoration: none;
  color: #333;
  margin-bottom: 10px;
  padding: 8px 16px;
  border-radius: 4px;
  transition: background-color 0.3s ease;
}

.sidebar-link:hover {
  background-color: #f0f0f0;
}

.active-link {
  background-color: #e0e0e0;
}

/* Định dạng cho container */
.container {
  flex: 1;
  max-width: 800px;
  margin: 20px;
  padding: 20px;
  background-color: #f8f9fa;
  border: 1px solid #ddd;
  border-radius: 8px;
  box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
}

/* Định dạng cho form */
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

/* Định dạng cho bảng */
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

/* Định dạng cho nút */
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

/* Định dạng responsive */
@media (max-width: 768px) {
  .main-content {
    flex-direction: column;
  }

  .sidebar {
    width: 100%;
    border-right: none;
    border-bottom: 1px solid #ddd;
  }

  .container {
    margin: 0 10px;
  }
}
</style>