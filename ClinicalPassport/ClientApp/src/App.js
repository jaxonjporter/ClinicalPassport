import React, { useContext, useEffect } from 'react';
import { Route, Link, Redirect, Switch } from 'react-router-dom';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import 'semantic-ui-css/semantic.min.css'
import { Container } from 'semantic-ui-react'
import './custom.css'
import DashboardApp from './components/dashboard/DashboardApp';
import PreceptorApp from './components/preceptor/PreceptorApp';
import { Login } from './components/login/Login';
import { AuthContext } from './components/login/AuthProvider';

export default function App (props) {
    return (
            <NavBar color="#225d35">
            <Container>
                <Switch>
                <Route exact path='/login' component={Login} />
                <ProtectedRoute exact path='/counter' component={Counter} />
                <ProtectedRoute exact path='/fetch-data' component={FetchData} />
                <PreceptorRoute exact path='/' />
                <ProtectedRoute exact path='/logout' component={Logout} />
                    </Switch>
            </Container >
            </NavBar>
    );
}

function PreceptorRoute({ component: Component, ...rest }) {
    const { state } = useContext(AuthContext)

    return (
        <Route {...rest} render={props =>
            state.authenticated ? state.user.role !== "student" ? <PreceptorApp /> : <DashboardApp />
                : <Redirect to={{ pathname: "/login", state: { from: props.location } }} />
        }
        />
    )
}

function ProtectedRoute({ component: Component, ...rest }) {
    const { state } = useContext(AuthContext)

    return (
        <Route {...rest} render={props =>
            state.authenticated && state.user.role !== "preceptor"
                ? <Component {...props} />
                : <Redirect to={{ pathname: "/login", state: { from: props.location } }} />
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

