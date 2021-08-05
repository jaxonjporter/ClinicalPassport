import React, { useState, useEffect, useContext} from 'react'
import { Menu, Header, Segment} from 'semantic-ui-react'
import DashboardTab from './DashboardTab'
import {DashboardContext} from './DashboardProvider'

export default function Dashboard(props) {
    const {state} = useContext(DashboardContext)
    const [activeTab, setActiveTab] = useState('documentation')
    const panes = {
        documentation: <DashboardTab menuType="Documentation" />,
        procedural: <DashboardTab menuType="Procedural" />,
        screening: <DashboardTab menuType="Screening" />,
        diagnosis: <DashboardTab menuType="Diagnostic" />
    }

    const updateActiveTab = (e, { name }) => {setActiveTab(name)}

   

    return (
        <div>
            <Segment inverted style={{ background: '#4ba23f', padding: 10, display: 'flex' }}><p style={{ fontSize: '1.5rem' }}>Welcome Back {state.user.firstName}</p></Segment>
            <Header as='h1' style={{fontSize: '3rem'}}>Passports</Header>
            <Menu pointing secondary>
                <Menu.Item name="documentation" active={activeTab === 'documentation'} style={activeTab === 'documentation' ? {borderColor: "green"} : null} onClick={updateActiveTab}/>
                <Menu.Item name="procedural" active={activeTab === 'procedural'} style={activeTab === 'procedural' ? { borderColor: "green" } : null}  onClick={updateActiveTab}/>
                <Menu.Item name="screening" active={activeTab === 'screening'} style={activeTab === 'screening' ? { borderColor: "green" } : null} onClick={updateActiveTab}/>
                <Menu.Item name="diagnosis" active={activeTab === 'diagnosis'} style={activeTab === 'diagnosis' ? { borderColor: "green" } : null} onClick={updateActiveTab}/>
            </Menu>
            {panes[activeTab]}
        </div>
    )
}