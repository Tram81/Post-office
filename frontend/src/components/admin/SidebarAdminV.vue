<template>
    <main class="main-content">
      <div class="container">
        <aside class="sidebar">
          <h2>Sidebar</h2>
          <router-link to="/admin/CustomerManager" class="sidebar-link">Customer Manager</router-link>
          <router-link to="/admin/ProductListManager" class="sidebar-link">Products</router-link>
        </aside>
      </div>
    </main>
</template>

<script>
export default {
    name: 'SidebarAdmin',
    components: {

    },
}
</script>

<style scoped>

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

.content {
  flex: 1;
  padding: 20px;
}

.footer {
  background-color: #007bff;
  color: #fff;
  text-align: center;
  padding: 10px 0;
  width: 100%;
  margin-top: auto;
}

.footer p {
  margin: 0;
}
</style>