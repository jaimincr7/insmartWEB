import { useState } from "react";
import { Nav, Navbar } from "react-bootstrap";
// import { BiUser } from "react-icons/bi";
import styles from "../../styles/Header.module.css";

import Select from "react-select";
import makeAnimated from "react-select/animated";
import Image from "next/image";
import { Logo } from "../../public/assets";

// import Search from "../../../components/common/search";

// import Login from "../login/login";

function Header() {
  const animatedComponents = makeAnimated();
  const language = [
    { value: "1", label: "English" },
    { value: "2", label: "Vietnam" },
    { value: "3", label: "Arabic" },
  ];

  const [show, setShow] = useState(false);
  const handleShow = () => setShow(true);
  const handleClose = () => setShow(false);

  return (
    <>
      {/* Login, Verification Code, Create Account, Forgot Password, NewPassword */}

      {/* <Login show={show} onHide={() => handleClose()} /> */}
      {/* <VerificationCode show={show} onHide={() => handleClose()} /> */}
      {/* <CreateAccount show={show} onHide={() => handleClose()} /> */}
      {/* <ForgotPassword show={show} onHide={() => handleClose()} /> */}
      {/* <NewPassword show={show} onHide={() => handleClose()} /> */}

      {/* Login, Verification Code, Create Account, Forgot Password, NewPassword */}

      <div className={styles["headertop-cover"]}>
        <div className="container">
          <Navbar
            collapseOnSelect
            expand="lg"
            className={styles["headermainCov"]}
          >
            <Navbar.Brand href="#home">
              <div className={styles["headerlogo-set"]}>
                <Image src={Logo} alt="logo" />
              </div>
            </Navbar.Brand>
            <Navbar.Toggle aria-controls="responsive-navbar-nav" />

            {/* User Nav Menu Start */}

            <div className={styles["signinup_btn"]}>
              <a href="javascript:;" onClick={handleShow}>
                {/* <BiUser /> */}
                Sign In / Sign Up
              </a>
            </div>
            {/* <Dropdown className="UserDatacCovmainnav" autoClose="outside">
                            <Dropdown.Toggle id="dropdown-autoclose-outside">
                                <BiUser /> Phoenix Baker
                            </Dropdown.Toggle>
                            <Dropdown.Menu className='mainnavuserloinboff'>
                                <div className='userprofiledataCov'>
                                    <img src={UserProfileIcon} alt="User Profile" />
                                    <h6>Phoenix Baker</h6>
                                    <p>+1 8525236852</p>
                                </div>
                                <Dropdown.Item href="#">My Appointments</Dropdown.Item>
                                <Dropdown.Item href="#">My Health Records</Dropdown.Item>
                                <Dropdown.Item href="#">My Address</Dropdown.Item>
                                <Dropdown.Item href="#">View / Update Profile</Dropdown.Item>
                                <Dropdown.Item href="#">Notification</Dropdown.Item>
                                <Dropdown.Item href="#">Logout</Dropdown.Item>
                            </Dropdown.Menu>
                        </Dropdown> */}

            {/* User Nav Menu End */}

            {/* <Search /> */}

            <Navbar.Collapse id="responsive-navbar-nav" className="">
              <Nav className="">
                <Nav.Link href="#features">Home Visit</Nav.Link>
                <Nav.Link href="#pricing">Video Consult</Nav.Link>
                <Nav.Link href="#pricing">Hospital Visit</Nav.Link>
                <div className={styles["langdown-btn"]}>
                  <Select
                    components={animatedComponents}
                    classNamePrefix="react-select"
                    options={language}
                    defaultValue={language[0]}
                  />
                </div>
              </Nav>
            </Navbar.Collapse>
          </Navbar>

          {/* <div className="headerbox-cover">
                        <div className="headerlogo-set">
                            <a href="javascript:;"><img src={Logo} alt="logo" /></a>
                        </div>
                        <div className="searchbar-set">
                            <BiSearch />
                            <input type="text" placeholder='Search doctor, speciality, symptoms' />
                        </div>

                        <div className="right-headerpart">
                            <div className="ourmenulist-set">
                                <ul>
                                    <li>
                                        <a href="javascript:;">Home Visit</a>
                                    </li>
                                    <li>
                                        <a href="javascript:;">Video Consult</a>
                                    </li>
                                    <li>
                                        <a href="javascript:;">Hospital Visit</a>
                                    </li>
                                </ul>
                            </div>
                            <div className="signinup_btn">
                                <a href="javascript:;"><BiUser />Sign In / Sign Up</a>
                            </div>
                            <div className="langdown-btn">
                                <select className="langdropdown" name="language">
                                    <option value="">English</option>
                                    <option value="">Vietnam</option>
                                    <option value="">Arabic</option>
                                </select>
                            </div>
                        </div>
                    </div> */}
        </div>
      </div>
    </>
  );
}

export default Header;
