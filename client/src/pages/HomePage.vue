<script setup>
import BossCard from '@/components/BossCard.vue';
import PlayerCard from '@/components/PlayerCard.vue';

</script>

<template>
  <div class="container-fluid ">
    <div class="row">
      <h1 class="d-flex justify-content-center">Heros</h1>
      <div class="col-12">
        <div class="pb-3 d-flex justify-content-around">
          <PlayerCard />
        </div>
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
