import React, { useEffect } from 'react'
import Paragraph from './Components/Paragraph/Paragraph'
import { useGetShipsQuery } from './Redux/api';
import store from './Redux/store';


function App() {
    const {data,isLoading} = useGetShipsQuery();
    
useEffect(()=>{
    if (isLoading) return;
    console.log(data);
}, [isLoading])

    return (
        <Paragraph text={isLoading ? 'loading' : 'heelooo ept'} />
    )
}
export default App;