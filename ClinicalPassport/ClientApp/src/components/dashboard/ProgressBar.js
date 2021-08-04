import React, {useEffect, useState} from 'react'
import axios from 'axios'
import { Header, Segment, Table, Progress, Menu } from 'semantic-ui-react'



export default function ProgressBars({ notComplete, completed, underReview, menuType }) {

    return (
              <Segment>
                <Header as='h3'><strong>{menuType} Progress</strong></Header>
                <br />
                <p style={{fontSize: '10px'}}> NOT COMPLETED </p>
                <Progress percent={notComplete} size="tiny" color="red" />
                <p style={{ fontSize: '10px' }}> UNDER REVIEW </p>
            <Progress percent={underReview} size="tiny" color="orange" />
                <p style={{ fontSize: '10px' }}> COMPLETED </p>
                <Progress percent={completed} size="tiny" color="green" />
            </Segment>
            )
            }


