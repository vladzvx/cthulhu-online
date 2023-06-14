import { Route, BrowserRouter, Routes} from "react-router-dom";
import login from './login/login.js';

export default function app (props) {
    return (
     <BrowserRouter>
      <Routes>
        <Route path="/" element={window.innerWidth>780?<login/>:<login />}></Route>
      </Routes>
    </BrowserRouter>
    );
  }