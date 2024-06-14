<template>
    <div class="home">
        <header>
            <Headers></Headers>
        </header>
        <Shop />
        <footer>
            <footers></footers>
        </footer>
    </div>
</template>

<script>
import Shop from '@/components/ShopV.vue';
import Headers from '@/components/header.vue';
import footers from '@/components/footer.vue';

export default {
    name: 'ShopView',
    components: {
        Shop,
        Headers,
        footers
    }
}
</script>