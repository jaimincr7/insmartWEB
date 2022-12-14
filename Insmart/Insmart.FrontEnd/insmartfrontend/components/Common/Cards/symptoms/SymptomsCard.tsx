import React from 'react';
import styles from "../../../../styles/SymptomsList/SymptomsCard.module.css";
import Image from "next/image";
import { HiArrowNarrowRight } from "react-icons/hi";
import { Consultationimg1, } from '../../../../public/assets';

export default function SymptomsCard(props) {
    return (
        <>
            <div className='topcosultbox-cover'>
                <div className="consultnamedet-set">
                    <Image src={Consultationimg1} alt="Consultation" />
                    <div className="consultdata-set">
                        <h5>{props.name}</h5>
                        <p>{props.description}</p>
                        <a href='javascript:;'>Book Appointment <HiArrowNarrowRight /></a>
                    </div>
                </div>
            </div>
            {/* <div className='topcosultbox-cover'>
                <div className="consultnamedet-set">
                    <img src={Consultationimg2} alt="Consultation" />
                    <div className="consultdata-set">
                        <h5>Cardiology / Heart disease</h5>
                        <p>Get guidance on eating right, weight management and sports</p>
                        <a href='javascript:;'>Book Appointment <HiArrowNarrowRight /></a>
                    </div>
                </div>
            </div>
            <div className='topcosultbox-cover'>
                <div className="consultnamedet-set">
                    <img src={Consultationimg3} alt="Consultation" />
                    <div className="consultdata-set">
                        <h5>Ear Nose Throat</h5>
                        <p>Get guidance on eating right, weight management and sports</p>
                        <a href='javascript:;'>Book Appointment <HiArrowNarrowRight /></a>
                    </div>
                </div>
            </div>
            <div className='topcosultbox-cover'>
                <div className="consultnamedet-set">
                    <img src={Consultationimg4} alt="Consultation" />
                    <div className="consultdata-set">
                        <h5>Cardiology / Heart disease</h5>
                        <p>Get guidance on eating right, weight management and sports</p>
                        <a href='javascript:;'>Book Appointment <HiArrowNarrowRight /></a>
                    </div>
                </div>
            </div>
            <div className='topcosultbox-cover'>
                <div className="consultnamedet-set">
                    <img src={Consultationimg1} alt="Consultation" />
                    <div className="consultdata-set">
                        <h5>Cardiology / Heart disease</h5>
                        <p>Get guidance on eating right, weight management and sports</p>
                        <a href='javascript:;'>Book Appointment <HiArrowNarrowRight /></a>
                    </div>
                </div>
            </div> */}
        </>
    )
}