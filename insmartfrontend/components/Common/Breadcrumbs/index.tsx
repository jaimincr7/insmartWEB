import React from 'react'
import styles from "../../../styles/BreadCrumbs-Style.module.css";
import { BiChevronRight } from "react-icons/bi";

function Breadcrumbs() {
  return (
    <div className="container">
        <div className={styles["breadcrumb-title"]}>
            <ul>
                <li><a >Home</a></li>
                <li><BiChevronRight /></li>
                <li><a >Doctor Listing</a></li>
            </ul>
        </div>
    </div>
  )
}

export default Breadcrumbs