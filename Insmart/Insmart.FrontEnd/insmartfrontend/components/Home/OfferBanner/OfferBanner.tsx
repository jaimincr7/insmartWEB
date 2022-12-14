import React from "react";
import styles from "../../styles/OfferBanner.module.css";
import Slider from "react-slick";
import Image from "next/image";
import { Offerbanner } from "../../../public/assets";

function OfferBanner() {
  var settings = {
    dots: true,
    infinite: false,
    speed: 500,
    slidesToShow: 1,
    slidesToScroll: 1,
  };
  return (
    <>
      <div className={styles["offerban-cover"]}>
        <Slider {...settings}>
          <div className={styles["offerban-set"]}>
            <a href="javascript:;">
              <Image src={Offerbanner} alt="Offer banner" />
            </a>
          </div>
          <div className={styles["offerban-set"]}>
            <a href="javascript:;">
              <Image src={Offerbanner} alt="Offer banner" />
            </a>
          </div>
          <div className={styles["offerban-set"]}>
            <a href="javascript:;">
              <Image src={Offerbanner} alt="Offer banner" />
            </a>
          </div>
        </Slider>
      </div>
    </>
  );
}

export default OfferBanner;
