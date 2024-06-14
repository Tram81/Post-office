<template>
    <!-- SIDEBAR -->
    <section id="sidebar">
        <a href="#" class="brand" style="justify-content: center;">
            <!-- <i class='bx bxs-smile'></i> -->
            <i class="bx icon fa fa-laptop"></i>
            <span class="text">AdminHub</span>
        </a>
        <ul class="side-menu top">
            <li class="active">
                <a href="#">
                    <i class='bx icon fa fa-dashboard'></i>
                    <router-link  class="text" to="/admin">Dashboard</router-link>                    
                </a>
            </li>
            <li>
                <a href="#">
                    <i class='bx icon fa fa-dashboard'></i>
                    <router-link  class="text" to="/admin/productmanage">Product Manage</router-link>
                </a>
            </li>
            <li>
                <a href="#">
                    <i class='bx icon fa fa-dashboard'></i>
                    <router-link  class="text" to="/admin/categorymanage">Category Manage</router-link>                    
                </a>
            </li>
            <li>
                <a href="#">
                    <i class='bx icon fa fa-dashboard'></i>
                    <router-link class="text" to="/admin/customermanage">Customer Manage</router-link>
                </a>
            </li>
            <li>
                <a href="#">
                    <i class='bx icon fa fa-dashboard'></i>
                    <router-link to="/admin/ordermanage" class="text">Order Manage</router-link>
                </a>
            </li>
        </ul>
        <ul class="side-menu">
            <li>
                <a href="#">
                    <i class='bx fa fa-gear'></i>
                    <span class="text">Settings</span>
                </a>
            </li>
            <li>
                <a class="logout" @click="logout">
                    <i class='bx fa fa-sign-out'></i>
                    <span class="text">Logout</span>
                </a>
            </li>
        </ul>
    </section>
    <!-- SIDEBAR -->
</template>

<script>

export default {
    name: 'SidebarAdmin',
    components: {

    },
    methods: {
        logout() {
            localStorage.removeItem('adminToken');
            this.$router.push('/admin/login');
        }
    }
}
</script>
<style scoped>
@import '@/assets/style.css';
</style>