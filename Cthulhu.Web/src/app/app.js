import { Route, BrowserRouter, Routes} from "react-router-dom";
import login from './login/login.js';
import selector from './selector/selector.js';
import charview from './characters/charview.js';
import chat from './chat/chat.js';
import notes from './notes/notes.js';
import gameEditor from './editor/gameEditor.js';

export default function app (props) {
    return (
     <BrowserRouter>
      <Routes>
        <Route path="/" element={window.innerWidth>780?login():login()}></Route>
        <Route path="/login" element={window.innerWidth>780?login():login()}></Route>
        <Route path="/selector" element={window.innerWidth>780?selector():selector()}></Route>
        <Route path="/gameEditor" element={window.innerWidth>780?gameEditor():gameEditor()}></Route>
        <Route path="/notes" element={window.innerWidth>780?notes():notes()}></Route>
        <Route path="/chat" element={window.innerWidth>780?chat():chat()}></Route>
        <Route path="/charview" element={window.innerWidth>780?charview():charview()}></Route>
      </Routes>
    </BrowserRouter>
    );
  }