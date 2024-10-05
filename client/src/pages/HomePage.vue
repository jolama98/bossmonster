<script setup>
import { AppState } from '@/AppState.js';
import BossCard from '@/components/BossCard.vue';
import PlayerCard from '@/components/PlayerCard.vue';
import { heroesService } from '@/services/HeroesService.js';
import Pop from '@/utils/Pop.js';
import { computed, onMounted } from 'vue';
const heroes = computed(() => AppState.heroes)

onMounted(() => {
  getAllHeroes()
})

async function getAllHeroes() {
  try {
    await heroesService.getAllHeroes()
  }
  catch (error) {
    Pop.error(error);
  }
}
</script>

<template>
  <div class="container-fluid ">
    <div class="row">
      <h1 class="d-flex justify-content-center">Heros</h1>
    </div>
    <div class="row justify-content-center ">
      <div v-for="hero in heroes" :key="hero.id" class="col-md-3 col-6 align-content-center pb-4">
        <PlayerCard :hero-props="hero" />
      </div>
    </div>

    <div class="row">
      <div class="col-12">
        <div class="d-flex justify-content-center">
          <BossCard />
        </div>
      </div>
    </div>

  </div>
</template>

<style scoped lang="scss">
.boss-monster {
  height: 25dvh;
}
</style>
