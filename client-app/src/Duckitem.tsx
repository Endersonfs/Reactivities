import { Duck } from './demos'

interface Props 
{
    duck : Duck
}

export default function Duckitem(props : Props) {
  return (
    <div>        
        <div key={props.duck.name}>
            <span>{props.duck.name}</span>
            <button onClick={() => props.duck.makeSong(props.duck.name + "")}>makeSong</button>
        </div>       
    </div>
  )
}
