import React, { useEffect, useState } from "react";
import Slider from "react-slick";
import { Button, Row } from "react-bootstrap";
import CategoryCard from "../CategoryCard/CategoryCard";
import styles from "../../../styles/HealthConcern.module.css";
import { useAppSelector } from "../../../utils/hooks";
import { promotionalSelector } from "../../../store/home/promotionalSlice";

export default function HealthConcern() {
  const promotionals = useAppSelector(promotionalSelector);
  const [specialities, setSpecialities] = useState([]);

  useEffect(() => {
    if (!!promotionals && promotionals.data.promotionals.length) {
      const speciality = promotionals.data.promotionals.filter((data) => data.promotionalType == 2);
      setSpecialities(speciality[0].specialities);
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
        breakpoint: 767,
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
  return (
    <>
      <div className={styles["C-cover"] + styles["ComArrowSlidercs"]}>
        <div className="container">
          <div className="ComHomeTitle-cover healthcon-title">
            <h2>Consult Best Doctors Online For Any Health Concern</h2>
            <p>
              We provide only verified and best specialist for your better
              health
            </p>
          </div>
          <div className="healthconlist-set">
            <Row>
              <Slider {...settings}>
                {
                  specialities.map((data1) =>  (<><CategoryCard description={data1?.description} name = {data1?.name} imagePath={data1?.imagePath}/></>))
                }
              </Slider>
              <div className="viewall-btn">
                <Button>View All</Button>
              </div>
            </Row>
          </div>
        </div>
      </div>
    </>
  );
}