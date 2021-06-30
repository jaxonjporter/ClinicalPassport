import React, { Component } from 'react';
import { Route } from 'react-router';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import 'semantic-ui-css/semantic.min.css'
import { Container } from 'semantic-ui-react'


import './custom.css'
import Dashboard from './components/dashboard/dashboard';

export default function App (props) {
    return (
            <NavBar color="#225d35">
            <Container>
                <Route exact path='/counter' component={Counter} />
                <Route exact path='/fetch-data' component={FetchData} />
                <Route exact path='/' component={Dashboard} />
            </Container >
            </NavBar>
    );
}

function NavBar(props) {
    return (
        <>
            <div style={{ display: 'flex', justifyContent: 'space-between', background: props.color, color: 'white', padding: '15px', marginBottom: '5px'}}>
            <div>
                <h4>UVU Physician Assistant Clinical Passport</h4>
            </div>
            <div style={{ display: 'flex'}}>
                <div style={{margin: '0 10px 0 0'}}>Profile</div>
                  <div>Login</div>
                </div>
            </div>
            {props.children}
        </>
    )
}

