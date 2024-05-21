<template>
    <div class="home">
        <header>
            <Headers></Headers>
        </header>
        <!-- <img alt="Vue logo" src="../assets/logo.png"> -->
        <Abbout />
        <!--msg="Welcome to Your Vue.js App"-->
    </div>
</template>

<script>
// @ is an alias to /src
import Abbout from '@/components/AboutV.vue'
import Headers from '@/components/heder.vue';

export default {
    name: 'AboutV',
    components: {
        Abbout,
        Headers
    }
}
</script>