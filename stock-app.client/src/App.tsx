import React from 'react';
import './App.css';
import {CashTicket} from "./ticket/CashTicket";
import {CreateUserForm} from "./user/UserCreateForm";

function App() {

    return <div className="App">
        <CashTicket/>
        <CreateUserForm/>
    </div>;
}

export default App;
