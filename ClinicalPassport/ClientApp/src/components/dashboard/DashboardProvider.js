import React, { useReducer, useEffect } from 'react'
import axios from 'axios'

export const DashboardContext = React.createContext() 

const actions = {
    UPDATE_STATE: 'UPDATE_STATE'
}

const reducer = (state, action) => {
    switch (action.type) {
        case actions.UPDATE_STATE:
            return ({...state, ...action.obj})
    }
}

const initialState = {
    user: {
        userId: 1111115
    }
}

export default function DashboardProvider(props) {
    const [state, dispatch] = useReducer(reducer, initialState)

    const updateState = async (obj) => dispatch(state, { type: actions.UPDATE_STATE, obj })

    const value = {
        state,
        actions: {
            updateState
        }
    }

    useEffect(() => {
        axios.get(`/dashboard/index/${state.user.userId}`).then(res => {
            debugger
        }).catch(err => {
            debugger
        })
    }, [])

    return (
        <DashboardContext.Provider value={value}>
            {props.children}
        </DashboardContext.Provider>
    )


}