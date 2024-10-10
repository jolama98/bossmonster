<script setup>
import { AppState } from '@/AppState.js';
import BossCard from '@/components/BossCard.vue';
import HeroForm from '../components/HeroForm.vue';
import PlayerCard from '@/components/PlayerCard.vue';
import { heroesService } from '@/services/HeroesService.js';
import Pop from '@/utils/Pop.js';
import { computed, onMounted } from 'vue';
import ModalWrapper from '@/components/ModalWrapper.vue';
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
      <div v-for="hero in heroes" :key="hero.id" class="col-md-2 col-6 align-content-center pb-4">
        <PlayerCard :hero-props="hero" />
      </div>
    </div>

    <div class="row">
      <div class="col-12">
        <div class="d-flex justify-content-center">
          <BossCard />
        </div>
      </div>

      <ModalWrapper id="hero-form">
        <HeroForm />
      </ModalWrapper>


      <div class="d-flex justify-content-end sticky-bottom p-1">
        <!-- Button trigger modal -->
        <button type="button" class="btn btn-success" data-bs-target="#hero-form" data-bs-toggle="modal">
          Add Hero
        </button>
      </div>
    </div>

  </div>
</template>

<style scoped lang="scss">
.boss-monster {
  height: 25dvh;
}
</style>
