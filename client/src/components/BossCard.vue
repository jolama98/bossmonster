<script setup>
import { Boss } from '@/models/Boss.js';

defineProps({
  bossProps: { type: Boss, required: true }
})

</script>


<template>
  <div v-if="bossProps">
    <div class="row">

      <p>{{ bossProps.name }}</p>
      <div class="col-3">
        <img class="img-fluid" :src="bossProps.img" alt="">
      </div>
      <div class="col-7">
        <p>{{ bossProps.health }}</p>
      </div>
    </div>
  </div>
</template>


<style lang="scss" scoped></style>
