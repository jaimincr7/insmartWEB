import React from 'react';
import './benefits.css';
import "slick-carousel/slick/slick.css";
import "slick-carousel/slick/slick-theme.css";

import { AiOutlineCheck } from "react-icons/ai";
import { Benefitsimg } from '../../../public/assets';

function Benefits() {
    var settings = {
        dots: false,
        infinite: false,
        speed: 500,
        slidesToShow: 1,
        slidesToScroll: 1
    };
    return (
        <>
            <div className="benefitcon-set">
                <div className="container">
                    <div className="row">
                        <div className="col-md-6">
                            <div className="benefitcon-left">
                                {/* <img src={Benefitsimg} alt="benefitsimg" /> */}
                            </div>
                        </div>

                        <div className="col-md-6">
                            <div className="benefitcon-right">
                                <h2>Benefits of Online Consultation</h2>
                                <div className="ourbenefit-set">
                                    <AiOutlineCheck />
                                    <div className="ourbenefit-text">
                                        <h5>Consult Top Doctors 24x7</h5>
                                        <p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.</p>
                                    </div>
                                </div>
                                <div className="ourbenefit-set">
                                    <AiOutlineCheck />
                                    <div className="ourbenefit-text">
                                        <h5>Convenient and Easy</h5>
                                        <p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.</p>
                                    </div>
                                </div>
                                <div className="ourbenefit-set">
                                    <AiOutlineCheck />
                                    <div className="ourbenefit-text">
                                        <h5>100% Safe Consultations</h5>
                                        <p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.</p>
                                    </div>
                                </div>
                                <div className="ourbenefit-set">
                                    <AiOutlineCheck />
                                    <div className="ourbenefit-text">
                                        <h5>Similar Clinic Experiance</h5>
                                        <p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </>
    )
}

export default Benefits