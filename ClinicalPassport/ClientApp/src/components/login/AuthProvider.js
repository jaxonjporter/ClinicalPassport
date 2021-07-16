import React, {useEffect, useContext, useReducer} from 'react';
import { useHistory } from 'react-router-dom';

export const AuthContext = React.createContext();

const actions = {
    UPDATE_STATE: 'update_state'
}

function reducer (state, action) {
    switch(action.type){
        case actions.UPDATE_STATE:
            return ({...state, ...action.obj})
    }
} 

const initialState = {
    user: null,
    authenticated: false
}

export default function AuthProvider(props){
    const [state, dispatch] = useReducer(reducer, initialState)
    const history = useHistory()

    const updateState = async (obj) => dispatch({type: actions.UPDATE_STATE, obj})

    const value = {
        state,
        actions: {
            updateState
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