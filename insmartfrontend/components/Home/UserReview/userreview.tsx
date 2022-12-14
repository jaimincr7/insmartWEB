import React, { useEffect, useState } from 'react';
import { AiFillStar } from "react-icons/ai";
import Slider from "react-slick";
import "slick-carousel/slick/slick.css";
import "slick-carousel/slick/slick-theme.css";
import { Row } from 'react-bootstrap';
import { Vectorimage } from '../../../public/assets';
import Image from "next/image";
import styles from "../../../styles/Home/UserReview-Style.module.css";
import { useAppSelector } from '../../../utils/hooks';
import { testimonialSelector } from '../../../store/home/testimonialSlice';

export default function userreview() {

    const testimonials = useAppSelector(testimonialSelector);
    const [testimonialsData, setTestimonials] = useState([]);

    useEffect(() => {
        if (!!testimonials && testimonials.data.testimonials.length) {
            setTestimonials(testimonials.data.testimonials);
        }
    }, [testimonials.data.testimonials]);

    var settings = {
        dots: false,
        infinite: false,
        speed: 500,
        slidesToShow: 3,
        slidesToScroll: 1,
        responsive: [
            {
                breakpoint: 767,
                settings: {
                    slidesToShow: 2,
                }
            },
            {
                breakpoint: 650,
                settings: {
                    slidesToShow: 2,
                }
            },
            {
                breakpoint: 414,
                settings: {
                    slidesToShow: 1.5,
                }
            },
            {
                breakpoint: 375,
                settings: {
                    slidesToShow: 1,
                }
            }
        ]
    };
    
    return (
        <>
            <div className="toppatients-cover ComArrowSlidercs">
                <div className="container">
                    <div className="ComHomeTitle-cover toppatient-title">
                        <h2>Patients say about us</h2>
                    </div>
                    <div className="patientlist-set">
                        <Row>
                            <Slider {...settings}>
                                {testimonialsData.map((data1) => (
                                    <>
                                        <div className={styles["toppatientbox-cover"]}>
                                            <h3>{data1.subject}</h3>
                                            <p>{data1.description}</p>
                                            <h5>{data1.name}</h5>
                                            <div className="patientrate-set">
                                                <AiFillStar />{data1.ratings}
                                            </div>

                                            <Image src={Vectorimage} alt="Vectorimage" />
                                        </div>
                                    </>
                                ))}
                            </Slider>
                        </Row>
                    </div>
                </div>
            </div>
        </>
    )
}