import React from 'react';
import { Button } from 'react-bootstrap';
import { FaUserMd, FaRegHospital } from "react-icons/fa";
import styles from "../../../styles/JoinOurTeam.module.css";
import { Doctorsimges } from '../../../public/assets';
import Image from "next/image";

function JoinOurTeam() {

    return (
        <>
            <div className={styles["jointeam-cover"]}>
                <div className="container">
                    <div className={styles["jointeam-set"]}>
                        <div className="row">
                            <div className="col-lg-6 col-md-12">
                                <div className={styles["jointeam-left"]}>
                                    <h2>Join our team</h2>
                                    <p>Register on the Insmart telemedicine platform <br />
                                        and begin your journey of managing patients <br />
                                        conveniently.</p>
                                    <div className={styles["dochosp-btn"]}>
                                        <Button><FaUserMd />Join as Doctor</Button>
                                        <Button className='joinhos-btn'><FaRegHospital />Join as Hospital</Button>
                                    </div>
                                </div>
                            </div>

                            <div className="col-lg-6">
                                <div className={styles["jointeam-right"]}>
                                    <Image src={Doctorsimges} alt="Doctorsimges" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </>
    )
}

export default JoinOurTeam