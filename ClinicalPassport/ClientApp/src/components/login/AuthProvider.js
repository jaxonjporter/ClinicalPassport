import React, { useEffect, useContext, useReducer } from 'react'
import { useHistory } from 'react-router-dom'
import axios from 'axios'

export const AuthContext = React.createContext();

const actions = {
    UPDATE_STATE: 'update_state'
}

function reducer(state, action) {
    switch (action.type) {
        case actions.UPDATE_STATE:
            return ({ ...state, ...action.obj })
    }
}

const initialState = {
    user: null,
    authenticated: false
}

export default function AuthProvider(props) {
    const [state, dispatch] = useReducer(reducer, initialState)
    const history = useHistory()

    const updateState = async (obj) => dispatch({ type: actions.UPDATE_STATE, obj })
    const login = async ({ username, password }) => {
        const headerConfig = {
            'content-type': "application/json",
            "Accept": "application/json"
        }
        console.log(username)
        return axios({
            method: 'post',
            url: '/home/login',
            data: parseInt(username),
            headers: headerConfig
        }).then(res => {
            updateState({user: res.data, authenticated: true}).then(() => {
                window.localStorage.setItem('session', JSON.stringify({ username, password: password, role: res.data.role || 'none' }))
                return res
            })
        }).catch(err => {
            console.log(err)
            return err
        })

    }
    const logout = async (obj) => {
        updateState(initialState).then(() => { window.localStorage.removeItem('session') })
    }

    useEffect(() => {
        const session = window.localStorage.getItem('session')
        if (session) {
            const { username, password, role } = JSON.parse(session)
            const toSet = {
                user: {
                    userId: username,
                    password: password,
                    role: role
                },
                authenticated: true
            }
            updateState(toSet)
        }
    }, [])

    const value = {
        state,
        actions: {
            updateState,
            login,
            logout
        }
    }

    useEffect(() => {
        history.push('/')
    }, [state.authenticated])

    return (
        <AuthContext.Provider value={value}>
            {props.children}
        </AuthContext.Provider>
    )
}