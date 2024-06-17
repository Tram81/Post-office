<!-- ProductList.vue -->
<template>
  <div>
    <h2>Product List</h2>
    <table>
      <thead>
        <tr>
          <th>Name</th>
          <th>Description</th>
          <th>Actions</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="product in products" :key="product.id">
          <td>{{ product.name }}</td>
          <td>{{ product.description }}</td>
          <td>
            <button @click="editProduct(product)">Edit</button>
            <button @click="deleteProduct(product.id)">Delete</button>
          </td>
        </tr>
      </tbody>
    </table>
    <div v-if="editMode">
      <h3>Edit Product</h3>
      <form @submit.prevent="updateProduct">
        <input type="text" v-model="editedProduct.name" placeholder="Name">
        <input type="text" v-model="editedProduct.description" placeholder="Description">
        <button type="submit">Save</button>
        <button @click="cancelEdit">Cancel</button>
      </form>
    </div>
  </div>
</template>

<script>
import axios from 'axios';

export default {
  data() {
    return {
      products: [],
      editMode: false,
      editedProduct: {
        id: null,
        name: '',
        description: ''
      }
    };
  },
  created() {
    this.fetchProducts();
  },
  methods: {
    fetchProducts() {
      // Replace with actual API endpoint
      axios.get('/api/products')
        .then(response => {
          this.products = response.data;
        })
        .catch(error => {
          console.error('Error fetching products', error);
        });
    },
    editProduct(product) {
      this.editMode = true;
      this.editedProduct.id = product.id;
      this.editedProduct.name = product.name;
      this.editedProduct.description = product.description;
    },
    updateProduct() {
      axios.put(`/api/products/${this.editedProduct.id}`, {
        name: this.editedProduct.name,
        description: this.editedProduct.description
      })
      .then(response => {
        console.log('Product updated successfully', response.data);
        this.fetchProducts();
        this.cancelEdit();
      })
      .catch(error => {
        console.error('Error updating product', error);
      });
    },
    cancelEdit() {
      this.editMode = false;
      this.editedProduct.id = null;
      this.editedProduct.name = '';
      this.editedProduct.description = '';
    },
    deleteProduct(productId) {
      axios.delete(`/api/products/${productId}`)
        .then(response => {
          console.log('Product deleted successfully', response.data);
          this.fetchProducts();
        })
        .catch(error => {
          console.error('Error deleting product', error);
        });
    }
  }
};
</script>

<style>
/* Add your styles here */
</style>
