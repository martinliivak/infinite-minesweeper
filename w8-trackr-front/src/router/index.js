import Vue from 'vue'
import Router from 'vue-router'
import HelloWorld from '@/components/HelloWorld'
import DataInsertion from '@/components/DataInsertion'
import Graph from '@/components/Graph'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'HelloWorld',
      component: HelloWorld
    },
    {
      path: '/graph',
      name: 'Graph',
      component: Graph
    },
    {
      path: '/',
      name: 'DataInsertion',
      component: DataInsertion
    }
  ]
})
