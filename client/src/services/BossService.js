import { logger } from "@/utils/Logger.js"
import { api } from "./AxiosService.js"

class BossService {
  async getAllBosses() {
    const response = await api.get('api/Boss')
    logger.log(response.data)
  }
}
export const bossService = new BossService()
