<template>
    <div class="home">
        <header>
            <Headers></Headers>
        </header>
        <HommePage />
        <footer>
            <footers></footers>
        </footer>
    </div>
</template>

<script>
import HommePage from '@/components/HomePage.vue';
import Headers from '@/components/header.vue';
import footers from '@/components/footer.vue';

export default {
    name: 'HomePageView',
    components: {
        HommePage,
        Headers,
        footers,
    }
}
</script>