<template>
    <div class="home">
        <ProductListManage />
    </div>
</template>

<script>
import ProductListManage from '@/components/admin/ProductListManagerV.vue'

export default {
    name: 'ProductListManageView',
    components: {
        ProductListManage,
    }
}
</script>