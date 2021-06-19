import React, { useState } from 'react'
import { Header } from 'semantic-ui-react'
import Dashboard from './dashboard/dashboard'

export function Home(props) {
    const [state, setState] = useState(false)

    const headerClick = () => {
        setState(!state)
    }

    return (
        <div>
            <Dashboard toggled={state} toggledClick={headerClick} />
        </div>
    );
  }
