<template>
    <div class="home">
        <crud />
    </div>
</template>

<script>
import crud from '@/components/CRUD.vue'

export default {
    name: 'CRUDView',
    components: {
        crud,
        Headers
    }
}
</script>