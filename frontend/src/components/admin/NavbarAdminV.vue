<template>
    <header class="header">
      <div class="container">
        <h1 class="logo">Dashboard</h1>
        <nav class="main-nav">
          <router-link to="/" class="nav-link">Home</router-link>
          <router-link to="/admin/LoginAdmin" class="nav-link">Logout</router-link>
        </nav>
      </div>
    </header>
</template>

<script>
export default {
    name: 'NavbarAdmin',
    components: {

    },
}
</script>

<style scoped>

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

.main-nav {
  display: flex;
}

.nav-link {
  color: #fff;
  text-decoration: none;
  font-weight: bold;
  font-size: 16px;
  padding: 10px;
  transition: background-color 0.3s ease;
}

.nav-link:hover {
  background-color: rgba(255, 255, 255, 0.1);
}

.nav-link.router-link-exact-active {
  background-color: rgba(255, 255, 255, 0.2);
}

.container {
  width: 100%;
  max-width: 1200px;
  margin: 0 auto;
  padding: 20px;
  display: flex;
}
</style>