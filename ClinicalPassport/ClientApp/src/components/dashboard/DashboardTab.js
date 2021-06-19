import React, { useEffect } from 'react'
import {Header} from 'semantic-ui-react'

export default function DashboardTab(props) {
    useEffect(() => {
        console.log(props.menuType)
        //call to DB
    }, [props.menuType])

    return (
        <Header>{props.menuType}</Header>
    )
}