<template>
    <div>
      <h2>Product List</h2>
      <ul>
        <li v-for="product in products" :key="product.id">
          {{ product.name }} - {{ product.price }} - {{ product.description }}
          <button @click="editProduct(product)">Edit</button>
          <button @click="deleteProduct(product.id)">Delete</button>
        </li>
      </ul>
      <ProductForm @addProduct="addProduct" />
    </div>
  </template>
  
  <script>
  // import { mapActions, mapGetters } from 'vuex';
  // import ProductListV from './ProductListV.vue';
  
  // export default {
  //   components: {
  //     ProductListV,
  //   },
  //   computed: {
  //     ...mapGetters(['products']),
  //   },
  //   methods: {
  //     ...mapActions(['fetchProducts', 'deleteProduct']),
  //     addProduct(product) {
  //       this.$store.dispatch('addProduct', product);
  //     },
  //     editProduct(product) {
  //       this.$router.push({ name: 'EditProduct', params: { id: product.id } });
  //     },
  //   },
  //   created() {
  //     this.fetchProducts();
  //   },
  // };
  </script>
  