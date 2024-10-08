import { Heroes } from "@/models/Heroes.js"
import { api } from "./AxiosService.js"
import { AppState } from "@/AppState.js"
import { logger } from "@/utils/Logger.js"

class HeroesService {
  async createHero(heroData) {
    const response = await api.post('api/Heroes', heroData)
    const newHero = new Heroes(response.data)
    AppState.heroes.push(newHero)
    logger.log(newHero)

  }
  async deleteHero(heroId) {
    const response = await api.delete(`api/Heroes/${heroId}`)
    const deletedHero = AppState.heroes.findIndex(HeroDeleted => HeroDeleted.id == heroId)
    AppState.heroes.splice(deletedHero, 1)
    logger.log(response.data)
  }
  async getAllHeroes() {
    const response = await api.get('api/Heroes')
    const heroes = response.data.map(heroPOJO => new Heroes(heroPOJO))
    AppState.heroes = heroes
    logger.log(response.data)
  }
}


export const heroesService = new HeroesService()

