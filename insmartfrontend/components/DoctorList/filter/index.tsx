import React from 'react'
import Image from "next/image";
import styles from "../../../styles/DoctorList/FilterModel-Style.module.css";
import Modal from 'react-bootstrap/Modal';
import Nav from 'react-bootstrap/Nav';
import Tab from 'react-bootstrap/Tab';
import { Button } from 'react-bootstrap';
import Form from 'react-bootstrap/Form';
import { Hospitallogo1 , Hospitallogo2, Hospitallogo3, Hospitallogo4 } from '../../../public/assets';

function FilterModel(props: { show: boolean, onHide: any }) {
    return (
        <Modal
            {...props}
            backdrop="static"
            keyboard={false}
            centered
            dialogClassName="modal-lg filtermodel-cover"
            className='mainmodalfltcov'
        >
            <Modal.Header closeButton>

            </Modal.Header>
            <Modal.Body>
                <Tab.Container id="left-tabs-example" defaultActiveKey="hospital">
                    <div className="tabnavbar-set">
                        <Nav variant="pills">
                            <Nav.Item>
                                <Nav.Link eventKey="hospital">Hospital Group</Nav.Link>
                            </Nav.Item>
                            <Nav.Item>
                                <Nav.Link eventKey="experience">Experience</Nav.Link>
                            </Nav.Item>
                            <Nav.Item>
                                <Nav.Link eventKey="gender">Gender</Nav.Link>
                            </Nav.Item>
                            <Nav.Item>
                                <Nav.Link eventKey="language">Language</Nav.Link>
                            </Nav.Item>
                            <Nav.Item>
                                <Nav.Link eventKey="speciality">Speciality</Nav.Link>
                            </Nav.Item>
                            <Nav.Item>
                                <Nav.Link eventKey="symptoms">Symptoms</Nav.Link>
                            </Nav.Item>
                        </Nav>
                    </div>
                    <Tab.Content>
                        <Tab.Pane eventKey="hospital">
                            <div className="hospitallist-cover">
                                <div className="hospitaldet-set">
                                    <div className="hospitaldet-cover">
                                        <label htmlFor="logo1" className='checkbox-label'>
                                            <Image src={Hospitallogo1} alt="Hospitallogo" />
                                            <p>FV Hospital</p>
                                        </label>
                                        <input id="logo1" type="checkbox" className="checkboxField" />
                                    </div>
                                </div>
                                <div className="hospitaldet-set">
                                    <div className="hospitaldet-cover">
                                        <label htmlFor="logo2" className='checkbox-label'>
                                            <Image src={Hospitallogo2} alt="Hospitallogo" />
                                            <p>Pharmedi Hospital</p>
                                        </label>
                                        <input id="logo2" type="checkbox" className="checkboxField" />
                                    </div>
                                </div>
                                <div className="hospitaldet-set">
                                    <div className="hospitaldet-cover">
                                        <label htmlFor="logo3" className='checkbox-label'>
                                            <Image src={Hospitallogo3} alt="Hospitallogo" />
                                            <p>Vietnam National Heart Institute</p>
                                        </label>
                                        <input id="logo3" type="checkbox" className="checkboxField" />
                                    </div>
                                </div>
                                <div className="hospitaldet-set">
                                    <div className="hospitaldet-cover">
                                        <label htmlFor="logo4" className='checkbox-label'>
                                            <Image src={Hospitallogo4} alt="Hospitallogo" />
                                            <p>City International Hospital</p>
                                        </label>
                                        <input id="logo4" type="checkbox" className="checkboxField" />
                                    </div>
                                </div>
                                <div className="hospitaldet-set">
                                    <div className="hospitaldet-cover">
                                        <label htmlFor="logo5" className='checkbox-label'>
                                            <Image src={Hospitallogo3} alt="Hospitallogo" />
                                            <p>Vietnam National Heart Institute</p>
                                        </label>
                                        <input id="logo5" type="checkbox" className="checkboxField" />
                                    </div>
                                </div>
                                <div className="hospitaldet-set">
                                    <div className="hospitaldet-cover">
                                        <label htmlFor="logo6" className='checkbox-label'>
                                            <Image src={Hospitallogo4} alt="Hospitallogo" />
                                            <p>City International Hospital</p>
                                        </label>
                                        <input id="logo6" type="checkbox" className="checkboxField" />
                                    </div>
                                </div>
                                <div className="hospitaldet-set">
                                    <div className="hospitaldet-cover">
                                        <label htmlFor="logo7" className='checkbox-label'>
                                            <Image src={Hospitallogo1} alt="Hospitallogo" />
                                            <p>FV Hospital</p>
                                        </label>
                                        <input id="logo7" type="checkbox" className="checkboxField" />
                                    </div>
                                </div>
                                <div className="hospitaldet-set">
                                    <div className="hospitaldet-cover">
                                        <label htmlFor="logo8" className='checkbox-label'>
                                            <Image src={Hospitallogo2} alt="Hospitallogo" />
                                            <p>Pharmedi Hospital</p>
                                        </label>
                                        <input id="logo8" type="checkbox" className="checkboxField" />
                                    </div>
                                </div>

                                <div className="applyfilter-cover">
                                    <Button className='clearfilter'>Clear Filters</Button>
                                    <Button className='applyfilter'>Apply Filters</Button>
                                </div>
                            </div>
                        </Tab.Pane>
                        <Tab.Pane eventKey="experience">
                            <div className="experience-filter">
                                {['checkbox'].map((type: any) => (
                                    <div key={`inline-${type}`} className="custchbox-main">
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="0 - 5 Years"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-1`}
                                            />
                                        </div>
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="6 - 10 Years"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-2`}
                                            />
                                        </div>
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="11 - 15 Years"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-3`}
                                            />
                                        </div>
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="16+ Years"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-4`}
                                            />
                                        </div>
                                    </div>
                                ))}

                                <div className="applyfilter-cover">
                                    <Button className='clearfilter'>Clear Filters</Button>
                                    <Button className='applyfilter'>Apply Filters</Button>
                                </div>
                            </div>
                        </Tab.Pane>
                        <Tab.Pane eventKey="gender">
                            <div className="experience-filter">
                                {['radio'].map((type: any) => (
                                    <div key={`inline-${type}`} className="custchbox-main">
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="Male"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-1`}
                                            />
                                        </div>
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="Female"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-2`}
                                            />
                                        </div>
                                    </div>
                                ))}
                                <div className="applyfilter-cover">
                                    <Button className='clearfilter'>Clear Filters</Button>
                                    <Button className='applyfilter'>Apply Filters</Button>
                                </div>
                            </div>

                        </Tab.Pane>
                        <Tab.Pane eventKey="language">
                            <div className="experience-filter">
                                {['checkbox'].map((type: any) => (
                                    <div key={`inline-${type}`} className="custchbox-main">
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="Viet"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-1`}
                                            />
                                        </div>
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="Tay"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-2`}
                                            />
                                        </div>
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="Mon"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-3`}
                                            />
                                        </div>
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="Hmong"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-4`}
                                            />
                                        </div>
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="Kadai"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-5`}
                                            />
                                        </div>
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="Tibeto"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-6`}
                                            />
                                        </div>
                                    </div>
                                ))}
                                <div className="applyfilter-cover">
                                    <Button className='clearfilter'>Clear Filters</Button>
                                    <Button className='applyfilter'>Apply Filters</Button>
                                </div>
                            </div>
                        </Tab.Pane>
                        <Tab.Pane eventKey="speciality">
                            <div className="experience-filter">
                                {['checkbox'].map((type: any) => (
                                    <div key={`inline-${type}`} className="custchbox-main">
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="Cardio-Oncology"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-1`}
                                            />
                                        </div>
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="Cardiac Sarcoidosis"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-2`}
                                            />
                                        </div>
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="Pediatric Heart Care"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-3`}
                                            />
                                        </div>
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="Cardiac Imaging"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-4`}
                                            />
                                        </div>
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="Cardiac Surgery"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-5`}
                                            />
                                        </div>
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="Vascular Surgery"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-6`}
                                            />
                                        </div>
                                    </div>
                                ))}
                                <div className="applyfilter-cover">
                                    <Button className='clearfilter'>Clear Filters</Button>
                                    <Button className='applyfilter'>Apply Filters</Button>
                                </div>
                            </div>
                        </Tab.Pane>
                        <Tab.Pane eventKey="symptoms">
                            <div className="experience-filter">
                                {['checkbox'].map((type: any) => (
                                    <div key={`inline-${type}`} className="custchbox-main">
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="Chest pain"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-1`}
                                            />
                                        </div>
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="Chest pressure"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-2`}
                                            />
                                        </div>
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="Chest discomfort"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-3`}
                                            />
                                        </div>
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="Pain in the neck"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-4`}
                                            />
                                        </div>
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="Shortness of breath"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-5`}
                                            />
                                        </div>
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="Weakness"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-6`}
                                            />
                                        </div>
                                        <div className="experiencedet-set">
                                            <Form.Check
                                                inline
                                                label="Coldness"
                                                name="group1"
                                                type={type}
                                                id={`inline-${type}-7`}
                                            />
                                        </div>
                                    </div>
                                ))}
                                <div className="applyfilter-cover">
                                    <Button className='clearfilter'>Clear Filters</Button>
                                    <Button className='applyfilter'>Apply Filters</Button>
                                </div>
                            </div>
                        </Tab.Pane>
                    </Tab.Content>
                </Tab.Container>
            </Modal.Body>
        </Modal>
    )
}

export default FilterModel