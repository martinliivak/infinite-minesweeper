import Axios from 'axios'

const RESOURCE_NAME = '/api/weight'

export default {
  insertWeights () {
    return Axios.post(RESOURCE_NAME, 'stuff')
  }
}
