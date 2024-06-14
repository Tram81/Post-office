<template>
    <div v-if="product">
      <h2>Edit Product</h2>
      <form @submit.prevent="submitForm">
        <input v-model="product.name" placeholder="Name" required />
        <input v-model="product.price" placeholder="Price" type="number" required />
        <input v-model="product.description" placeholder="Description" required />
        <button type="submit">Submit</button>
      </form>
    </div>
  </template>
  
  <script>
  import { mapActions, mapState } from 'vuex';
  
  export default {
    data() {
      return {
        product: null,
      };
    },
    computed: {
      ...mapState(['products']),
    },
    methods: {
      ...mapActions(['fetchProducts', 'updateProduct']),
      async submitForm() {
        await this.updateProduct(this.product);
        this.$router.push('/');
      },
      findProduct() {
        const id = this.$route.params.id;
        this.product = this.products.find(p => p.id === parseInt(id));
      },
    },
    created() {
      if (!this.products.length) {
        this.fetchProducts().then(() => {
          this.findProduct();
        });
      } else {
        this.findProduct();
      }
    },
  };
  </script>
  