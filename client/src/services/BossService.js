import { logger } from "@/utils/Logger.js"
import { api } from "./AxiosService.js"
import { Boss } from "@/models/Boss.js"
import { AppState } from "@/AppState.js"

class BossService {
  async getAllBosses() {
    const response = await api.get('api/Boss')
    const bosses = response.data.map(bossPOJO => new Boss(bossPOJO))
    AppState.boss = bosses
    logger.log(response.data)
  }
}
export const bossService = new BossService()
