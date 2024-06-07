<template>
    <div class="home">
        <header>
            <Headers></Headers>
        </header>
        <!-- <img alt="Vue logo" src="../assets/logo.png"> -->
        <Conttact />
        <!--msg="Welcome to Your Vue.js App"-->
    </div>
</template>

<script>
// @ is an alias to /src
import Conttact from '@/components/ContactV.vue'
import Headers from '@/components/heder.vue';

export default {
    name: 'ContactV',
    components: {
        Conttact,
        Headers
    }
}
</script>