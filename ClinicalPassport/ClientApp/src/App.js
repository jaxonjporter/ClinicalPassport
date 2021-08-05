import React, { Component, useContext, useEffect } from 'react';
import { Route, useHistory, Link, Redirect } from 'react-router-dom';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import 'semantic-ui-css/semantic.min.css'
import { Container } from 'semantic-ui-react'
import './custom.css'
import DashboardApp from './components/dashboard/DashboardApp';
import { Login } from './components/login/Login';
import { AuthContext } from './components/login/AuthProvider';

export default function App (props) {
    return (
            <NavBar color="#225d35">
            <Container>
                <Route exact path='/login' component={Login} />
                <ProtectedRoute exact path='/counter' component={Counter} />
                <ProtectedRoute exact path='/fetch-data' component={FetchData} />
                <ProtectedRoute exact path='/' component={DashboardApp} />
                <ProtectedRoute exact path='/logout' component={Logout} />
            </Container >
            </NavBar>
    );
}


function ProtectedRoute ({ component: Component, ...rest }) {
    const {state} = useContext(AuthContext)

    return(
        <Route {...rest} render={props =>
                state.authenticated 
                ? <Component {...props} />
                : <Redirect to={{ pathname: "/login", state: { from: props.location }}}/>
            }
        />
    )
}

function Logout() {
    const { actions } = useContext(AuthContext)
    useEffect(() => {
        actions.logout()
    }, [])
    return null
}

function NavBar(props) {
    const { state, actions } = useContext(AuthContext)
    // it is bad practice to do inline styling.
    return (
        <>
            <div style={{ display: 'flex', justifyContent: 'space-between', background: props.color, color: 'white', padding: '15px', marginBottom: '5px'}}>
                <div>
                    <Link style={{textDecoration: 'none', color: 'white'}} to='/'><h4>UVU Physician Assistant Clinical Passport</h4></Link>
                </div>
                <div style={{ display: 'flex'}}>
                    <Link to={state.authenticated ? '/logout': '/login'} style={{textDecoration: 'none', color: 'white'}}>{state.authenticated ? 'Logout' : 'Login'}</Link>
                </div>
            </div>
            {props.children}
        </>
    )
}

