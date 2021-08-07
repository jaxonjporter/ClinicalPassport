import React, { useContext, useEffect, useState } from 'react'
import {Header, Segment, Table, Progress, Icon} from 'semantic-ui-react'
import { DashboardContext } from './PreceptorProvider'
import ProgressBars from './ProgressBar'
import axios from 'axios'
import styled from 'styled-components'
import TaskTableRow from './PreceptorTaskTableRow'

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
                    <CustomTableHeader style={{ color:"#4ba23f !important" }}>
                        <CustomTableHeaderRow>
                            <CustomTableHeaderCell></CustomTableHeaderCell>
                            <CustomTableHeaderCell>TASK NAME</CustomTableHeaderCell>
                            <CustomTableHeaderCell>TYPE</CustomTableHeaderCell>
                            <CustomTableHeaderCell>STATUS</CustomTableHeaderCell>
                            <CustomTableHeaderCell>REQUIRED</CustomTableHeaderCell>
                            <CustomTableHeaderCell></CustomTableHeaderCell>
                        </CustomTableHeaderRow>
                    </CustomTableHeader>
                    <Table.Body>
                        {data.tasks
                            ? data.tasks.map((t, i) =>
                                <TaskTableRow key={i} task={t} completedTasks={data.completedTasks} menuType={menuType} taskCompletion={data.taskCompletions.find(tc => tc.taskId === t.taskId)}/>
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