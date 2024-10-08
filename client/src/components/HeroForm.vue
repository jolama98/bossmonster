<script setup>
import { heroesService } from '@/services/HeroesService.js';
import Pop from '@/utils/Pop.js';
import { Modal } from 'bootstrap';
import { ref } from 'vue';



const heroData = ref({
  name: '',
  img: '',
  health: 0,
  damage: 0,
  type: ''
})

function resetForm() {
  heroData.value = {
    name: '',
    img: '',
    health: 0,
    damage: 0,
    type: ''
  }
}

async function createHero() {
  try {
    await heroesService.createHero(heroData.value)
    heroData.value = {
      name: '',
      img: '',
      health: 0,
      damage: 0,
      type: ''
    }
    // Modal.getOrCreateInstance('#createKeepModal').hide()
    Pop.success('Report submitted!')
  }
  catch (error) {
    Pop.error(error);
  }
}

</script>


<template>
  <div class="modal-body">
    <form @submit.prevent="createHero()">
      <div class="mb-3">
        <label for="heroName" class="form-label">Name</label>
        <input v-model="heroData.name" type="text" class="form-control" id="heroName" aria-describedby="">
      </div>
      <div class="mb-3">
        <label for="heroImg" class="form-label">image</label>
        <input v-model="heroData.img" type="url" class="form-control" id="heroImg" aria-describedby="">
      </div>
      <div class="mb-3">
        <label for="heroHealth" class="form-label">Health</label>
        <input v-model="heroData.health" type="number" class="form-control" id="heroHealth" aria-describedby="">
      </div>
      <div class="mb-3">
        <label for="heroDamage" class="form-label">Damage</label>
        <input v-model="heroData.damage" type="number" class="form-control" id="heroHealth" aria-describedby="">
      </div>
      <div class="mb-3">
        <label for="heroType" class="form-label">Class</label>
        <input v-model="heroData.type" type="text" class="form-control" id="heroType" aria-describedby="">
      </div>
      <div class="modal-footer">
        <button class="btn btn-primary">Add</button>
      </div>
    </form>
  </div>

</template>

<style lang="scss" scoped></style>
