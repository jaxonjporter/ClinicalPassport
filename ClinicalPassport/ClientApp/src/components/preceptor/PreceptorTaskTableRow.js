import React, { useEffect, useState } from 'react'
import { Table, Icon, Label } from 'semantic-ui-react'
import styled, { css } from 'styled-components'
import axios from 'axios'


export default function PreceptorTaskTableRow({ task, completedTasks, taskCompletion }) {

    return (
        <>
            <Table.Row>
                <Table.Cell>{task.description}</Table.Cell>
                <Table.Cell>{task.category.description}</Table.Cell>
                <Table.Cell>{`${taskCompletion.student.firstName} ${taskCompletion.student.lastName}`}</Table.Cell>
                <Table.Cell>{task.required ? "Yes" : "No"}</Table.Cell>
                <Table.Cell><SubmitLink taskCompletion={taskCompletion} /></Table.Cell>
            </Table.Row> 
        </>
    )
}

const headerConfig = {
    'content-type': "application/json",
    "Accept": "application/json"
}

function SubmitLink({ taskCompletion }) {
    const [active, setActive] = useState(true)

    const deny = () => {

        return axios({
            method: 'post',
            url: '/preceptor/deny',
            data: taskCompletion.taskCompletionId,
            headers: headerConfig
        }).then(res => {
            if (res.status == 200) {
                setActive(false)
            }
        })
    }

    const approve = () => {
        return axios({
            method: 'post',
            url: '/preceptor/approve',
            data: taskCompletion.taskCompletionId,
            headers: headerConfig
        }).then(res => {
            if (res.status == 200) {
                setActive(false)
            }
        })
    }

    return <div><CustomLink active={active} onClick={approve}>Approve</CustomLink> | <CustomLink active={active} onClick={ deny}>Deny</CustomLink> </div>
}

const CustomLink = styled.p`
display: inline-block;
   color: ${props => props.active ? "#2F80ED" :"#8C8B89" };
    ${props => props.active && css`cursor: pointer;`}
:hover{
    opacity: .8;
}
`


function StatusLabel({ taskCompletion }) {
    const { text, color, bgColor } = getTaskStatus(taskCompletion)
    return <CustomLabel circular textcolor={color} bgColor={bgColor}>{text}</CustomLabel>
}

function getTaskStatus(taskCompletion) {
    if (!taskCompletion) return ({ text: "Not Completed", color: "#6B0000", bgColor: "#FFADAD" })
    if (taskCompletion.initialDate && taskCompletion.preceptorInitial) return ({ text: "Completed", color: "#007F00", bgColor: "#CDFFCD" })
    if (taskCompletion.studentCompleted) return ({ text: "Under Review", color: "#843E00", bgColor: "#FFD0A7" })
    return ({ text: "Not Completed", color: "#6B0000", bgColor: "#FFADAD" })
}

const CustomLabel = styled(Label)`
    ${props => props.textcolor && css`color: ${props.textcolor} !important;`}
    ${props => props.bgColor && css`background-color: ${props.bgColor} !important;`}
`

function formatDate(date, format) {
    const jsDate = new Date(date)
    return jsDate.toLocaleDateString(format)
}

const LargeRow = styled(Table.Row)`
    height: 75px;
`

const SemanticIcon = styled(Icon)`
    :hover {
    cursor: pointer;
}
`