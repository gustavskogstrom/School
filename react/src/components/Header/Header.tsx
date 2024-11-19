import { Link } from "react-router-dom";
import "./Header.css"

const Header = () => {
    return(
        <header>
            <div className="logo">
                <h1><Link to="/home">School</Link></h1>
            </div>
            <nav>
                <ul>
                    <li>
                        <Link to="/home">Home</Link>
                    </li>
                    <li>
                        <Link to="/about">About</Link>
                    </li>
                    <li>
                        <Link to="/login">Login</Link>
                    </li>
                </ul>
            </nav>
        </header>
    );
}

export default Header;