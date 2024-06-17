<template>
  <div class="container mt-4">
    <h2>Product Manager</h2>

    <!-- Form for creating or editing products -->
    <form @submit.prevent="handleSubmit">
      <div class="mb-3">
        <label for="name" class="form-label">Product Name</label>
        <input v-model="localProduct.name" type="text" class="form-control" id="name" required>
      </div>
      <div class="mb-3">
        <label for="price" class="form-label">Price</label>
        <input v-model="localProduct.price" type="number" class="form-control" id="price" required>
      </div>
      <div class="mb-3">
        <label for="description" class="form-label">Description</label>
        <input v-model="localProduct.description" type="text" class="form-control" id="description" required>
      </div>
      <div class="mb-3">
        <label for="quantity" class="form-label">Quantity</label>
        <input v-model="localProduct.quantity" type="number" class="form-control" id="quantity" required>
      </div>
      <button type="submit" class="btn btn-primary">{{ editingProduct !== null ? 'Update' : 'Create' }} Product</button>
    </form>

    <!-- Product list -->
    <table class="table mt-4">
      <thead>
        <tr>
          <th>Product Name</th>
          <th>Price</th>
          <th>Description</th>
          <th>Quantity</th>
          <th>Action</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="product in products" :key="product.id">
          <td>{{ product.name }}</td>
          <td>{{ product.price }}</td>
          <td>{{ product.description }}</td>
          <td>{{ product.quantity }}</td>
          <td>
            <button class="btn btn-sm btn-primary" @click="editProduct(product)">Edit</button>
            <button class="btn btn-sm btn-danger" @click="deleteProduct(product.id)">Delete</button>
          </td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
import axios from 'axios';
// import { ref, onMounted } from 'vue';

export default {
  name: 'ProductManager',
  data() {
    return {
      products: [],
      localProduct: {
        name: '',
        price: null,
        description: '',
        quantity: null
      },
      editingProduct: null
    };
  },
  mounted() {
    this.fetchProducts();
  },
  methods: {
    async fetchProducts() {
      try {
        const response = await axios.get('https://api.example.com/products');
        this.products = response.data;
      } catch (error) {
        console.error('Failed to fetch products:', error);
      }
    },
    async handleSubmit() {
      try {
        if (this.editingProduct !== null) {
          // Update existing product
          await axios.put(`https://api.example.com/products/${this.products[this.editingProduct].id}`, this.localProduct);
          this.products[this.editingProduct] = { ...this.localProduct };
          this.editingProduct = null;
        } else {
          // Create new product
          await axios.post('https://api.example.com/products', this.localProduct);
          this.fetchProducts(); // Fetch the updated product list
        }
        this.clearForm();
      } catch (error) {
        console.error('Failed to create/update product:', error);
      }
    },
    async deleteProduct(productId) {
      try {
        await axios.delete(`https://api.example.com/products/${productId}`);
        this.products = this.products.filter(product => product.id !== productId);
      } catch (error) {
        console.error('Failed to delete product:', error);
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
    }
  }
};
</script>

<style scoped>
/* Add your custom styles here if needed */

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
form input[type="number"] {
  width: 100%;
  padding: 10px;
  font-size: 16px;
  border: 1px solid #ccc;
  border-radius: 4px;
}

form .mb-3 {
  margin-bottom: 1.5rem;
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
  text-align: center;
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

</style>
