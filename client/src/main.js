import '@babel/polyfill'
import 'mutationobserver-shim'
import Vue from 'vue'
import './plugins/bootstrap-vue'
import './plugins/bootstrap-vue'
import './plugins/bootstrap-vue'
import App from './App.vue'
import vuetify from './plugins/vuetify';
import VueRouter from 'vue-router'
import { routes } from './routes'
import { store } from './store';

Vue.config.productionTip = false;

Vue.use(VueRouter);

const router = new VueRouter({routes});
new Vue({
  vuetify,
  router,
  store,
  render: h => h(App)
}).$mount('#app')
