import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render() {
    return (
      <div>
        <h1>Hello, world!</h1>
        <p>Welcome to my TCC.</p>
        <ul>
          <li><strong>Student:</strong> Igor Luciano de Paula</li>
          <li><strong>Professor:</strong> Andrei Rimsa</li>
        </ul>
      </div>
    );
  }
}
