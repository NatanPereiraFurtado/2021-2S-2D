
import React from 'react';
import './App.css';


function DataFormatada(props) {
  return <h2>Horario Atual: {props.date.toLocaleTimeString()}</h2>
}

class Clock extends React.Component{
  constructor(props){
    super(props);
    this.state = {
      date :  new Date()
    };
  }

  thick(){
    this.setState({
      date : new Date()
    })
  }

  componentDidMount(){
   this.TimeId = setInterval( () => {this.thick()}, 1000)
  }

  componentWillUnmount(){
    clearInterval(this.TimeId)
  }

  Pause(){
    clearInterval(this.TimeId)
    clearInterval(this.TimeId2)
    console.log('Relogio '+ this.TimeId+' pausado')
  }

  Resume(){
    this.TimeId2 = setInterval( () => {this.thick()}, 1000)
    console.log('Relogio retomado!')
    console.log('Agoro eu sou o relogio '+ this.TimeId2)
  }

  render(){
    return(
      <div>
         <h1>Relogio</h1>
         <DataFormatada date={this.state.date} />
         <button className="Pause-btn" onClick={() => this.Pause()} >Pause</button>
         <button className="Resume-btn" onClick={() => this.Resume()}>Continuar</button>
      </div>
    )
  }

} 


function App() {
  return (
    <div className="App">
      <header className="App-header">
       
       <Clock />
       <Clock />
       
      </header>
    </div>
  );
}

export default App;
