import React, { useEffect, useState } from 'react';
import { GetAllWomen } from './api.js';

function App() {

const [women,setwomen]=useState([]);

useEffect(()=>{

    GetAllWomen().then(x=>{ console.log("data:",x.data);
       setwomen(x) 
    });
    

},[])

    return (
        <div>
            <h1>womens</h1>
            {
                !women||women.length==0?<p>טוען...</p>:
            
            <ul>
                { women.map(p=><li>{p.id}---{p.name}---{p.age}---{p.cors}</li>)}
            </ul>
            }
        </div>
 
    );
}

export default App;