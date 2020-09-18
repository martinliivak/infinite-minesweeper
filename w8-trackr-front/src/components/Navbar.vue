<template>
  <b-nav tabs>
    <b-nav-item :to="{ name: 'DataInsertion' }"><a class="nav-link active" data-toggle="tab"><b-icon-people></b-icon-people>Data insertion</a></b-nav-item>
    <b-nav-item :to="{ name: 'Graph' }"><a class="nav-link active" data-toggle="tab"><b-icon-graph-up></b-icon-graph-up>Graphs and stuff</a></b-nav-item>
  </b-nav>
</template>

<script>
export default {
  name: 'Navbar'
}
</script>
