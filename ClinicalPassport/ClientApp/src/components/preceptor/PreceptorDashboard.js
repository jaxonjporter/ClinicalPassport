import React, { useState, useEffect, useContext} from 'react'
import { Menu, Header, Table, Segment} from 'semantic-ui-react'
import { PreceptorContext } from './PreceptorProvider'
import axios from 'axios'
import styled from 'styled-components'
import TaskTableRow from './PreceptorTaskTableRow'

export default function PreceptorDashboard(props) {
    const { state } = useContext(PreceptorContext)
   

    return (
        <div>
            <Segment inverted style={{ background: '#4ba23f', padding: 10, display: 'flex' }}><p style={{ fontSize: '1.5rem' }}>Welcome Back {state.user.firstName}</p></Segment>
            <Header as='h1' style={{fontSize: '3rem'}}>Passports</Header>
            <Menu pointing secondary>
                <Menu.Item name="Submitted Tasks" active={true} style={{borderColor: "green"}}/>
            </Menu>
            <PreceptorTab/>
        </div>
    )
}


const getPreceptorTasks = async (userId, categoryId) => {
    return axios.get(`/preceptor/${userId}`).then(res => {
        return res.data
    })
        .catch(err => {
            console.log(err)
        })

}


const categories = {
    Documentation: 1,
    Procedural: 2,
    Screening: 3,
    Diagnostic: 4
}

function PreceptorTab() {
    const { state: { user }, actions } = useContext(PreceptorContext)
    const [data, setData] = useState({})


    useEffect(() => {
        if (user.userId) getPreceptorTasks(user.userId).then(res => {
            setData({ ...res, tasks: getTasks(res.taskCompletions) })
        })
    }, [user.userId])

    return (
        <div>

            <Segment style={{ padding: 0 }} >

                <div style={{ padding: 10, display: 'flex', justifyContent: 'space-between' }}>
                    <Header as='h3'><strong>Submitted Tasks ({data.tasks && data.tasks.length})</strong></Header>
                </div>
                <Table attached='top'>
                    <CustomTableHeader style={{ color: "#4ba23f !important" }}>
                        <CustomTableHeaderRow>
                            <CustomTableHeaderCell>TASK NAME</CustomTableHeaderCell>
                            <CustomTableHeaderCell>TYPE</CustomTableHeaderCell>
                            <CustomTableHeaderCell>SUBMITTER</CustomTableHeaderCell>
                            <CustomTableHeaderCell>REQUIRED</CustomTableHeaderCell>
                            <CustomTableHeaderCell></CustomTableHeaderCell>
                        </CustomTableHeaderRow>
                    </CustomTableHeader>
                    <Table.Body>
                        {data.tasks
                            ? data.tasks.map((t, i) =>
                                <TaskTableRow key={i} task={t} taskCompletion={data.taskCompletions.find(tc => tc.taskId === t.taskId)} />
                            )
                            : null
                        }
                    </Table.Body>
                </Table>
            </Segment>
        </div>
    )
}


const CustomTableHeaderRow = styled(Table.Row)`
    background-color: #4BA23F !important;
`
const CustomTableHeaderCell = styled(Table.Cell)`
    background-color: #4BA23F !important;
    color: white !important;
`
const CustomTableHeader = styled(Table.Header)`
    background-color: #4BA23F !important;
`




function getTasks(taskCompletions) {
    let tasks = taskCompletions.reduce((acc, tc) => {
        return [...acc, tc.task]
    }, [])
    return tasks
}



const getProgress = async (userId, categoryId) => {
    return axios.get(`/dashboard/progress/${userId}/${categoryId}`).then(res => {

        return res.data
    })
        .catch(err => {
            console.log(err)
        })

}