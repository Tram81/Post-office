<template>
    <div class="home">
        <header>
            <Headers></Headers>
        </header>
        <!-- <img alt="Vue logo" src="../assets/logo.png"> -->
        <ShopPost />
        <!--msg="Welcome to Your Vue.js App"-->
    </div>
</template>

<script>
// @ is an alias to /src
import ShopPost from '@/components/ShopV.vue'
import Headers from '@/components/heder.vue';

export default {
    name: 'ShopV',
    components: {
        ShopPost ,
        Headers
    }
}
</script>