import React from 'react'
import Dashboard from './dashboard'
import DashboardProvider from './DashboardProvider'

export default function DashboardApp(props) {
    return (
        <DashboardProvider>
            <Dashboard />
        </DashboardProvider>
        )
}