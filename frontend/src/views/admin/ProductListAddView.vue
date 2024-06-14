<template>
    <div class="home">
        <ProductList />
    </div>
</template>

<script>
import ProductList from '@/components/admin/ProductListAddV.vue'

export default {
    name: 'ProductListAddView',
    components: {
        ProductList,
    }
}
</script>