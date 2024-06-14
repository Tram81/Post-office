<template>
  <div>
    <h1>Danh sách sản phẩm</h1>
    <table class="table">
      <thead>
        <tr>
          <th scope="col">tên</th>
          <th scope="col">description</th>
          <th scope="col">price</th>
          <th scope="col">quantityStock</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="p in products" :key="p.productID">
          <td>{{ p.productName }}</td>
          <td>{{ p.description }}</td>
          <td>{{ p.price }}</td>
          <td>@{{ p.quantityStock }}</td>
        </tr>    
      </tbody>
    </table>
  </div>
</template>

<script>
import axios from 'axios';

export default {  
  name: "ProductListV",
  data() {
    return {
      products: []
    };
  },
  methods: {
    fetchProducts() {
    var url = process.env.VUE_APP_BASE_URL + `Product/GetAll`;
      axios.get(url)
        .then(response => {
          console.log (response);
         this.products = response.data;
        })
        .catch(error => {
          console.error('There was an error fetching the products!', error);
        });
    }
  },
  mounted(){
    this.fetchProducts()
  }
};
</script>