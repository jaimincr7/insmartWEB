import React from 'react'
import { Androidicon, Iosicon, Mobileimage } from '../../../public/assets';
// import '../../../css/main.css';
import styles from "../../../styles/AppSection-Style.module.css";
import Image from "next/image";

import { Container } from 'react-bootstrap';

function appsection() {
  return (
    <>
        <div className={styles["appsect-cover"]}>
            <Container>
            {/* <div className="container"> */}
                <div className={styles["appsect-set"]}>
                    <div className={styles["appsect-left"]}>
                        <h2>Download the Insmart app</h2>
                        <p>Access video consultation with top doctors on the Insmart app. Connect <br />
                        with doctors online, available 24/7, from the comfort of your home.</p>
                        <div className={styles["downloadapp-set"]}>
                            <span>Get the link to download the app</span>
                            <div className={styles["appicon-img"]}>
                            <a href="javascript:;">
                                <Image src={Androidicon} alt="android" />
                            </a>
                            <a href="javascript:;">
                                <Image src={Iosicon} alt="ios" />
                            </a>
                            </div>
                        </div>
                    </div>
                    <div className={styles["appsect-right"]}>
                        <Image src={Mobileimage} alt="Mobile image" />
                    </div>
                </div>
            {/* </div> */}
            </Container>
        </div>
    </>
  )
}

export default appsection