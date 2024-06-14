<template>
    <div class="home">
        <header>
            <Headers></Headers>
        </header>
        <commpany />
        <footer>
            <footers></footers>
        </footer>
    </div>
</template>

<script>
import commpany from '@/components/CompanyV.vue';
import Headers from '@/components/header.vue';
import footers from '@/components/footer.vue';

export default {
    name: 'CompanyView',
    components: {
        commpany,
        Headers,
        footers
    }
}
</script>