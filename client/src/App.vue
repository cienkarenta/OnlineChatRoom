<template>
  <v-app>
    <AppBar/>
    <v-content>
      <router-view></router-view>
    </v-content>
  </v-app>
</template>

<style lang="scss" scoped>
</style>
<script>
  import AppBar from "@/components/AppBar";
  export default {
    components: {
      AppBar
    }
  }
</script>