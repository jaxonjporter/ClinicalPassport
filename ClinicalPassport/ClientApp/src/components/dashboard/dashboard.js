import React from 'react'
import { Header, Tab } from 'semantic-ui-react'
import DashboardTab from './DashboardTab'

export default function Dashboard(props) {

    const panes = [
        {menuItem: 'Documentation', render: () => <DashboardTab menuType="documentation" />},
        { menuItem: 'Procedural', render: () => <DashboardTab menuType="procedural" />},
        { menuItem: 'Screening', render: () => <DashboardTab menuType="screening" />},
        { menuItem: 'Diagnosis and Management', render: () => <DashboardTab menuType="diagnosis" />},
    ]

    return (
        <div>
            <Tab panes={panes} />
        </div>
    )
}