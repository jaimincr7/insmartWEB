import Image from "next/image";
import { Brain } from "../../../public/assets";
import styles from "../../../styles/CategoryCard.module.css";

export default function CategoryCard(props) {
  return (
    <>
      <div className={styles["concernbox-cover"]}>
        <Image src={Brain} alt="Brain" />
        <h5>{props.name}</h5>
        <p>
          {props.description}
        </p>
        <a >Explore Now</a>
      </div>
    </>
  );
}