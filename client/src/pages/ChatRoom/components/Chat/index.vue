<template>
  <div class="wrapper">
    <div>
      <b-table
        :items="dataList"
        :fields="fields"
        responsive
        borderless
        sticky-header="70vh"
        class="table"
        head-variant="light"
      >
        <template v-slot:cell(msgData)="data">
          <v-row>
            <span>{{data.value.userName}} :</span>
          </v-row>
          <v-row>
            <span class="sub">{{data.value.messageDate}}</span>
          </v-row>
        </template>
        <template>
          <span style="width: 70px"></span>
        </template>
        <template v-slot:cell(content)="data">
          {{data.value}}
        </template>
      </b-table>
    </div>
  </div>
</template>

<script>
  import { mapGetters } from "vuex";

  export default {
        name: "Chat",
        data: () => {
            return {
                fields: [
                    {key: 'msgData', label: ''},
                    {key: 'divider', label: ''},
                    {key: 'content', label: ''}
                ],
            }
        },
        computed: {
            ...mapGetters(['dataList'])
        },
        created() {
            setInterval(() => {
                console.log(this.dataList);
            }, 5000)
        }
  }
</script>

<style scoped>
  .wrapper {
    width: 23vw;
    min-width: 310px;
    height: 95vh;
    display: flex;
    align-items: center;
    justify-content: center;
    margin: 0 auto 0 auto;
  }
  .table {
    min-width: 300px;
    width: 23vw;
    background-color: ghostwhite;

  }
  .sub {
    color: grey;
    font-size: small;
  }
</style>