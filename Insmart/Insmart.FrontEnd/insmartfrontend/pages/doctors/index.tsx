import React, { useState } from 'react';
import styles from "../../styles/DoctorList/DoctorList.module.css";
import { TiLocation } from "react-icons/ti";
import { IoIosArrowDown } from "react-icons/io";
import { BiSearch, BiSort } from "react-icons/bi";
import { FaFilter } from "react-icons/fa";
import { Button } from 'react-bootstrap';
import Form from 'react-bootstrap/Form';
import Select from 'react-select';
import makeAnimated from 'react-select/animated';
import Appsection from '../../components/Common/Appsection/appsection';
import DoctorsList from '../../components/DoctorList';
import FilterModel from '../../components/DoctorList/filter';
import Breadcrumbs from '../../components/Common/Breadcrumbs';

function DoctorList() {

    const [filtermodel, setShowftr] = useState(false);
    const handleFiltermodel = () => setShowftr(true);
    const handleClosedet = () => setShowftr(false);

    const animatedComponents = makeAnimated();
    const sortby = [
        { value: '1', label: 'Rating High to low' },
        { value: '2', label: 'Rating Low to high' }
    ]

    return (
        <>
            <FilterModel show={filtermodel} onHide={() => handleClosedet()} />

            <Breadcrumbs />

            <div className="container">
                <div className="doclist-title">
                    <h1>Consult Best Cardiologist in Ho Chi Minh</h1>
                </div>

                <div className="searchcitydoc-cover">
                    <div className="searchbar-left">
                        <TiLocation />
                        <input type="text" placeholder='Search Cities/District' />
                        <div className="downarrow-set">
                            <IoIosArrowDown />
                        </div>
                    </div>
                    <div className="searchbar-right">
                        <BiSearch />
                        <input type="text" placeholder='Search doctor' />
                    </div>
                </div>
            </div>
            <div className="container">
                <div className={styles["filterbox-cover"]}>
                    <div className={styles["sortby-filter"]}>
                        <BiSort />
                        <p>Sort By:</p>
                        <div className={styles["selectsortbycov"]}>
                            <Select
                                components={animatedComponents}
                                classNamePrefix="react-select"
                                options={sortby}
                                defaultValue={sortby[0]}
                            />
                        </div>
                    </div>
                    <div className={styles["consult-filter"]}>
                        {['checkbox'].map((type: any) => (
                            <div key={`inline-${type}`} className="custchbox-main">
                                <div className={styles["consultbox-set"]}>
                                    <Form.Check
                                        inline
                                        label="Home Visit"
                                        name="group1"
                                        type={type}
                                        id={`inline-${type}-1`}
                                    />
                                </div>
                                <div className={styles["consultbox-set"]}>
                                    <Form.Check
                                        inline
                                        label="Video Consult"
                                        name="group1"
                                        type={type}
                                        id={`inline-${type}-2`}
                                    />
                                </div>
                                <div className={styles["consultbox-set"]}>
                                    <Form.Check
                                        inline
                                        label="Hospital Visit"
                                        name="group1"
                                        type={type}
                                        id={`inline-${type}-3`}
                                    />
                                </div>
                            </div>
                        ))}
                    </div>
                    <div className={styles["filter-sec"]}>
                        <Button onClick={handleFiltermodel} variant="link"><FaFilter />Filter</Button>
                    </div>
                </div>
            </div>

            <DoctorsList />

            <Appsection />
        </>
    )
}

export default DoctorList