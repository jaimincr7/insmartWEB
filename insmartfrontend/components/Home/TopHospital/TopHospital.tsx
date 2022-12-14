import { Button } from "react-bootstrap";
import { FaUserMd } from "react-icons/fa";
import { IoLocationSharp } from "react-icons/io5";
import Slider from "react-slick";
import {
  Tophospital1,
} from "../../../public/assets";
import styles from "../../../styles/Tophospital.module.css";

import Image from "next/image";
import { Row } from "react-bootstrap";
import { useAppSelector } from "../../../utils/hooks";
import { promotionalSelector } from "../../../store/home/promotionalSlice";
import { useEffect, useState } from "react";

export default function Tophospital() {

  const promotionals = useAppSelector(promotionalSelector);
  const [hospitals, setHospitals] = useState([]);

  useEffect(() => {
    if (!!promotionals && promotionals.data.promotionals.length) {
      const speciality = promotionals.data.promotionals.filter((data) => data.promotionalType == 1);
      setHospitals(speciality[0].hospitals);
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
  return (
    <>
      <div className={styles["tophospital-cover"] + styles["ComArrowSlidercs"]}>
        <div className="container">
          <div
            className={
              styles["ComHomeTitle-cover"] + styles["tophospital-title"]
            }
          >
            <h2>Consult Our Top Hospitals</h2>
            <p>
              We provide only verified and best specialist for your better
              health
            </p>
          </div>
          <div className={styles["hospitallist-set"]}>
            <Row>
              <Slider {...settings}>
                {/* {hospitals.map((data1) => (<>
                  <div className={styles["tophospbox-cover"]}>
                    <div className={styles["tophospimg-set"]}>
                      <Image src={Tophospital1} alt="Hospitallist" />
                    </div>
                    <div className={styles["hospnamedet-set"]}>
                      <a href="javascript:;">
                        <h5>{data1?.name}</h5>
                        <p>
                          <IoLocationSharp />
                          Ho Chi Minh City
                        </p>
                        <span>
                          <FaUserMd />
                          25 Doctors
                        </span>
                      </a>
                    </div>
                  </div>
                </>))} */}
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