import React, { useEffect, useState } from 'react';
import styles from "../../styles/SymptomsList/SymptomsList.module.css";
import { Row } from 'react-bootstrap';
import Breadcrumbs from '../../components/Common/Breadcrumbs';
import SymptomsCard from '../../components/Common/Cards/symptoms/SymptomsCard';
import { useAppDispatch, useAppSelector } from '../../utils/hooks';
import { getAllSymptomsListAction, symptomsListSelector } from '../../store/symptomsList/symptomsListSlice';

export default function SymptomsList() {

    const dispatch = useAppDispatch();
    const symptoms = useAppSelector(symptomsListSelector);
    const [symptomsData, setSymptoms] = useState([]);

    useEffect(() => {
        dispatch(getAllSymptomsListAction());
    }, []);

    useEffect(() => {
        if (!!symptoms && symptoms.data.symptomsList.length) {
            setSymptoms(symptoms.data.symptomsList);
        }
    }, [symptoms.data.symptomsList]);

    return (
        <>
            <Breadcrumbs />

            <div className={styles["SymptomsCov"]}>
                <div className="container">
                    <div className={styles["SymptomsTitle"]}>
                        <h1>Speciality</h1>
                    </div>
                    <Row>
                        <div className={styles["SymptomsMain"]}>
                            {symptomsData.map((data1) => (<>
                                <div className={styles["SymptomsIner"]}>
                                    <SymptomsCard name={data1.name} description={data1.description}/>
                                </div>
                            </>))}

                        </div>
                    </Row>
                </div>
            </div>

        </>
    )
}
