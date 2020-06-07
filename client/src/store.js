import Vue from 'vue';
import Vuex from 'vuex';

import hub from "@/pages/ChatRoom/components/Chat/hub";
import { DataDto } from "@/pages/ChatRoom/components/Chat/dataDto";

Vue.use(Vuex);

export const store =  new Vuex.Store({
    state: {
        dataList: ["a", "b"],
    },
    getters: {
        dataList: state => state.dataList
    },
    actions: {
        startListenChatRoom({commit})
        {
            hub.listenChatRoom((message) => {
                commit('setDataList', message)
            });
        }
    },
    mutations: {
        setDataList(state, dataList) {
            console.log(dataList.result);
            state.dataList = dataList.result.map(item => new DataDto(item));
        }
    },
});
