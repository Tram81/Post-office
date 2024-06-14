<template>
    <div class="home">
        <header>
            <Headers></Headers>
        </header>
        <ProductList />
        <footer>
            <footers></footers>
        </footer>
    </div>
</template>

<script>
import ProductList from '@/components/ProductListV.vue';
import Headers from '@/components/header.vue';
import footers from '@/components/footer.vue'


export default {
    name: 'ProductListView',
    components: {
        ProductList,
        Headers,
        footers
    }
}
</script>