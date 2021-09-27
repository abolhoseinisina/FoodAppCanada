import React, { Component } from 'react';

export class Home extends Component {
    static displayName = Home.name;

    render() {
        return (
            <div>
                <h1>Hello, GeoSensorWeb Lab!</h1>
                <p>Welcome Canada Food Guid, built with:</p>
                <ul>
                    <li>ASP.NET Core for server-side code</li>
                    <li>React for client-side code</li>
                    <li>Bootstrap for styling</li>
                    <li>SQL Server Express LocalDB for storing data</li>
                </ul>
            </div>
        );
    }
}
