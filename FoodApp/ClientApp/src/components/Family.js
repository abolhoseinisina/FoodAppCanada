import React, { Component } from 'react';

export class Family extends Component {
    static displayName = "Daily Family Menu";

    constructor(props) {
        super(props);
        this.state = { currentCount: 1 };
        this.incrementCounter = this.incrementCounter.bind(this);
    }

    incrementCounter() {
        this.setState({
            currentCount: this.state.currentCount + 1
        });
    }

    render() {
        return (
            <div>
                <h1>Daily Family Menu</h1>
                <p>You can find out proper suggestions for daily meals based on the age and gender of your family members.</p>
                <p aria-live="polite">Family members: <strong>{this.state.currentCount}</strong></p>
                <table>
                    <thead>
                        <tr>
                            <th>Row</th>
                            <th>Food Group</th>
                            <th>Serving Size per Day</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>1</td>
                            <td>
                                Gender: 
                                <select id="gender-range" name="gender">
                                    <option value="0">Select your gender</option>
                                </select>
                            </td>
                            <td>
                                Age: 
                                <select id="age-range" name="age">
                                    <option value="0">Select your age</option>
                                </select>
                            </td>
                        </tr>
                    </tbody>
                </table>
                <button className="btn btn-primary" onClick={this.incrementCounter}>Increment</button>
            </div>
        );
    }
}
