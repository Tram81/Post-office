<template>
    <div class="home">
        <header>
            <Headers></Headers>
        </header>
        <About />
        <footer>
            <footers></footers>
        </footer>
    </div>
</template>

<script>
import About from '@/components/AboutV.vue';
import Headers from '@/components/header.vue';
import footers from '@/components/footer.vue';

export default {
    name: 'AboutView',
    components: {
        About,
        Headers,
        footers
    }
}
</script>