import React, { useEffect, useState } from "react";
import styles from "../../../styles/Homesymptomslist.module.css";
import Slider from "react-slick";
import "slick-carousel/slick/slick.css";
import "slick-carousel/slick/slick-theme.css";
import { Button } from "react-bootstrap";
import { Row } from "react-bootstrap";
import Image from "next/image";
import { Consultationimg1 } from "../../../public/assets";
import { HiArrowNarrowRight } from "react-icons/hi";
import { useAppSelector } from "../../../utils/hooks";
import { promotionalSelector } from "../../../store/home/promotionalSlice";

export default function HomeSymptomsList() {

  const promotionals = useAppSelector(promotionalSelector);
  const [symptoms, setSymptoms] = useState([]);

  useEffect(() => {
    if (!!promotionals && promotionals.data.promotionals.length) {
      const speciality = promotionals.data.promotionals.filter((data) => data.promotionalType == 3);
      setSymptoms(speciality[0].symptoms);
    }
  }, [promotionals.data.promotionals]);
  
  var settings = {
    dots: false,
    infinite: false,
    speed: 500,
    slidesToShow: 4,
    slidesToScroll: 1,
    responsive: [
      {
        breakpoint: 850,
        settings: {
          slidesToShow: 3,
        },
      },
      {
        breakpoint: 650,
        settings: {
          slidesToShow: 2,
        },
      },
      {
        breakpoint: 414,
        settings: {
          slidesToShow: 1.5,
        },
      },
      {
        breakpoint: 375,
        settings: {
          slidesToShow: 1,
        },
      },
    ],
  };

  const renderCard = () => {
    return (
      <div className={styles["topcosultbox-cover"]}>
        <div className={styles["consultnamedet-set"]}>
          <Image src={Consultationimg1} alt="Consultation" />
          <div className={styles["consultdata-set"]}>
            <h5>Cardiology / Heart disease</h5>
            <p>Get guidance on eating right, weight management and sports</p>
            <a href="javascript:;">
              Book Appointment <HiArrowNarrowRight />
            </a>
          </div>
        </div>
      </div>
    );
  };
  return (
    <>
      <div className={styles["topconsult-cover"] + styles["ComArrowSlidercs"]}>
        <div className="container">
          <div
            className={
              styles["ComHomeTitle-cover"] + styles["topconsult-title"]
            }
          >
            <h2>Book an appointment for an Hospital consultation</h2>
            <p>Consult a doctor online for any health issue</p>
          </div>
          <div className={styles["consultlist-set"]}>
            <Row>
              <Slider {...settings}>
                {renderCard()}
                {renderCard()}
                {renderCard()}
                {renderCard()}
                {renderCard()}
              </Slider>
              <div className={styles["viewall-btn"]}>
                <Button>View All</Button>
              </div>
            </Row>
          </div>
        </div>
      </div>
    </>
  );
}