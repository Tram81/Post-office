<template>
    <div class="home">
        <LoginAdmin />
    </div>
</template>

<script>
import LoginAdmin from '@/components/admin/LoginAdminV.vue'

export default {
    name: 'LoginAdminView',
    components: {
        LoginAdmin,
    }
}
</script>