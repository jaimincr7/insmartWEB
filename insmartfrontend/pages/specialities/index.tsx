import React, { useEffect, useState } from 'react';
import { Row } from 'react-bootstrap';
import Breadcrumbs from '../../components/Common/Breadcrumbs';
import CategoryCard from '../../components/Home/CategoryCard/CategoryCard';
import { getAllSpecialitiesListAction, specialitiesListSelector } from '../../store/specialitiesList/specialitiesListSlice';
import styles from "../../styles/SpecialitiesList/SpecialityListStyle.module.css";
import { useAppDispatch, useAppSelector } from '../../utils/hooks';

export default function Specialitylist() {
    const dispatch = useAppDispatch();
    const specialities = useAppSelector(specialitiesListSelector);
    const [specialitiesData, setSpecialities] = useState([]);

    useEffect(() => {
        dispatch(getAllSpecialitiesListAction());
    },[]);

    useEffect(() => {
        if (!!specialities && specialities.data.specialitiesList.length) {
            setSpecialities(specialities.data.specialitiesList);
        }
    }, [specialities.data.specialitiesList]);

    return (
        <>
            <Breadcrumbs />

            <div className={styles["specialitymaiCov"]}>
                <div className="container">
                    <div className={styles["specialitymaTitle"]}>
                        <h1>Speciality</h1>
                    </div>
                    <Row>
                        <div className={styles["specialitymaMain"]}>
                            {specialitiesData.map((data1) => (<>
                                <div className={styles["specialitymaIner"]}>
                                    <CategoryCard description={data1?.description} name = {data1?.name} imagePath={data1?.imagePath}/>
                                </div>
                            </>))}

                        </div>
                    </Row>
                </div>
            </div>
        </>
    )
}