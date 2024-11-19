import React from "react";
import ReactDOM from "react-dom/client";
import App from "./App";
const rootElement = document.getElementById("root");

if (!rootElement) {
	throw new Error(
		"Root element not found. Make sure there is an element with id 'root' in your index.html.",
	);
}

const root = ReactDOM.createRoot(rootElement);
root.render(
	<React.StrictMode>
		<App/>
	</React.StrictMode>,
);
