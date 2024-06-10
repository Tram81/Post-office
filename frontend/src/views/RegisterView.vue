<template>
    <div class="home">
        <header>
            <Headers></Headers>
        </header>
        <!-- <img alt="Vue logo" src="../assets/logo.png"> -->
        <Register />
        <!--msg="Welcome to Your Vue.js App"-->
    </div>
</template>

<script>
// @ is an alias to /src
import Register from '@/components/RegisterV.vue'
import Headers from '@/components/heder.vue';

export default {
    name: 'RegisterView',
    components: {
        Register,
        Headers
    }
}
</script>