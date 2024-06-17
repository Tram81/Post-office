<template>
    <footer class="footer">
      <div class="container">
        <p>&copy; 2024 Dashboard App</p>
      </div>
    </footer>
</template>

<script>
export default {
    name: 'YourComponentName'
}
</script>

<style scoped>
  .container {
    width: 100%;
    max-width: 1200px;
    margin: 0 auto;
    padding: 20px;
    display: flex;
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