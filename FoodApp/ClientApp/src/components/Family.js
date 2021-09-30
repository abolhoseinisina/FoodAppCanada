import React, { Component } from 'react';

export class Family extends Component {
    static displayName = Family.name;

    constructor(props) {
        super(props);
        this.state = { currentCount: 1, foodGroups: [], loading: true };
        this.incrementCounter = this.incrementCounter.bind(this);
        this.reductCounter = this.reductCounter.bind(this);
        this.populateMenuData = this.populateMenuData.bind(this);
    }

    incrementCounter() {
        if (this.state.currentCount >= 10) return;
        if (document.querySelectorAll('.gender-selectors option').length === 1) {
            alert('wait ...');
            return;
        }

        this.setState({
            currentCount: this.state.currentCount + 1
        });

        var row = document.createElement("tr");
        row.className = "member-row";

        var numCell = document.createElement("td");
        numCell.innerText = this.state.currentCount + 1;
        row.appendChild(numCell);

        var genderCell = document.createElement("td");
        genderCell.innerHTML = "Gender: " + document.querySelectorAll('.gender-selectors')[0].outerHTML;
        row.appendChild(genderCell);

        var ageCell = document.createElement("td");
        ageCell.innerHTML = "Age: " + document.querySelectorAll('.age-selectors')[0].outerHTML;
        row.appendChild(ageCell);

        document.getElementById("member-rows").appendChild(row);
    }

    reductCounter() {
        if (this.state.currentCount <= 1) return;
        this.setState({
            currentCount: this.state.currentCount - 1
        });
        let numberOfMemberRows = document.querySelectorAll('.member-row').length;
        let lastMemberRow = document.querySelectorAll('.member-row')[numberOfMemberRows - 1];
        lastMemberRow.remove();
    }

    componentDidMount() {
        this.getAgeRange();
        this.getGenders();
    }

    async getAgeRange() {
        await fetch('api/DailyMenu/AgeRange')
            .then(response => response.json())
            .then(data => this.fillAgeRange(data));
    }

    async getGenders() {
        await fetch('api/DailyMenu/GenderRange')
            .then(response => response.json())
            .then(data => this.fillGenderRange(data));
    }

    fillAgeRange(data) {
        if (document.querySelectorAll('.age-selectors')[0].innerHTML === '<option value="0">Select age</option>') {
            for (let i in data) {
                document.querySelectorAll('.age-selectors')[0].innerHTML += '<option value="' + data[i] + '">' + data[i] + '</option>';
            }
        }
    }

    fillGenderRange(data) {
        if (document.querySelectorAll('.gender-selectors')[0].innerHTML === '<option value="0">Select gender</option>') {
            for (let i in data) {
                document.querySelectorAll('.gender-selectors')[0].innerHTML += '<option value="' + data[i] + '">' + data[i] + '</option>';
            }
        }
    }

    render() {
        let contents = this.state.loading
            ? <p></p>
            : Family.renderMealsTable(this.state.foodGroups);

        return (
            <div>
                <h1>Daily Family Menu</h1>
                <p>You can find out proper suggestions for daily meals based on the age and gender of your family members.</p>
                <p aria-live="polite">Family members: <strong>{this.state.currentCount}</strong></p>
                <p>
                    <button className="btn btn-secondary" onClick={this.incrementCounter}>+ Add Member</button>
                    <button className="btn btn-warning" onClick={this.reductCounter}>- Remove Member</button>
                </p>
                <table>
                    <thead>
                        <tr>
                            <th>Row</th>
                            <th>Gender</th>
                            <th>Age</th>
                        </tr>
                    </thead>
                    <tbody id="member-rows">
                        <tr class="member-row">
                            <td>1</td>
                            <td>
                                Gender:
                                <select class="gender-selectors">
                                    <option value="0">Select gender</option>
                                </select>
                            </td>
                            <td>
                                Age:
                                <select class="age-selectors">
                                    <option value="0">Select age</option>
                                </select>
                            </td>
                        </tr>
                    </tbody>
                </table>

                <p>
                    <button className="btn btn-info" onClick={this.populateMenuData}>Get Daily Menu</button>
                </p>
                {contents}
            </div>
        );
    }

    async populateMenuData() {
        const listOfGenderSelectors = document.querySelectorAll('.gender-selectors');
        const listOfAgeSelectors = document.querySelectorAll('.age-selectors');

        let gendersList = [];
        let ageList = [];
        let request = [];
        for (let ind = 0; ind < listOfGenderSelectors.length; ind++) {
            let gender = listOfGenderSelectors[ind].value;
            let age = listOfAgeSelectors[ind].value;
            if (age === '' || gender === '' || age === '0' || gender === '0') {
                alert('Enter age and gender for all members.')
                return;
            }
            gendersList.push(gender);
            ageList.push(age);
            request.push({
                age: age,
                gender: gender
            });
        }

        const response = await fetch('api/DailyMenu/Family', {
            method: 'POST',
            headers: new Headers({
                'Content-Type': 'application/json'
            }),
            body: JSON.stringify(request)
        });
        const data = await response.json();
        this.setState({ foodGroups: data.foodGroups, loading: false });
    }

    static renderMealsTable(foodGroups) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Food Group</th>
                        <th>Serving Size per Day</th>
                        <th>Examples</th>
                        <th>Suggestions</th>
                    </tr>
                </thead>
                <tbody>
                    {foodGroups.map(foodGroup =>
                        <tr key={foodGroup.foodGroupId}>
                            <td>{foodGroup.foodGroupName}</td>
                            <td>{foodGroup.members.map(member => <p><b>{member.age} {member.gender}</b>: {member.servingPerDay} serving(s)</p>)}</td>
                            <td>{foodGroup.foods.map(food => <p>{food.foodCategory}: {food.servingSize} {food.food}</p>)}</td>
                            <td>{foodGroup.directions.map(direction => <p>{direction.statement}</p>)}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }
}
