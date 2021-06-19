import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import 'semantic-ui-css/semantic.min.css'
import { Container } from 'semantic-ui-react'


import './custom.css'

export default function App (props) {
  const displayName = App.name;

    return (
        <Layout>
            <Container>
                <Route exact path='/' component={Home} />
                <Route path='/counter' component={Counter} />
                <Route path='/fetch-data' component={FetchData} />
            </Container >
      </Layout>
    );
  }

