import React, { useEffect } from 'react'
import {Header, Segment, Table, Progress} from 'semantic-ui-react'

export default function DashboardTab(props) {

    //useEffect(() => {
    //    console.log(props.menuType)

    //}, [props.menuType])

    return (
        <div>
        <Segment>
                <Header as='h3'><strong>{props.menuType} Progress</strong></Header>
                <br />
                <p style={{fontSize: '10px'}}> NOT COMPLETED </p>
                <Progress percent={40} size="tiny" color="red" />
                <p style={{ fontSize: '10px' }}> UNDER REVIEW </p>
                <Progress percent={25} size="tiny" color="orange" />
                <p style={{ fontSize: '10px' }}> COMPLETED </p>
                <Progress percent={59} size="tiny" color="green" />
            </Segment>
            <Segment style={{ padding: 0 }} >
            <div style={{ padding: 10, display: 'flex', justifyContent: 'space-between' }}>
                <Header as='h3'><strong>Tasks (22)</strong></Header>
            </div>
            <Table attached='top'>
                    <Table.Header style={{ color:"#4ba23f" }}>
                        <Table.Row>
                            <Table.HeaderCell>TASK NAME</Table.HeaderCell>
                            <Table.HeaderCell>TYPE</Table.HeaderCell>
                            <Table.HeaderCell>STATUS</Table.HeaderCell>
                            <Table.HeaderCell>REQUIRED</Table.HeaderCell>
                            <Table.HeaderCell></Table.HeaderCell>
                        </Table.Row>
                    </Table.Header>
            </Table>
            </Segment>
            </div>
    )
}