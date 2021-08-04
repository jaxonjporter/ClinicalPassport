import React, { useContext, useEffect, useState } from 'react'
import {Header, Segment, Table, Progress} from 'semantic-ui-react'
import { DashboardContext } from './DashboardProvider'
import ProgressBars from './ProgressBar'
import axios from 'axios'

const categories = {
    Documentation: 1,
    Procedural: 2,
    Screening: 3,
    Diagnostic: 4
}

export default function DashboardTab({ menuType }) {
    const { state: { user }, actions } = useContext(DashboardContext)
    const [data, setData] = useState({})


    useEffect(() => {
        if (user.userId) getProgress(user.userId, categories[menuType]).then((viewModel) => {
            if (viewModel) setData({ ...viewModel, completedTasks: getTasks(viewModel.taskCompletions)})
        })
    }, [menuType, user.userId])


    return (
        <div>
            <ProgressBars menuType={menuType} notComplete={data.notCompletePercent} completed={data.completedPercent} underReview={ data.underReviewPercent}/>
            <Segment style={{ padding: 0 }} >

            <div style={{ padding: 10, display: 'flex', justifyContent: 'space-between' }}>
                    <Header as='h3'><strong>Tasks ({ data.tasks && data.tasks.length})</strong></Header>
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
                    <Table.Body>
                        {data.tasks
                            ? data.tasks.map(t => 
                            <Table.Row>
                                    <Table.Cell>{t.description}</Table.Cell>
                                    <Table.Cell>{ menuType }</Table.Cell>
                                    <Table.Cell>{ data.completedTasks.some(c => c.completed && t.taskId === c.taskId) ? "Yes" : "No" }</Table.Cell>
                                    <Table.Cell>{ t.required ? "Yes" : "No" }</Table.Cell>
                                    <Table.Cell>Submit for review</Table.Cell>
                                </Table.Row>
                                )
                            : null
                            }
                    </Table.Body>
            </Table>
            </Segment>
            </div>
    )
}


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