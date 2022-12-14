import Image from "next/image";
import React, { useEffect, useState } from "react";
import Slider from "react-slick";
import { Headerbannermob, Headerbanner } from "../../../public/assets";
import { bannerSelector } from "../../../store/home/bannerSlice";
import styles from "../../../styles/BannerCard.module.css";
import { useAppSelector } from "../../../utils/hooks";
export default function BannerCard() {

  const banners = useAppSelector(bannerSelector);
  const [bannersData, setbanners] = useState([]);

  useEffect(() => {
    if (!!banners && banners.data.banners.length) {
      setbanners(banners.data.banners);
    }
  }, [banners.data.banners]);

  const settings = {
    dots: false,
    infinite: false,
    speed: 500,
    slidesToShow: 1,
    slidesToScroll: 1,
  };
  return (
    <>
      {/* Desktop Banner Start */}
      <div className={styles["desktopban-set"]}>
        <Slider {...settings}>
          {bannersData.map((data1) => (
            <>
              <div className={styles["headerban-set"]}>
                {/* <Image src={data1.bannerPath} alt="Header banner" width={50} height={50}/> */}
              </div>
            </>
          ))}

        </Slider>
      </div>
      {/* Desktop Banner End */}

      {/* Mobile Banner Start */}
      {/* <div className={styles["mobileban-set"]}>
        <Slider {...settings}>
          <div className={styles["headerban-set"]}>
            <Image src={Headerbannermob} alt="Header banner" />
          </div>
          <div className={styles["headerban-set"]}>
            <Image src={Headerbannermob} alt="Header banner" />
          </div>
          <div className={styles["headerban-set"]}>
            <Image src={Headerbannermob} alt="Header banner" />
          </div>
        </Slider>
      </div> */}
      {/* Mobile Banner End */}
    </>
  );
}