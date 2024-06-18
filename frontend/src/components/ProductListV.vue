<template>
  <div>
    <h1>Danh sách sản phẩm</h1>
    <table class="table">
      <thead>
        <tr>
          <th scope="col">Tên sản phẩm</th>
          <th scope="col">Mô tả</th>
          <th scope="col">Giá (VNĐ)</th>
          <th scope="col">Số lượng tồn kho</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="p in products" :key="p.productID">
          <td>{{ p.productName }}</td>
          <td>{{ p.description }}</td>
          <td>{{ formatCurrency(p.price) }}</td>
          <td>{{ p.quantityStock }}</td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
import axios from 'axios';

export default {
  name: "ProductListView",
  data() {
    return {
      products: []
    };
  },
  methods: {
    async fetchProducts() {
      try {
        const url = process.env.VUE_APP_BASE_URL + 'Product/GetAll';
        const response = await axios.get(url);
        this.products = response.data;
      } catch (error) {
        console.error('Có lỗi khi tải danh sách sản phẩm!', error);
      }
    },
    formatCurrency(value) {
      return new Intl.NumberFormat('vi-VN', { style: 'currency', currency: 'VND' }).format(value);
    }
  },
  mounted() {
    this.fetchProducts();
  }
};
</script>

<style scoped>
h1 {
  font-size: 24px;
  margin-bottom: 20px;
}

.table {
  width: 100%;
  border-collapse: collapse;
  border-spacing: 0;
  background-color: #fff;
  border: 1px solid #ddd;
}

th {
  text-align: left;
  padding: 12px;
  background-color: #f2f2f2;
  border-bottom: 1px solid #ddd;
}

td {
  padding: 12px;
  border-bottom: 1px solid #ddd;
}

tbody tr:nth-child(even) {
  background-color: #f9f9f9;
}

tbody tr:hover {
  background-color: #f2f2f2;
}
</style>
