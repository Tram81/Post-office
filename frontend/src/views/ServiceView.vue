<template>
    <div class="home">
        <header>
            <Headers></Headers>
        </header>
        <!-- <img alt="Vue logo" src="../assets/logo.png"> -->
        <Servvice />
        <!--msg="Welcome to Your Vue.js App"-->
    </div>
</template>

<script>
// @ is an alias to /src
import Servvice from '@/components/ServiceV.vue'
import Headers from '@/components/heder.vue';

export default {
    name: 'ServiceV',
    components: {
        Servvice,
        Headers
    }
}
</script>