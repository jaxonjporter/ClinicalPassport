import React from 'react'
import PreceptorDashboard from './PreceptorDashboard'
import PreceptorProvider from './PreceptorProvider'

export default function DashboardApp(props) {
    return (
        <PreceptorProvider>
            <PreceptorDashboard />
        </PreceptorProvider>
        )
}