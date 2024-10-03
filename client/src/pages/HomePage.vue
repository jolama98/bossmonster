<script setup>
import PlayerCard from '@/components/PlayerCard.vue';
</script>

<template>
  <div class="container-fluid ">
    <div class="row">
      <div class="col-12">
        <div class="pb-3">
          <PlayerCard />
        </div>
      </div>
    </div>

    <div class="row">
      <div class="col-12">
        <div class="d-flex justify-content-center">
          <img class="boss-monster img-fluid border border-4 border-dark rounded-5"
            src="https://www.investopedia.com/thmb/xXU54x-dkZf9WRNAYqZs6ECcCTg=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/single-word-taxes-on-wooden-block-1132754811-f3ef431cc47a4be3a49223b20774845f.jpg"
            alt="">
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
