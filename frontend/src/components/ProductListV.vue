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
          this.products = response.data;
        })
        .catch(error => {
          console.error('Có lỗi khi tải danh sách sản phẩm!', error);
        });
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
/* Định dạng cho phần tiêu đề h1 */
h1 {
  font-size: 50px;
  margin-bottom: 20px;
}

/* Định dạng cho bảng */
.table {
  width: 100%;
  border-collapse: collapse;
  border-spacing: 0;
  background-color: #fff;
  border: 1px solid #ddd;
}

/* Định dạng cho tiêu đề cột */
th {
  text-align: left;
  padding: 12px;
  background-color: #f2f2f2;
  border-bottom: 1px solid #ddd;
}

/* Định dạng cho nội dung trong ô */
td {
  padding: 12px;
  border-bottom: 1px solid #ddd;
}

/* Định dạng cho dòng chẵn (background màu nhạt) */
tbody tr:nth-child(even) {
  background-color: #f9f9f9;
}

/* Định dạng khi rê chuột vào dòng */
tbody tr:hover {
  background-color: #f2f2f2;
}
</style>
