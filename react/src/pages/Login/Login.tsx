import Footer from "../../components/Footer/Footer";
import Header from "../../components/Header/Header";
import { useState } from "react";
import "./Login.css";

const Login = () => {
	const [userType, setUserType] = useState<"student" | "teacher" | null>(null);

	const handleStudentLogin = () => {

		console.log("Student login submitted");
	};

	const handleTeacherLogin = () => {

		console.log("Teacher login submitted");
	};

	return (
		<>
			<Header />
				<main>
					<div className="login-selection">
						<h2>Select User Type</h2>
						<button type="button" onClick={() => setUserType("student")}>
							Student Login
						</button>
						<button type="button" onClick={() => setUserType("teacher")}>
							Teacher Login
						</button>
					</div>

					{userType === "student" && (
						<form onSubmit={handleStudentLogin} className="student-login-form">
							<h3>Student Login</h3>
							<label>
								Email:
								<input type="email" name="email" required />
							</label>
							<label>
								Password:
								<input type="password" name="password" required />
							</label>
							<button type="submit">Login as Student</button>
						</form>
					)}

					{userType === "teacher" && (
						<form onSubmit={handleTeacherLogin} className="teacher-login-form">
							<h3>Teacher Login</h3>
							<label>
								Email:
								<input type="email" name="email" required />
							</label>
							<label>
								Password:
								<input type="password" name="password" required />
							</label>
							<button type="submit">Login as Teacher</button>
						</form>
					)}
				</main>
			<Footer/>
		</>
	);
};

export default Login;
