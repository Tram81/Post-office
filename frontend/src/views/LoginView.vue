<template>
    <div class="home">
        <header>
            <Headers></Headers>
        </header>
        <!-- <img alt="Vue logo" src="../assets/logo.png"> -->
        <Login />
        <!--msg="Welcome to Your Vue.js App"-->
    </div>
</template>

<script>
// @ is an alias to /src
import Login from '@/components/LoginV.vue'
import Headers from '@/components/heder.vue';

export default {
    name: 'LoginView',
    components: {
        Login,
        Headers
    }
}
</script>