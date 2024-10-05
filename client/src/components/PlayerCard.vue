<script setup>
import { Heroes } from '@/models/Heroes.js';
const props = defineProps({
  heroProps: { type: Heroes, required: true }
})
</script>


<template>
  <div v-if="heroProps" class="card">
    <img :src="heroProps.img" class="card-img-top" alt="Aragorn">
    <div class="card-body">
      <h4 class="card-title fw-bold">{{ heroProps.name }}</h4>
      <p class="card-text fw-bold">Health: <span class="fw-medium">{{ heroProps.health }}</span></p>
      <p class="card-text fw-bold">Damage: <span class="fw-medium">{{ heroProps.damage }}</span></p>
      <p class="card-text fw-bold ">Class: <span class="fw-medium">{{ heroProps.type }}</span></p>
    </div>
  </div>
</template>


<style lang="scss" scoped>
p {
  padding: 0px;
  margin: 0px;
}
img{
  // object-fit: fill;
  object-fit: contain;

}
</style>
