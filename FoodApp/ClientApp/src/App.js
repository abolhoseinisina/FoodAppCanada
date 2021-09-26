import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Individual } from './components/Individual';
import { Family } from './components/Family';

import './custom.css'

export default class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <Layout>
                <Route exact path='/' component={Home} />
                <Route path='/individualMenu' component={Individual} />
                <Route path='/familyMenu' component={Family} />
            </Layout>
        );
    }
}
