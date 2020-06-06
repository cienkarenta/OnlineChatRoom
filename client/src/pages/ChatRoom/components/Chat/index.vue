<template>
  <div class="wrapper">
    <div>
      <b-table
        :items="items"
        :fields="fields"
        responsive
        borderless
      >
        <template v-slot:cell(Msgdata)="data">
          <v-row>
            <span>{{data.value.user}} :</span>
          </v-row>
          <v-row>
            <span class="sub">{{data.value.date}}</span>
          </v-row>
        </template>
        <template>
          <span style="width: 30px"></span>
        </template>
        <template v-slot:cell(content)="data">
          {{data.value}}
        </template>
      </b-table>
    </div>
  </div>
</template>

<script>
  import { msgs } from "./constants"

  export default {
        name: "Chat",
        data: () => {
            return {
                items: msgs,
                fields: [
                    {key: 'Msgdata', label: ''},
                    {key: 'divider', label: ''},
                    {key: 'content', label: ''}
                ],
            }
        },

    }
</script>

<style scoped>
  .wrapper{
    width: 60vw;
    display: flex;
    align-items: center;
    justify-content: center;
    margin: 20px auto 0 auto;
  }
  .sub {
    color: grey;
    font-size: small;
  }
</style>