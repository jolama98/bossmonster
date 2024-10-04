import { Heroes } from "@/models/Heroes.js"
import { api } from "./AxiosService.js"
import { AppState } from "@/AppState.js"
import { logger } from "@/utils/Logger.js"

class HeroesService {
  async getAllHeroes() {
    const response = await api.get('api/Heroes')
    const heroes = response.data.map(heroPOJO => new Heroes(heroPOJO))
    AppState.heroes = heroes
    logger.log(response.data)
  }
}


export const heroesService = new HeroesService()

