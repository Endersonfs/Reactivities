import './App.css'
import Duckitem from './Duckitem'
import { ducks } from './demos'

function App() {
  
  return (
    <div>
      <h1>Reactivities</h1>
      {ducks.map(duck => 
        (
          <Duckitem key={duck.name} duck={duck}/>
        ))}
    </div>
    )
}

export default App
