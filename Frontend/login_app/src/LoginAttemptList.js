import React from "react";
import "./LoginAttemptList.css";

const LoginAttempt = (props) => (
  <>
    {props?.login?.name && (
      <li className="Attempt-List-Main">{props.children}</li>
    )}
  </>
);

const LoginAttemptList = (props) => (
  <>
    <div className="Attempt-List-Main">
      <p>Recent activity</p>
      <input type="input" placeholder="Filter..." />
      <ul className="Attempt-List">
        {props.attempts?.map((ele, index) => (
          <LoginAttempt login={ele} key={index}>
            {ele.name} was logged in {ele.status}
          </LoginAttempt>
        ))}
      </ul>
    </div>
  </>
);

export default LoginAttemptList;
