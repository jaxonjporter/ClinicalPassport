import React, {useContext, useState} from 'react'
import { Header, Segment, Divider, Input, Form, Label, Button } from 'semantic-ui-react'
import { AuthContext } from './AuthProvider'
import { useHistory } from 'react-router-dom'

export function Login(props) {
    const {state, actions} = useContext(AuthContext)
    const [userName, setUserName] = useState()
    const history = useHistory()


    const updateUserName = (e, data) => {
        setUserName(data.value)
    }
    const handleSubmit = (e, data) => {
        e.preventDefault()
        
        actions.login({ username: userName, password: '' }).then(res => {
            !res && history.push('/')
        })        
    } 
    
    return (
        <div style={{display: 'flex', justifyContent: 'center', alignItems: 'center', height: 'calc(100vh - 60px)'}}>
            <Segment style={{width: "400px"}}>
                <div style={{display: 'flex', justifyContent: 'center'}}>
                    <Header as='h1'>
                        Clinical Passport Login
                    </Header>
                </div>
                <Divider />
                <Form onSubmit={handleSubmit}>
                    <Form.Field>
                        <Header sub>Username</Header>
                        <Input placeholder="Username" onChange={updateUserName}/>
                    </Form.Field>
                    <Form.Field>
                        <Header sub>Password</Header>
                        <Input placeholder="Password" type="password" onChange={updateUserName}/>
                    </Form.Field>
                    <Button type="submit">Login</Button>
                </Form>
            </Segment>
        </div>
    )

}