<template>
  <div class="dashboard">
    <header class="header">
      <div class="container">
        <h1 class="logo">Dashboard</h1>
        <nav class="main-nav">
          <router-link to="/">Home</router-link>
          <router-link to="/dashboard">Dashboard</router-link>
          <router-link to="/settings">Settings</router-link>
          <router-link to="/logout">Logout</router-link>
        </nav>
      </div>
    </header>

    <main class="main-content">
      <div class="container">
        <section class="sidebar">
          <h2>Sidebar</h2>
          <router-link to="/admin/Dashboard">Dashboard</router-link>
          <router-link to="/admin/UserManager">User Manager</router-link> <!-- Thêm UserManager ngay sau Dashboard -->
          <router-link to="/admin/ProductListManager">Products</router-link>
        </section>

        <router-view class="content"></router-view>
      </div>
    </main>

    <footer class="footer">
      <div class="container">
        <p>&copy; 2024 Dashboard App</p>
      </div>
    </footer>
  </div>
</template>

<script>
// Đoạn script JavaScript (nếu có) sẽ điền vào đây nếu bạn cần
// export default {
//   name: 'Dashboard',
// };
</script>

<style scoped>
.dashboard {
  display: flex;
  flex-direction: column;
  min-height: 100vh;
}

.header {
  background-color: #007bff;
  color: #fff;
  padding: 10px 0;
}

.header .container {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 0 20px;
}

.main-nav ul {
  list-style-type: none;
  padding: 0;
  margin: 0;
}

.main-nav ul li {
  display: inline-block;
  margin-right: 20px;
}

.main-nav ul li a {
  color: #fff;
  text-decoration: none;
  font-weight: bold;
  font-size: 16px;
}

.main-nav ul li a:hover {
  text-decoration: underline;
}

.main-content {
  display: flex;
  flex: 1;
  background-color: #f7f7f7;
}

.container {
  width: 100%;
  max-width: 1200px;
  margin: 0 auto;
  padding: 20px;
  display: flex;
}

.sidebar {
  width: 25%;
  background-color: #ffffff;
  padding: 20px;
  border-right: 1px solid #ddd;
  display: flex;
  flex-direction: column;
  align-items: flex-start;
}

.sidebar h2 {
  margin-bottom: 10px; /* Khoảng cách giữa tiêu đề và các mục trong sidebar */
}

.sidebar router-link {
  text-decoration: none;
  color: #333; /* Màu chữ cho các router-link trong sidebar */
  margin-bottom: 10px; /* Khoảng cách giữa các mục trong sidebar */
}

.sidebar router-link:last-child {
  margin-bottom: 0; /* Không có margin bottom cho mục cuối cùng trong sidebar */
}

.sidebar router-link:nth-child(2) {
  order: 1; /* Đặt UserManager sau Dashboard */
}

.footer {
  background-color: #007bff;
  color: #fff;
  text-align: center;
  padding: 10px 0;
  position: absolute;
  bottom: 0;
  width: 100%;
}

.footer p {
  margin: 0;
}
</style>
