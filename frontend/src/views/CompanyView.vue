<template>
    <div class="home">
        <header>
            <Headers></Headers>
        </header>
        <!-- <img alt="Vue logo" src="../assets/logo.png"> -->
        <commpany />
        <!--msg="Welcome to Your Vue.js App"-->
    </div>
</template>

<script>
// @ is an alias to /src
import commpany from '@/components/CompanyV.vue'
import Headers from '@/components/heder.vue';

export default {
    name: 'CompanyV',
    components: {
        commpany,
        Headers
    }
}
</script>