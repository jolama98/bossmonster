<script setup>
import { Heroes } from '@/models/Heroes.js';
import { heroesService } from '@/services/HeroesService.js';
import Pop from '@/utils/Pop.js';
const props = defineProps({
  heroProps: { type: Heroes, required: true }
})

async function deleteHero() {
  try {
    const choice = await Pop.confirm("Are your sure?", 'delete Hero')
    if (choice == false) {
      Pop.toast("action canceled successfully", 'info', 'center')
      return
    }
    await heroesService.deleteHero(props.heroProps.id)
    Pop.success("Hero Deleted!")
  }
  catch (error) {
    Pop.error(error);
  }

}
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
    <button @click="deleteHero" class="btn btn-danger align-self-end m-1
    ">Delete</button>
  </div>
</template>


<style lang="scss" scoped>
p {
  padding: 0px;
  margin: 0px;
}


.img {
  min-height: 100%;
  width: 100%;
  object-fit: cover;
  // background-image: v-bind('heroProps.backgroundImage');
}
</style>
