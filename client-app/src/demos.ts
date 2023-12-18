export interface Duck 
{
    name : string,
    numLegs : number,
    makeSong : (sound : string) => void 
}

const duck1 : Duck = 
{
    name : 'Huey',
    numLegs : 2,
    makeSong : (sound : string) => console.log(sound)
}
const duck2 : Duck = 
{
    name : 'Duey',
    numLegs : 2,
    makeSong : (sound : string) => console.log(sound)
}

const duck3 : Duck = 
{
    name : 'pato',
    numLegs : 4,
    makeSong : function (sound : string ) 
    {
        //este codigo es lo mismo
        console.log(sound)
    }
}

duck1.makeSong('Hola');
duck2.makeSong('Hola 2');

export const ducks = [duck1, duck2, duck3];