<template>
  <div class="layout">
    <NavbarAdmin />
    <div class="main-content">
      <SidebarAdmin />
      <div class="container mt-4">
        <h2>Quản lý Sản phẩm</h2>
        <!-- Form để tạo hoặc chỉnh sửa sản phẩm -->
        <form @submit.prevent="handleSubmit">
          <div class="mb-3">
            <label for="name" class="form-label">Tên sản phẩm</label>
            <input v-model="localProduct.name" type="text" class="form-control" id="name" required>
          </div>
          <div class="mb-3">
            <label for="description" class="form-label">Mô tả</label>
            <input v-model="localProduct.description" type="text" class="form-control" id="description" required>
          </div>
          <div class="mb-3">
            <label for="price" class="form-label">Giá (VNĐ)</label>
            <input v-model="localProduct.price" type="text" class="form-control" id="price" required>
          </div>
          <div class="mb-3">
            <label for="quantity" class="form-label">Số lượng</label>
            <input v-model="localProduct.quantity" type="text" class="form-control" id="quantity" required>
          </div>
          <button type="submit" class="btn btn-primary">{{ editingProduct !== null ? 'Cập nhật' : 'Tạo mới' }} Sản phẩm</button>
        </form>

        <!-- Danh sách sản phẩm -->
        <table class="table mt-4">
          <thead>
            <tr>
              <th>ID</th>
              <th>Tên sản phẩm</th>
              <th>Mô tả</th>
              <th>Giá (VNĐ)</th>
              <th>Số lượng tồn kho</th>
              <th>Hành động</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="p in products" :key="p.productID">
              <td>{{ p.productID }}</td>
              <td>{{ p.productName }}</td>
              <td>{{ p.description }}</td>
              <td>{{ formatCurrency(p.priceInVND) }}</td>
              <td>{{ p.quantityStock }}</td>
              <td>
                <button class="btn btn-sm btn-primary" @click="editProduct(p)">Sửa</button>
                <button class="btn btn-sm btn-danger" @click="deleteProduct(p.productID)">Xóa</button>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
    <FooterAdmin />
  </div>
</template>

<script>
import SidebarAdmin from './SidebarAdminV.vue';
import NavbarAdmin from './NavbarAdminV.vue';


import FooterAdmin from './FooterAdminV.vue';
import axios from 'axios';

export default {
  name: 'ProductListManagerV',
  components: {
      SidebarAdmin,
      NavbarAdmin,
      FooterAdmin
    },
  data() {
    return {
      products: [],
      localProduct: {
        name: '',
        price: null,
        description: '',
        quantity: null
      },
      editingProduct: null,
      exchangeRate: 23000 // Tỷ giá VNĐ/USD, có thể thay đổi theo nhu cầu thực tế
    };
  },
  methods: {
    async fetchProducts() {
      var url = process.env.VUE_APP_BASE_URL + `Product/GetAll`;
      try {
        const response = await axios.get(url);
        this.products = response.data;
        // Chuyển đổi giá từ USD sang VNĐ
        this.products.forEach(product => {
          product.priceInVND = product.price * this.exchangeRate;
        });
      } catch (error) {
        console.error('Lỗi khi tải danh sách sản phẩm:', error);
      }
    },
    async handleSubmit() {
      try {
        if (this.editingProduct !== null) {
          // Cập nhật sản phẩm đã có
          await axios.put(`https://localhost:7074/api/Product/Update/${this.products[this.editingProduct].productID}`, this.localProduct);
          this.products[this.editingProduct] = { ...this.localProduct };
          this.editingProduct = null;
        } else {
          // Tạo sản phẩm mới
          await axios.post('https://localhost:7074/api/Product/Create', this.localProduct);
          this.fetchProducts(); // Tải lại danh sách sản phẩm đã cập nhật
        }
        this.clearForm();
      } catch (error) {
        console.error('Lỗi khi tạo/cập nhật sản phẩm:', error);
      }
    },
    async deleteProduct(productId) {
      try {
        await axios.delete(`https://localhost:7074/api/Product/Delete/${productId}`);
        this.products = this.products.filter(product => product.productID !== productId);
      } catch (error) {
        console.error('Lỗi khi xóa sản phẩm:', error);
      }
    },
    editProduct(product) {
      this.localProduct = { ...product };
      this.editingProduct = this.products.indexOf(product);
    },
    clearForm() {
      this.localProduct = {
        name: '',
        price: null,
        description: '',
        quantity: null
      };
      this.editingProduct = null;
    },
    formatCurrency(value) {
      // Hàm định dạng số tiền sang đơn vị tiền tệ VNĐ
      return new Intl.NumberFormat('vi-VN', { style: 'currency', currency: 'VND' }).format(value);
    }
  },
  mounted() {
    this.fetchProducts();
  }
};
</script>

<style scoped>
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
form input[type="number"] {
  width: 100%;
  padding: 10px;
  font-size: 16px;
  border: 1px solid #ccc;
  border-radius: 4px;
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
    margin-top: 0;
  }
}
</style>
