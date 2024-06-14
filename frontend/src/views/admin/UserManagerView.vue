<template>
    <div class="home">
        <UserManager />
    </div>
</template>

<script>
import UserManager from '@/components/admin/UserManagerV.vue'

export default {
    name: 'UserManagerView',
    components: {
        UserManager,
    }
}
</script>