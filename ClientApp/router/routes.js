import CounterExample from 'components/counter-example'
import FetchData from 'components/fetch-data'
import HomePage from 'components/home-page'
import Admin from 'components/admin'

export const routes = [
  { name: 'home', path: '/', component: HomePage, display: 'Connexion', icon: 'home' },
  { name: 'counter', path: '/counter', component: CounterExample, display: 'Salles', icon: 'list' },
  { name: 'fetch-data', path: '/fetch-data', component: FetchData, display: 'Réservation', icon: 'check-circle' },
  { name: 'admin', path: '/admin', component: Admin , display: 'admin', icon: 'user-tie' },
  
  
]
