import React, { Component } from 'react';
import { NavLink, Link } from 'react-router-dom'
import './NavMenu.css';

export class NavMenu extends Component {
  static displayName = NavMenu.name;

  constructor (props) {
    super(props);

    this.toggleNavbar = this.toggleNavbar.bind(this);
    this.state = {
      collapsed: false
    };
  }

  toggleNavbar () {
    this.setState({
      collapsed: !this.state.collapsed
    });
  }

  render () {
    return (
      <header>
              <ul className="navbar-nav flex-grow">
                  <Link tag={Link} className="text-dark" to="/">Home</Link>
                  <Link tag={Link} className="text-dark" to="/counter">Counter</Link>
                  <Link tag={Link} className="text-dark" to="/fetch-data">Fetch data</Link>
              </ul>
      </header>
    );
  }
}
