<template>
  <v-app-bar
          app
          color="purple"
          dark>
    <v-toolbar-title>Chat Room App</v-toolbar-title>
    <v-spacer></v-spacer>
    <v-btn class="button" color="error" @click="leaveChatRoom">Leave ChatRoom</v-btn>
    <span style="width: 20px"></span>
    <v-btn class="button" color="primary" @click="goToChatRoom">Enter the ChatRoom</v-btn>
    <span style="width: 20px"></span>
    <v-toolbar-title>{{testy}}</v-toolbar-title>
  </v-app-bar>
</template>

<script>
  export default {
    name: 'AppBar',
    data:() => {
      return{
        testy: ``,
        testRoutingu: 21,
      }
    },
    props:{
    },
    methods: {
      goToChatRoom(){
        this.testy = `Users connected: ${this.testRoutingu}`;
        this.$router.push('/ChatRoom');
      },
      leaveChatRoom(){
        this.testy = `Let's Chat!`;
        this.$router.push('/');
      }
    },
    created(){
      this.testy = "Let's Chat!"
    }
  }
</script>
<style lang="scss" scoped>

</style>
