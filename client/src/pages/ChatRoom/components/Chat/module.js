// import hub from './hub'
// import DataDto from './dataDto'
//
// const state = {
//     dataList: [],
// };
//
// const getters  = {
//     dataList: state => state.dataList
// };
//
// const actions = {
//     startListenChatRoom({commit})
//     {
//         hub.listenChatRoom((message) => {
//            commit('setDataList', message.costam)
//         });
//     }
// };
//
// const mutations = {
//     setDataList(state, dataList) {
//         state.dataList = dataList.map(item => new DataDto(item));
//     }
// };
//
// const module = {
//     namespaced: true,
//     state,
//     getters,
//     actions,
//     mutations,
// };
//
// export default module;