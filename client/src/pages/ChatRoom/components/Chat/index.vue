<template>
  <div>
    <b-table :items="items">

    </b-table>
  </div>
</template>

<script>
  import { MESSAGES } from "./constants"
    export default {
        name: "Chat",
        data: () => {
            return {
                items: MESSAGES,
            }
        },
    }
</script>

<style scoped>

</style>