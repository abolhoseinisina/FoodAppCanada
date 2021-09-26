import React, { Component } from 'react';

export class Individual extends Component {
    static displayName = Individual.name;

    constructor(props) {
        super(props);
        this.state = { loading: true, foodGroups: [], suggestions: [], gender: '', age: '' };

        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    componentDidMount() {
        this.getAgeRange();
        this.getGenders();
    }

    static getSuggestion(suggestions, fgId) {
        let str = '';
        for (let i in suggestions) {
            if (suggestions[i].foodGroupId === fgId) {
                str += suggestions[i].statement;
            }
        }
        return str;
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
                            <td>{foodGroup.servingPerDay}</td>
                            <td>{foodGroup.foods.map(food => <p>{food.foodCategory}: {food.servingSize} {food.food}</p>) }</td>
                            <td>{foodGroup.directions.map(direction => <p>{direction.statement}</p>)}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    handleChange(event) {
        if (event.target.id === "gender-range") {
            this.setState({ gender: event.target.value });
        } else {
            this.setState({ age: event.target.value });
        }
    }

    handleSubmit(event) {
        event.preventDefault();
        this.populateMenuData();
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Waiting ...</em></p>
            : Individual.renderMealsTable(this.state.foodGroups);

        return (
            <div>
                <h1 id="tabelLabel" >Individual Daily Menu</h1>
                <p>You can find out a proper suggestion for daily meals based on your age and gender.</p>
                <form onSubmit={this.handleSubmit}>
                    <p> Gender: </p>
                    <select id="gender-range" name="gender" onChange={this.handleChange}>
                        <option value="0">Select your gender</option>
                    </select><br />
                    <p> Age: </p>
                    <select id="age-range" name="age" onChange={this.handleChange}>
                        <option value="0">Select your age</option>
                    </select><br />
                    <input type="submit" value="Submit" /><br />
                </form>
                {contents}
            </div>
        );
    }

    async populateMenuData() {
        const response = await fetch('api/DailyMenu', {
            method: 'POST',
            headers: new Headers({
                'Content-Type': 'application/json'
            }),
            body: JSON.stringify({
                age: this.state.age,
                gender: this.state.gender,
            })
        });
        const data = await response.json();
        this.setState({ foodGroups: data.foodGroups, loading: false });
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
        if (document.getElementById("age-range").innerHTML === '<option value="0">Select your age</option>') {
            for (let i in data) {
                document.getElementById("age-range").innerHTML += '<option value="' + data[i] + '">' + data[i] + '</option>';
            }
            //var event = new Event('change');
            //document.getElementById("age-range").dispatchEvent(event);
        }
    }

    fillGenderRange(data) {
        if (document.getElementById("gender-range").innerHTML === '<option value="0">Select your gender</option>') {
            for (let i in data) {
                document.getElementById("gender-range").innerHTML += '<option value="' + data[i] + '">' + data[i] + '</option>';
            }
            //var event = new Event('change');
            //document.getElementById("gender-range").dispatchEvent(event);
        }
    }
}
