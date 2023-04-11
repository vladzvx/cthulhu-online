import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import { createStore } from 'redux';
//const axios = require('axios');
import axios, * as others from 'axios';
import { Router, Route, BrowserRouter, Routes} from "react-router-dom";
import { DataGrid, GridRowsProp, GridColDef, } from '@mui/x-data-grid';
import { Grid } from '@mui/material';
import { TextField } from '@mui/material';
import { useMediaQuery, MediaQuery  } from 'react-responsive'

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

  class TableView extends React.Component{
    render(){
      return (
        <div style={{ height: '100%', width: '100%' }}>
          <Grid container rowSpacing={1} columnSpacing={{ xs: 1, sm: 2, md: 3 }}>
            <Grid item xs={12}>
              {"Фамилия"}
            </Grid>
            <Grid item xs={12}>
            <TestButton
            value="TEST"
          />
            </Grid>
            <Grid item xs={3}>
            {<TextField  type="number"   defaultValue="55"/>}
            </Grid>
            <Grid item xs={9}>
            <PersonView/>
            </Grid>
          </Grid>
      </div>
      );
    }
  }

  class TableViewMobile extends React.Component{
    render(){
      return (
        <div style={{ height: '100%', width: '100%' }}>
          <Grid container rowSpacing={1} columnSpacing={{ xs: 1, sm: 2, md: 3 }}>
            <Grid item xs={12}>
              {"Фамилия"}
            </Grid>
            <Grid item xs={12}>
            <TestButton
            value="TEST"
          />
            </Grid>
            <Grid item xs={12}>
            {<TextField  type="number"   defaultValue="55"/>}
            </Grid>
            <Grid item xs={12}>
            <PersonView/>
            </Grid>
          </Grid>
      </div>
      );
    }
  }

  class PersonView extends React.Component{
    render() {
      return (
        <div style={{ height: 300, width: '100%' }}>
        <DataGrid rows={rows} columns={columns} hideFooterPagination = {true} options={options}  disableColumnMenu = {true}
          sx={{ border: 1 ,grid: 3 }}
    />
      </div>
      );
    }
  }

  const rows = [
    { id: 1, col1: "111", col2: 'World' },
    { id: 2, col1: 'DataGridPro', col2: 'is Awesome' },
    { id: 3, col1: 'MUI', col2: 'is Amazing' },
  ];

  const columns = [
    { field: 'col1', headerName: 'Column 1', width: 150,renderHeader:()=>null,  sortable: false,  renderCell:()=><TextField  type="number" defaultValue="0"/>},
    { field: 'col2', headerName: 'Column 2', width: 150 , renderHeader: () => null, sortable: false 
    },
  ];

  const options = {
    filter: false,
    responsive: "scroll",
    download: true,
    sort: false,
    selectableRows: false,
    print: false,
    
    viewColumns: true,
    searchOpen: false,
    search: false,
}; 

  export default function App() {




    //const isTabletOrMobile1 = useMediaQuery({ query: '(max-width: 1224px)' })
    return (
     <BrowserRouter>
      <Routes>
        <Route path="/" element={<TableViewMobile />}></Route>
        <Route path="/t3" element={<PersonView />}></Route>
        <Route path="/t" element={<Game2 />}></Route>
        <Route path="/t2" element={<Game />}></Route>
      </Routes>
    </BrowserRouter>

    );
  }

 
  // ========================================
  
  const root = ReactDOM.createRoot(document.getElementById("root"));
  root.render(App());
  