import { reactive } from 'vue'
import { Heroes } from './models/Heroes.js'
import { Boss } from './models/Boss.js'


// NOTE AppState is a reactive object to contain app level data
export const AppState = reactive({
  /**@type {import('@bcwdev/auth0provider-client').Identity} */
  identity: null,
  /** @type {import('./models/Account.js').Account} user info from the database*/
  account: null,
  /** @type {Heroes[]} */
  heroes: [],
  /** @type {Boss[]} */
  boss: []
})

