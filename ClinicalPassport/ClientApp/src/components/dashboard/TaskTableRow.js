import React, { useEffect, useState } from 'react'
import { Table, Icon, Label } from 'semantic-ui-react'
import styled, { css } from 'styled-components'
import axios from 'axios'

export default function TaskTableRow({ task, completedTasks, menuType, taskCompletion }) {
    const [expanded, setExpanded] = useState(false)
    const [submitted, setSubmitted] = useState(false)

    useEffect(() => {
        setExpanded(false)
    }, [menuType])

    const updateSubmitted = (value) => {
        taskCompletion.studentCompleted = value
        setSubmitted(value)
    }

    return (
        <>
            <Table.Row>
                <Table.Cell><SemanticIcon name={expanded ? "chevron up" : "chevron down"} onClick={() => setExpanded(!expanded)} /></Table.Cell>
                <Table.Cell>{task.description}</Table.Cell>
                <Table.Cell>{menuType}</Table.Cell>
                <Table.Cell><StatusLabel taskCompletion={ taskCompletion }/></Table.Cell>
                <Table.Cell>{task.required ? "Yes" : "No"}</Table.Cell>
                <Table.Cell><SubmitLink taskCompletion={taskCompletion} updateSubmitted={updateSubmitted} /></Table.Cell>
            </Table.Row> 
            {expanded
                ? <LargeRow>
                    <Table.Cell></Table.Cell>
                    <Table.Cell>
                        {taskCompletion && taskCompletion.initialDate && taskCompletion.preceptorInitial
                            ? <>
                                Preceptor: {taskCompletion.preceptorInitial}<br /><br />
                                Date Completed: {formatDate(taskCompletion.initialDate, 'en-us')}
                            </>
                            : <>Submitted for Review: {submitted || taskCompletion && taskCompletion.studentCompleted ? "Yes" : "No" } </>}</Table.Cell>
                    <Table.Cell></Table.Cell>
                    <Table.Cell></Table.Cell>
                    <Table.Cell></Table.Cell>
                    <Table.Cell></Table.Cell>
                </LargeRow> 
                : null
                
            }
        </>
    )
}

function SubmitLink({ taskCompletion, updateSubmitted }) {
    const [active, setActive] = useState(false)

    useEffect(() => {
        setActive(taskCompletion && !taskCompletion.studentCompleted)
    }, [taskCompletion])

    const submitTask = () => {
        const headerConfig = {
            'content-type': "application/json",
            "Accept": "application/json"
        }
        return axios({
            method: 'post',
            url: '/dashboard/submit',
            data: taskCompletion.taskCompletionId,
            headers: headerConfig
        }).then(res => {
            if (res.status == 200) {
                setActive(false)
                updateSubmitted(res.status == 200)
            }
        })
    }

    return <CustomLink onClick={submitTask} active={active}>Submit for Review</CustomLink>
}

const CustomLink = styled.p`
   color: ${props => props.active ? "#2F80ED" :"#8C8B89" };
    ${props => props.active && css`cursor: pointer;`}
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