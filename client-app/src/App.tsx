import { useEffect, useState } from 'react'
import './App.css'
import axios from 'axios';

function App() {
  const [activities, setActivities] = useState([]);

  useEffect(()=>
  {
    axios.get('http://localhost:5203/api/Activity').
    then(response => {setActivities(response.data)})
  }, [])

  return (
    // <div>
    //   <h1>Reactivities</h1>
    //   {ducks.map(duck => 
    //     (
    //       <Duckitem key={duck.name} duck={duck}/>
    //     ))}
    // </div>

    //costaante para el Endpoint
    <div>
      <h1>Reactivities</h1>
      <ul>
       {activities.map((activy : any) => 
        (
          <li key={activy.id}>{activy.title}</li>
        ))}
      </ul>
    </div>
    )
}

export default App
