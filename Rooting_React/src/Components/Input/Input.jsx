import './Input.css';


function Input({inputMessage}) {
    const handleInput = event =>{
        inputMessage(event.target.value);
    }

  return (
    <input type='text' onInput={handleInput}>

    </input>
  );
}

export default Input;
