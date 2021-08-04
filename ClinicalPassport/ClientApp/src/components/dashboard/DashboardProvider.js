import React, { useReducer, useEffect, useContext } from 'react'
import axios from 'axios'
import { AuthContext } from '../login/AuthProvider'

export const DashboardContext = React.createContext()

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

export default function DashboardProvider(props) {
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
        axios.get(`/dashboard/index/${user.userId}`).then(res => {
            updateState(res.data)
        })
    }, [user.userId])

    return (
        <DashboardContext.Provider value={value}>
            {props.children}
        </DashboardContext.Provider>
    )


}