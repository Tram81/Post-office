<template>
    <div class="home">
        <!-- <header>
            <Headers></Headers>
        </header> -->
        <Login />
        <!-- <footer>
            <footers></footers>
        </footer> -->
    </div>
</template>

<script>
import Login from '@/components/LoginV.vue';
// import Headers from '@/components/header.vue';
// import footers from '@/components/footer.vue';

export default {
    name: 'LoginView',
    components: {
        Login,
        // Headers,
        // footers
    }
}
</script>