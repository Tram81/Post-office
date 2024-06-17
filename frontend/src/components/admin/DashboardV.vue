<template>

  <div class="dashboard">


    <NavbarAdmin />


    <SidebarAdmin />


    <FooterAdmin />
  </div>
</template>

<script>
import SidebarAdmin from './SidebarAdminV.vue';
import NavbarAdmin from './NavbarAdminV.vue';
import FooterAdmin from './FooterAdminV.vue';

export default {
    name: 'DashboardV',
    components: {
      SidebarAdmin,
      NavbarAdmin,
      FooterAdmin
    }
}
</script>

<style scoped>
  .dashboard {
  display: flex;
  flex-direction: column;
  min-height: 100vh;
  }
</style>


