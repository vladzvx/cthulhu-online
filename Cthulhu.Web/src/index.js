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

const TEST = 1;

const store = createStore(reducer);

function reducer(state, action) {
  switch(action.type) {

      case TEST: return { orders: action.value }

      default: return state;
  }
}

function testStore(){
  store.dispatch({ type: TEST, value: [
    {
      name : "1",
    },
    {
      name : "2",
    }
  ] });
}

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

function SetStateButton(props) {
  return (
  <button onClick={()=>testStore()}>
      {props.value}
  </button>
  );
}

function GetStateButton(props) {
  return (
  <button onClick={()=>
  {
    console.log(store.getState());
  }}>
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

  function TableView (props){
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
            <SetStateButton
            value="SET"
          />
            </Grid>
            <Grid item xs={12}>
            <GetStateButton
            value="GET"
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
  

  function TableViewMobile(props){
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
            {<TextField  type="number"  defaultValue="55" />}
            </Grid>
            <Grid item xs={12}>
            <PersonView/>
            </Grid>
          </Grid>
      </div>
      );
    
  }

  class PersonView extends React.Component{
    render() {
      return (
        <div style={{  width: '100%' }}>
        <DataGrid rows={rows} autoHeight={true} columns={columns} hideFooterPagination = {true} options={options}  disableColumnMenu = {true} disableSelectionOnClick  = {true}
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
    { id: 4, col1: '1244', col2: 'is Amazing', col3:"col3" },
    { id: 2, col1: 'DataGridPro2', col4: 'is Awesome' },
  ];

  const columns = [
    { field: 'col1', headerName: 'Column 1',  flex: 2, renderHeader:()=>null,  sortable: false,  renderCell:()=><TextField fullWidth={ true} type="number" defaultValue="0"/>},
    { field: 'col2', headerName: 'Column 2',flex: 2, renderHeader: () => null, sortable: false },
    {field:'col3'},
    {field:'col4'},
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






 function App (props) {
    return (
     <BrowserRouter>
      <Routes>
        <Route path="/" element={window.innerWidth>780?<TableView/>:<TableViewMobile />}></Route>
        <Route path="/t" element={<Game2 />}></Route>
      </Routes>
    </BrowserRouter>

    );
  }
  //<Route path="/t3" element={<PersonView />}></Route>
  //<Route path="/t" element={<Game2 />}></Route>
  //<Route path="/t2" element={<Game />}></Route>
 
  // ========================================
  
  const root = ReactDOM.createRoot(document.getElementById("root"));
  root.render(App());
  