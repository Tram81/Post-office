<template>
    <div class="home">
        <header>
            <Headers></Headers>
        </header>
        <Service />
        <footer>
            <footers></footers>
        </footer>
    </div>
</template>

<script>
import Service from '@/components/ServiceV.vue';
import Headers from '@/components/header.vue';
import footers from '@/components/footer.vue';

export default {
    name: 'ServiceView',
    components: {
        Service,
        Headers,
        footers
    }
}
</script>