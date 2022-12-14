import React, { useState } from 'react';
// import './blog-style.css';
//import { Blogimage1, Blogimage2, Blogimage3 } from '../../../assets';
// import { HiArrowNarrowRight } from "react-icons/hi";
import { Button } from 'react-bootstrap';
import Slider from "react-slick";
import "slick-carousel/slick/slick.css";
import "slick-carousel/slick/slick-theme.css";
// import BlogCard from '../../common/card/blogcard/BlogCard';
import { Row } from 'react-bootstrap';

function blog() {
    var settings = {
        dots: false,
        infinite: false,
        speed: 500,
        slidesToShow: 3,
        slidesToScroll: 1,
        responsive: [
            {
                breakpoint: 850,
                settings: {
                    slidesToShow: 3,
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
            <div className="tophealth-cover">
                <div className="container">
                    <div className="healthexp-title">
                        <h2>Read top articles from health experts</h2>
                    </div>
                    <div className="healthlist-set">
                        <Row>
                            <Slider {...settings}>

                                {/* <BlogCard /> */}

                                {/* <BlogCard /> */}

                                {/* <BlogCard /> */}

                                {/* <BlogCard /> */}

                            </Slider>
                        </Row>
                    </div>
                    <div className="viewall-btn">
                        <Button>View all articles</Button>
                    </div>
                </div>
            </div>
        </>
    )
}

export default blog