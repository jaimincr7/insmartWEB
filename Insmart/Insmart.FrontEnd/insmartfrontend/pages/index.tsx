import Image from "next/image";
import { Button } from "react-bootstrap";
import BannerCard from "../components/Home/BannerCard/BannerCard";
import styles from "../styles/Home.module.css";
import { Referandearn } from "../public/assets";
import ConsultDoctor from "../components/Home/ConsultDoctor/ConsultDoctor";
import HomeSymptomsList from "../components/Home/Symptoms/SymptomsList";
import HealthConcern from "../components/Home/HealthConcern/HealthConcern";
import TopHospital from "../components/Home/TopHospital/TopHospital";
import { createContext, useEffect, useState } from "react";
import { useAppDispatch, useAppSelector } from "../utils/hooks";
import { getAllPromotionalAction, promotionalSelector } from "../store/home/promotionalSlice";
// import Benefits from "../components/Home/Benefits/Benefits";
import EasySteps from "../components/Home/EasySteps/EasySteps";
import JoinOurTeam from "../components/Home/JoinOurTeam/JoinOurTeam";
import Userreview from "../components/Home/UserReview/userreview";
import Blog from "../components/Home/Blog/blog";
import Appsection from "../components/Common/Appsection/appsection";
import { getAllTestimonialsAction } from "../store/home/testimonialSlice";
import { getAllBannersAction } from "../store/home/bannerSlice";

export default function Home() {
  const DataContext = createContext(null);
  const [ rerender, setRerender ] = useState(false);
  const dispatch = useAppDispatch();
  const promotionals = useAppSelector(promotionalSelector);

  useEffect(() => {
    dispatch(getAllPromotionalAction());
    dispatch(getAllTestimonialsAction());
    dispatch(getAllBannersAction());
  }, []);

  useEffect(() => {
    if (promotionals.data.promotionals.length > 0) 
      setRerender(true);
  }, [promotionals.data.promotionals]);

  return (
    <>
      <div className={styles["bannerdata-cover"]}>
      {rerender ? <BannerCard /> : (<></>)}
        <div className="container">
          <div className={styles["makeappoi-cover"]}>
            <div className={styles["makeappoi-set"]}>
              <div className={styles["appoifeild-set"]}>
                <label htmlFor="">Location</label>
                <input type="text" placeholder="Enter City/District" />
              </div>
              <div className={styles["appoifeild-set"]}>
                <label htmlFor="">Speciality</label>
                <input type="text" placeholder="Type to choose a speciality" />
              </div>
              <div className={styles["appoifeild-set"]}>
                <label htmlFor="">Doctor</label>
                <input type="text" placeholder="Type to choose a Doctor" />
              </div>
              <div className={styles["appoifeild-set"]}>
                <label htmlFor="">Hospital</label>
                <input type="text" placeholder="Type to choose a Hospital" />
              </div>
              <div className={styles["appoifeild-set"]}>
                <Button>Make Appointment</Button>
              </div>
            </div>
          </div>
        </div>
      </div>
      {rerender ? (<HealthConcern />) : (<></>)}
      {rerender ? <ConsultDoctor /> : (<></>)}
      {rerender ? <TopHospital /> : (<></>)}
      {rerender ? <HomeSymptomsList /> : (<></>)}
      {/* <Benefits /> */}
      <div className="offbanner-cover">
        <div className="container">
          <div className="row">
            <div className="col-md-6 offerban-det">
              {/* <OfferBanner />{" "} */}
            </div>

            <div className="col-md-6">
              <div className="referearn-cover">
                <a href="javascript:;">
                  <Image src={Referandearn} alt="referandearn" />
                </a>
              </div>
            </div>
          </div>
        </div>
      </div>

      <EasySteps />

      <JoinOurTeam />

      <Userreview />

      <Blog />

      <Appsection />

    </>
  );
}
