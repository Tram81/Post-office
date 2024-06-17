<template>
    <div class="home">
        <CustomerManager />
    </div>
</template>

<script>
import CustomerManager from '@/components/admin/CustomerManagerV.vue'

export default {
    name: 'CustomerManagerView',
    components: {
        CustomerManager,
    }
}
</script>