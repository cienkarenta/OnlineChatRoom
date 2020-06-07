<template>
    <div>
        <Chat/>
    </div>
</template>

<script>
    import { mapActions } from 'vuex';
    import Chat from "./components/Chat"
    export default {
        name: "ChatRoom",
        components: {
            Chat,
        },
        data: () => {
            return {}
        },
        methods: {
            ...mapActions(['startListenChatRoom'])
        },
        created() {
            this.startListenChatRoom();
        }
    }
</script>

<style scoped>

</style>