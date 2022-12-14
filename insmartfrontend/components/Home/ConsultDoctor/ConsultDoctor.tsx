import Image from "next/image";
import { useEffect, useState } from "react";
import { Button, Row } from "react-bootstrap";
import { AiFillStar } from "react-icons/ai";
import { BsPatchCheckFill } from "react-icons/bs";
import { IoLocationSharp } from "react-icons/io5";
import Slider from "react-slick";
import { Doclist1, Doclist2, Doclist3, Doclist4 } from "../../../public/assets";
import { promotionalSelector } from "../../../store/home/promotionalSlice";
import styles from "../../../styles/Consultdoctor.module.css";
import { useAppSelector } from "../../../utils/hooks";

function ConsultDoctor() {

  const promotionals = useAppSelector(promotionalSelector);
  const [doctors, setDoctors] = useState([]);

  useEffect(() => {
    if (!!promotionals && promotionals.data.promotionals.length) {
      const speciality = promotionals.data.promotionals.filter((data) => data.promotionalType == 0);
      setDoctors(speciality[0].doctors);
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
      <div className={styles["topdoctor-cover"] + styles["ComArrowSlidercs"]}>
        <div className="container">
          <div
            className={styles["ComHomeTitle-cover"] + styles["topdoc-title"]}
          >
            <h2>Consult Our Top Doctors</h2>
            <p>
              We provide only verified and best specialist for your better
              health
            </p>
          </div>
          <div className={styles["doctorlist-set"]}>
            <Row>
              <Slider {...settings}>
                {/* {doctors.map((data1) => (
                  <>
                    <div className={styles["topdocbox-cover"]}>
                      <div className={styles["topdocimg-set"]}>
                        <Image src={Doclist1} alt="Doclist" />
                        <p>
                          <AiFillStar />
                          {data1.averageRating}
                        </p>
                      </div>
                      <div className={styles["docnamedet-set"]}>
                        <a href="javascript:;">
                          <h5>Dr. {data1.firstName} {data1?.lastName}</h5>
                          <p>Cardiologist | {data1?.yearsOfExperience} Years of Exp.</p>
                          <span>
                            <IoLocationSharp />
                            Ho Chi Minh City
                          </span>
                        </a>
                      </div>
                    </div>
                  </>
                ))} */}
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

export default ConsultDoctor;
