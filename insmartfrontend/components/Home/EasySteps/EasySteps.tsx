import React from 'react';
import { One, Searchicon, Docotricon, Two, Calandericon, Three, Checkedicon, Four } from '../../../public/assets';
import styles from "../../../styles/EasySteps.module.css";
import Image from "next/image";

function EasySteps() {

    return (
        <>
            <div className={styles["getsolution-set"]}>
                <div className="container">
                    <div className={styles["getsolution-title"]}>
                        <h2>4 easy steps to get your solution</h2>
                    </div>
                    <div className="row">
                        <div className="col-lg-3 col-md-6 col-sm-6">
                            <div className={styles["getsolution-list"]}>
                                <Image src={Searchicon} alt="searchicon" className='geticon-set' />
                                <h5>Search doctor</h5>
                                <p>It is a long established fact that a reader will be distracted.</p>
                                <div className="numberimg">
                                    <Image src={One} alt="One" />
                                </div>
                            </div>
                        </div>
                        <div className="col-lg-3 col-md-6 col-sm-6">
                            <div className={styles["getsolution-list"]}>
                                <Image src={Docotricon} alt="docotricon" className='geticon-set' />
                                <h5>Check doctor profile</h5>
                                <p>It is a long established fact that a reader will be distracted.</p>
                                <div className="numberimg">
                                    <Image src={Two} alt="Two" />
                                </div>
                            </div>
                        </div>
                        <div className="col-lg-3 col-md-6 col-sm-6">
                            <div className={styles["getsolution-list"]}>
                                <Image src={Calandericon} alt="calandericon" className='geticon-set' />
                                <h5>Schedule Appointment</h5>
                                <p>It is a long established fact that a reader will be distracted.</p>
                                <div className="numberimg">
                                    <Image src={Three} alt="Three" />
                                </div>
                            </div>
                        </div>
                        <div className="col-lg-3 col-md-6 col-sm-6">
                            <div className={styles["getsolution-list"]}>
                                <Image src={Checkedicon} alt="checkedicon" className='geticon-set' />
                                <h5>Get your Solution</h5>
                                <p>It is a long established fact that a reader will be distracted.</p>
                                <div className="numberimg">
                                    <Image src={Four} alt="Four" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </>
    )
}

export default EasySteps