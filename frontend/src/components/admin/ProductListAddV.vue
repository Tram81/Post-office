<template>
    <div>
      <h2>Add Product</h2>
      <form @submit.prevent="submitForm">
        <input v-model="name" placeholder="Name" required />
        <input v-model="price" placeholder="Price" type="number" required />
        <input v-model="description" placeholder="Description" required />
        <button type="submit">Submit</button>
      </form>
    </div>
  </template>
  
  <script>
  export default {
    data() {
      return {
        name: '',
        price: 0,
        description: '',
      };
    },
    methods: {
      submitForm() {
        const product = { name: this.name, price: this.price, description: this.description };
        this.$emit('addProduct', product);
      },
    },
  };
  </script>
  