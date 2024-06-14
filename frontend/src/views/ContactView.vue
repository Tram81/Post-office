<template>
    <div class="home">
        <header>
            <Headers></Headers>
        </header>
        <Contact />
        <footer>
            <footers></footers>
        </footer>
    </div>
</template>

<script>
import Contact from '@/components/ContactV.vue';
import Headers from '@/components/header.vue';
import footers from '@/components/footer.vue';

export default {
    name: 'ContactView',
    components: {
        Contact,
        Headers,
        footers
    }
}
</script>