import React from 'react';
import './bookappmodel-style.css';
import '../../../../assets/css/datetimeslot-style.css';
import Modal from 'react-bootstrap/Modal';
import { Nav, Tab } from 'react-bootstrap';
import { Noslotbook } from '../../../../assets';
import { Button } from 'react-bootstrap';
import Form from 'react-bootstrap/Form';

function RescheduleAppointment(props: { show: boolean, onHide: any }) {
    return (
        <>
            <Modal
                {...props}
                backdrop="static"
                keyboard={false}
                centered
                className='bookappointmodMain'
            >
                <Modal.Header closeButton>
                    <h5>Reschedule Appointment</h5>
                </Modal.Header>
                <Modal.Body>
                    <div className="bookapp-consult">
                        <div className="docbookapp-cover">
                            <div className="selectdaytext-set pt-0">
                                <h5 className='selectday-title'>Select a Day</h5>
                                <Tab.Container id="left-tabs-example" defaultActiveKey="first">
                                    <div className="bookaslotbox-set">
                                        <Nav variant="pills">
                                            <Nav.Item>
                                                <Nav.Link eventKey="first">22 <span>Fr</span></Nav.Link>
                                            </Nav.Item>
                                            <Nav.Item>
                                                <Nav.Link eventKey="second">23 <span>Sa</span></Nav.Link>
                                            </Nav.Item>
                                            <Nav.Item>
                                                <Nav.Link eventKey="third">24 <span>Su</span></Nav.Link>
                                            </Nav.Item>
                                            <Nav.Item>
                                                <Nav.Link eventKey="four">25 <span>Mo</span></Nav.Link>
                                            </Nav.Item>
                                            <Nav.Item>
                                                <Nav.Link eventKey="five">26 <span>Tu</span></Nav.Link>
                                            </Nav.Item>
                                            <Nav.Item>
                                                <Nav.Link eventKey="six">27 <span>We</span></Nav.Link>
                                            </Nav.Item>
                                            <Nav.Item>
                                                <Nav.Link eventKey="seven">28 <span>Th</span></Nav.Link>
                                            </Nav.Item>
                                        </Nav>
                                    </div>
                                    <h5 className="timesolttitle-set">Choose one of the available timeslot</h5>
                                    <Tab.Content>
                                        <Tab.Pane eventKey="first" className='timeslothg-set'>
                                            <div className="ourtimeing-solt">
                                                <div className="soltdayamount-set">
                                                    <p>Morning | <span>FV Hospital</span></p>
                                                    <h5><span className='CurrencyTagcl'>₫</span> 50</h5>
                                                </div>
                                                <div className="time-slot">
                                                    <ul className="clearfix">
                                                        <li>
                                                            <a className="doc-slot-list timing" href="javascript:;">
                                                                <span>08:00 AM</span>
                                                            </a>
                                                        </li>
                                                        <li>
                                                            <a className="doc-slot-list timing slotactive" href="javascript:;">
                                                                <span>09:00 AM</span>
                                                            </a>
                                                        </li>
                                                        <li>
                                                            <a className="doc-slot-list timing" href="javascript:;">
                                                                <span>10:00 PM</span>
                                                            </a>
                                                        </li>
                                                        <li>
                                                            <a className="doc-slot-list timing" href="javascript:;">
                                                                <span>11:00 PM</span>
                                                            </a>
                                                        </li>
                                                    </ul>
                                                </div>
                                            </div>

                                            <div className="ourtimeing-solt">
                                                <div className="soltdayamount-set">
                                                    <p>Afternoon | <span>City Hospital</span></p>
                                                    <h5><span className='CurrencyTagcl'>₫</span> 40</h5>
                                                </div>
                                                <div className="time-slot">
                                                    <ul className="clearfix">
                                                        <li>
                                                            <a className="doc-slot-list timing" href="javascript:;">
                                                                <span>08:00 AM</span>
                                                            </a>
                                                        </li>
                                                        <li>
                                                            <a className="doc-slot-list timing" href="javascript:;">
                                                                <span>09:00 AM</span>
                                                            </a>
                                                        </li>
                                                        <li>
                                                            <a className="doc-slot-list timing" href="javascript:;">
                                                                <span>10:00 PM</span>
                                                            </a>
                                                        </li>
                                                        <li>
                                                            <a className="doc-slot-list timing" href="javascript:;">
                                                                <span>11:00 PM</span>
                                                            </a>
                                                        </li>
                                                    </ul>
                                                </div>
                                            </div>
                                        </Tab.Pane>
                                        <Tab.Pane eventKey="second">
                                            <div className="ourtimeing-solt">
                                                <div className="soltdayamount-set">
                                                    <p>Morning | <span>FV Hospital</span></p>
                                                    <h5><span className='CurrencyTagcl'>₫</span> 50</h5>
                                                </div>
                                                <div className="time-slot">
                                                    <ul className="clearfix">
                                                        <li>
                                                            <a className="doc-slot-list timing" href="javascript:;">
                                                                <span>08:00 AM</span>
                                                            </a>
                                                        </li>
                                                        <li>
                                                            <a className="doc-slot-list timing slotactive" href="javascript:;">
                                                                <span>09:00 AM</span>
                                                            </a>
                                                        </li>
                                                    </ul>
                                                </div>
                                            </div>

                                            <div className="ourtimeing-solt">
                                                <div className="soltdayamount-set">
                                                    <p>Afternoon | <span>City Hospital</span></p>
                                                    <h5><span className='CurrencyTagcl'>₫</span> 40</h5>
                                                </div>
                                                <div className="time-slot">
                                                    <ul className="clearfix">
                                                        <li>
                                                            <a className="doc-slot-list timing" href="javascript:;">
                                                                <span>08:00 AM</span>
                                                            </a>
                                                        </li>
                                                    </ul>
                                                </div>
                                            </div>

                                        </Tab.Pane>
                                        <Tab.Pane eventKey="third">
                                            <div className="ourtimeing-solt">
                                                <div className="soltdayamount-set">
                                                    <p>Morning | <span>FV Hospital</span></p>
                                                    <h5><span className='CurrencyTagcl'>₫</span> 50</h5>
                                                </div>
                                                <div className="time-slot">
                                                    <ul className="clearfix">
                                                        <li>
                                                            <a className="doc-slot-list timing" href="javascript:;">
                                                                <span>08:00 AM</span>
                                                            </a>
                                                        </li>
                                                        <li>
                                                            <a className="doc-slot-list timing slotactive" href="javascript:;">
                                                                <span>09:00 AM</span>
                                                            </a>
                                                        </li>
                                                    </ul>
                                                </div>
                                            </div>

                                            <div className="ourtimeing-solt">
                                                <div className="soltdayamount-set">
                                                    <p>Afternoon | <span>City Hospital</span></p>
                                                    <h5><span className='CurrencyTagcl'>₫</span> 40</h5>
                                                </div>
                                                <div className="time-slot">
                                                    <ul className="clearfix">
                                                        <li>
                                                            <a className="doc-slot-list timing" href="javascript:;">
                                                                <span>08:00 AM</span>
                                                            </a>
                                                        </li>
                                                    </ul>
                                                </div>
                                            </div>
                                        </Tab.Pane>
                                        <Tab.Pane eventKey="four">
                                            <div className="ourtimeing-solt">
                                                <div className="soltdayamount-set">
                                                    <p>Morning | <span>FV Hospital</span></p>
                                                    <h5><span className='CurrencyTagcl'>₫</span> 50</h5>
                                                </div>
                                                <div className="time-slot">
                                                    <ul className="clearfix">
                                                        <li>
                                                            <a className="doc-slot-list timing" href="javascript:;">
                                                                <span>08:00 AM</span>
                                                            </a>
                                                        </li>
                                                        <li>
                                                            <a className="doc-slot-list timing slotactive" href="javascript:;">
                                                                <span>09:00 AM</span>
                                                            </a>
                                                        </li>
                                                    </ul>
                                                </div>
                                            </div>

                                            <div className="ourtimeing-solt">
                                                <div className="soltdayamount-set">
                                                    <p>Afternoon | <span>City Hospital</span></p>
                                                    <h5><span className='CurrencyTagcl'>₫</span> 40</h5>
                                                </div>
                                                <div className="time-slot">
                                                    <ul className="clearfix">
                                                        <li>
                                                            <a className="doc-slot-list timing" href="javascript:;">
                                                                <span>08:00 AM</span>
                                                            </a>
                                                        </li>
                                                    </ul>
                                                </div>
                                            </div>
                                        </Tab.Pane>
                                        <Tab.Pane eventKey="five">
                                            <div className="ourtimeing-solt">
                                                <div className="soltdayamount-set">
                                                    <p>Morning | <span>FV Hospital</span></p>
                                                    <h5><span className='CurrencyTagcl'>₫</span> 50</h5>
                                                </div>
                                                <div className="time-slot">
                                                    <ul className="clearfix">
                                                        <li>
                                                            <a className="doc-slot-list timing" href="javascript:;">
                                                                <span>08:00 AM</span>
                                                            </a>
                                                        </li>
                                                        <li>
                                                            <a className="doc-slot-list timing slotactive" href="javascript:;">
                                                                <span>09:00 AM</span>
                                                            </a>
                                                        </li>
                                                    </ul>
                                                </div>
                                            </div>

                                            <div className="ourtimeing-solt">
                                                <div className="soltdayamount-set">
                                                    <p>Afternoon | <span>City Hospital</span></p>
                                                    <h5><span className='CurrencyTagcl'>₫</span> 40</h5>
                                                </div>
                                                <div className="time-slot">
                                                    <ul className="clearfix">
                                                        <li>
                                                            <a className="doc-slot-list timing" href="javascript:;">
                                                                <span>08:00 AM</span>
                                                            </a>
                                                        </li>
                                                    </ul>
                                                </div>
                                            </div>
                                        </Tab.Pane>
                                        <Tab.Pane eventKey="six">
                                            <div className="ourtimeing-solt">
                                                <div className="soltdayamount-set">
                                                    <p>Morning | <span>FV Hospital</span></p>
                                                    <h5><span className='CurrencyTagcl'>₫</span> 50</h5>
                                                </div>
                                                <div className="time-slot">
                                                    <ul className="clearfix">
                                                        <li>
                                                            <a className="doc-slot-list timing" href="javascript:;">
                                                                <span>08:00 AM</span>
                                                            </a>
                                                        </li>
                                                        <li>
                                                            <a className="doc-slot-list timing slotactive" href="javascript:;">
                                                                <span>09:00 AM</span>
                                                            </a>
                                                        </li>
                                                    </ul>
                                                </div>
                                            </div>

                                            <div className="ourtimeing-solt">
                                                <div className="soltdayamount-set">
                                                    <p>Afternoon | <span>City Hospital</span></p>
                                                    <h5><span className='CurrencyTagcl'>₫</span> 40</h5>
                                                </div>
                                                <div className="time-slot">
                                                    <ul className="clearfix">
                                                        <li>
                                                            <a className="doc-slot-list timing" href="javascript:;">
                                                                <span>08:00 AM</span>
                                                            </a>
                                                        </li>
                                                    </ul>
                                                </div>
                                            </div>
                                        </Tab.Pane>
                                        <Tab.Pane eventKey="seven">
                                            <div className="ourtimeing-solt">
                                                <div className="soltdayamount-set">
                                                    <p>Morning | <span>FV Hospital</span></p>
                                                    <h5><span className='CurrencyTagcl'>₫</span> 50</h5>
                                                </div>
                                                <div className="time-slot">
                                                    <ul className="clearfix">
                                                        <li>
                                                            <a className="doc-slot-list timing" href="javascript:;">
                                                                <span>08:00 AM</span>
                                                            </a>
                                                        </li>
                                                        <li>
                                                            <a className="doc-slot-list timing slotactive" href="javascript:;">
                                                                <span>09:00 AM</span>
                                                            </a>
                                                        </li>
                                                    </ul>
                                                </div>
                                            </div>

                                            <div className="ourtimeing-solt">
                                                <div className="soltdayamount-set">
                                                    <p>Afternoon | <span>City Hospital</span></p>
                                                    <h5><span className='CurrencyTagcl'>₫</span> 40</h5>
                                                </div>
                                                <div className="time-slot">
                                                    <ul className="clearfix">
                                                        <li>
                                                            <a className="doc-slot-list timing" href="javascript:;">
                                                                <span>08:00 AM</span>
                                                            </a>
                                                        </li>
                                                    </ul>
                                                </div>
                                            </div>
                                        </Tab.Pane>
                                    </Tab.Content>
                                </Tab.Container>
                                <div className='remarappontdatamain'>
                                    <Form.Group className="FormInputcovermain" controlId="">
                                        <Form.Label>Remark*</Form.Label>
                                        <Form.Control type="" placeholder="Type remark here" />
                                    </Form.Group>
                                </div>
                                <div className="booknowappo-btn">
                                    <Button className='viewpro-btn'>Reschedule Appointment</Button>
                                </div>
                            </div>

                            <div className="noslotimg-set" style={{ display: 'none' }}>
                                <img src={Noslotbook} alt="Noslotbook" />
                                <p>No slots available for today</p>
                            </div>
                        </div>
                    </div>
                </Modal.Body>
            </Modal>

        </>
    )
}

export default RescheduleAppointment