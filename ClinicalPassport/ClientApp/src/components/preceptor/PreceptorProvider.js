import React, { useReducer, useEffect, useContext } from 'react'
import axios from 'axios'
import { AuthContext } from '../login/AuthProvider'

export const PreceptorContext = React.createContext()

const actions = {
    UPDATE_STATE: 'UPDATE_STATE'
}

const reducer = (state, action) => {
    switch (action.type) {
        case actions.UPDATE_STATE:
            return ({ ...state, ...action.obj })
    }
}

const initialState = {
    user: {
        userId: null
    }
}

export default function PreceptorProvider(props) {
    const [state, dispatch] = useReducer(reducer, initialState)
    const { state: { user } } = useContext(AuthContext)

    const updateState = async (obj) => dispatch({ type: actions.UPDATE_STATE, obj })

    const value = {
        state,
        actions: {
            updateState
        }
    }

    useEffect(() => {
        axios.get(`/preceptor/${user.userId}`).then(res => {
            debugger
            updateState(res.data)
        })
    }, [user.userId])

    return (
        <PreceptorContext.Provider value={value}>
            {props.children}
        </PreceptorContext.Provider>
    )


}