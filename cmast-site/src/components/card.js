import React from "react";
import {Link} from "gatsby";
import PropTypes from "prop-types";

const cardStyle = {}

const Card = () => (
    <div className="card">
        <h3>Card Name</h3>
        <Link to="/">Link</Link>
        <p>Card info</p>
    </div>
)

export default Card