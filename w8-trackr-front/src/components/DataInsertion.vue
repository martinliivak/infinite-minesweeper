<template>
  <div>
    just stuff here
  </div>
</template>

<script>
import WeightInsertion from '@/api-services/weight-insertion.js'

export default {
  name: 'DataInsertion',

  mounted () {
    WeightInsertion.insertWeights()
      .then((response) => {
        console.log('wack')
      }).catch((error) => {
        console.log('The data hasn\'t been loaded', error)
      })
  }
}
</script>
