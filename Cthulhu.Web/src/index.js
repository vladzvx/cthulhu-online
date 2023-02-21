import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import { createStore } from 'redux';
//const axios = require('axios');
import axios, * as others from 'axios';
import { Router, Route, BrowserRouter, Routes} from "react-router-dom";

//const store = createStore(reducer);
//axios.defaults.headers.post['Access-Control-Allow-Origin'] = '*';
//axios.defaults.headers.get['Access-Control-Allow-Origin'] = '*';
//export default store;

const url = 'localhost:5000';
  
async function getPerson() {
  try {
    const response = await axios.get('http://localhost:5000/Person/GetPerson',{});
    console.log(response.data);
  } catch (error) {
    console.error(error);
  }
}


function Square(props) {
  return (
    <button className="square" onClick={props.onClick}>
      {props.value}
    </button>
  );
}

function ResetButton(props) {
    return (
    <button onClick={props.onClick}>
        {props.value}
    </button>
    );
}

function TestButton(props) {
    return (
    <button onClick={()=>getPerson()}>
        {props.value}
    </button>
    );
}



class Board extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
          squares: Array(9).fill(null),
        };
      }

      handleClick(i) {
        const squares = this.state.squares.slice();
        squares[i] = 'X';
        this.setState({squares: squares});
      }
      
      renderSquare(i) {
        return (
          <Square
            value={this.state.squares[i]}
            onClick={() => this.handleClick(i)}
          />
        );
      }

      renderReset() {
        return (
          <ResetButton
            value="RESET"
            onClick = {()=> this.setState ({
                squares: Array(9).fill(null),
              })}
          />
        );
      }

      renderTest() {
        return (
          <TestButton
            value="TEST"
          />
        );
      }


    render() {
      const status = 'Next player: X';
  
      return (
        <div>
          <div className="status">{status}</div>
          <div className="board-row">
            {this.renderSquare(0)}
            {this.renderSquare(1)}
            {this.renderSquare(2)}
          </div>
          <div className="board-row">
            {this.renderSquare(3)}
            {this.renderSquare(4)}
            {this.renderSquare(5)}
          </div>
          <div className="board-row">
            {this.renderSquare(6)}
            {this.renderSquare(7)}
            {this.renderSquare(8)}
          </div>
          <div className="board-row">
            {this.renderReset()}
          </div>
          <div className="board-row">
            {this.renderTest()}
          </div>
        </div>
      );
    }
  }
  
  class Board2 extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
          squares: Array(9).fill(null),
        };
      }

      handleClick(i) {
        const squares = this.state.squares.slice();
        squares[i] = 'X';
        this.setState({squares: squares});
      }


      renderTest() {
        return (
          <TestButton
            value="TEST"
          />
        );
      }


    render() {
      const status = 'Next player: X';
  
      return (
        <div>
          <div className="board-row">
            {this.renderTest()}
          </div>
        </div>
      );
    }
  }

  class Game  extends React.Component{
    render() {
      return (
        <div className="game">
          <div className="game-board">
            <Board />
          </div>
          <div className="game-info">
          </div>
        </div>
      );
    }
  }

  class Game2  extends React.Component{
    render() {
      return (
        <div className="game2">
          <div className="game2-board">
            <Board2 />
          </div>
          <div className="game2-info">
          </div>
        </div>
      );
    }
  }

  export default function App() {
    return (
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<Game />}></Route>
          <Route path="/t" element={<Game2 />}></Route>
        </Routes>
      </BrowserRouter>
    );
  }

  // ========================================
  
  const root = ReactDOM.createRoot(document.getElementById("root"));
  root.render(<App />);
  