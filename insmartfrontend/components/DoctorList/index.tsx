import React, { useState } from 'react';
import styles from "../../styles/BookAppModel-Style.module.css";
import { AiFillStar } from "react-icons/ai";
import { HiLocationMarker } from "react-icons/hi";
import { GrLanguage } from "react-icons/gr";
import { MdVerified } from "react-icons/md";
import { BiChevronLeft, BiChevronRight } from "react-icons/bi";
import Image from "next/image";
import { Button } from 'react-bootstrap';
import { Doclist1, Doclist2, Doclist3 } from '../../public/assets';
import Bookappmodel from '../Common/Model/bookappointment/bookappmodel';

function DoctorsList() {
    const [bookappmodel, setShowftr] = useState(false);
    const handleBookappmodel = () => setShowftr(true);
    const handleClosedet = () => setShowftr(false);
    return (
        <div>
            <Bookappmodel show={bookappmodel} onHide={() => handleClosedet()} />
            <div className="container">
                <div className="doctorlist-cover">
                    <div className="row">

                        <div className="col-lg-4 col-md-6">
                            <div className="docdetlist-cover">
                                <div className="docdetlist-set">
                                    <div className="docdetname-set">
                                        <Image src={Doclist1} alt="Doclist" />
                                        <div className="docnameexp-set">
                                            <h5>Dr. Bruno Schaub<MdVerified /></h5>
                                            <p>Cardiologist</p>
                                            <h4>16 Years of Exp.</h4>
                                            <div className="docrate-set">
                                                <AiFillStar />
                                                <AiFillStar />
                                                <AiFillStar />
                                                <AiFillStar />
                                                <AiFillStar />
                                                <span>(58)</span>
                                            </div>
                                            <h6><HiLocationMarker />Ho Chi Minh City</h6>
                                        </div>
                                    </div>
                                    <div className="doclang-set">
                                        <p><GrLanguage />English, Viet, Tay, Mon, Hmong</p>
                                    </div>
                                </div>
                                <div className="viewprobookap-btn">
                                    <Button className='viewpro-btn'>View Profile</Button>
                                    <Button className='bookapp-btn' onClick={handleBookappmodel} variant="link">Book Appointment</Button>
                                </div>
                            </div>
                        </div>

                        <div className="col-lg-4 col-md-6">
                            <div className="docdetlist-cover">
                                <div className="docdetlist-set">
                                    <div className="docdetname-set">
                                        <Image src={Doclist2} alt="Doclist" />
                                        <div className="docnameexp-set">
                                            <h5>Dr. Philippe Macaire</h5>
                                            <p>Cardiologist</p>
                                            <h4>12 Years of Exp.</h4>
                                            <div className="docrate-set">
                                                <AiFillStar />
                                                <AiFillStar />
                                                <AiFillStar />
                                                <AiFillStar />
                                                <AiFillStar />
                                                <span>(58)</span>
                                            </div>
                                            <h6><HiLocationMarker />Ho Chi Minh City</h6>
                                        </div>
                                    </div>
                                    <div className="doclang-set">
                                        <p><GrLanguage />English, Viet, Tay, Mon, Hmong</p>
                                    </div>
                                </div>
                                <div className="viewprobookap-btn">
                                    <Button className='viewpro-btn'>View Profile</Button>
                                    <Button className='bookapp-btn' onClick={handleBookappmodel} variant="link">Book Appointment</Button>
                                </div>
                            </div>
                        </div>

                        <div className="col-lg-4 col-md-6">
                            <div className="docdetlist-cover">
                                <div className="docdetlist-set">
                                    <div className="docdetname-set">
                                        <Image src={Doclist3} alt="Doclist" />
                                        <div className="docnameexp-set">
                                            <h5>Dr. Sergii Bukhtii<MdVerified /></h5>
                                            <p>Cardiologist</p>
                                            <h4>3 Years of Exp.</h4>
                                            <div className="docrate-set">
                                                <AiFillStar />
                                                <AiFillStar />
                                                <AiFillStar />
                                                <AiFillStar />
                                                <AiFillStar />
                                                <span>(58)</span>
                                            </div>
                                            <h6><HiLocationMarker />Ho Chi Minh City</h6>
                                        </div>
                                    </div>
                                    <div className="doclang-set">
                                        <p><GrLanguage />English, Viet, Tay, Mon, Hmong</p>
                                    </div>
                                </div>
                                <div className="viewprobookap-btn">
                                    <Button className='viewpro-btn'>View Profile</Button>
                                    <Button className='bookapp-btn' onClick={handleBookappmodel} variant="link">Book Appointment</Button>
                                </div>
                            </div>
                        </div>

                        <div className="col-lg-4 col-md-6">
                            <div className="docdetlist-cover">
                                <div className="docdetlist-set">
                                    <div className="docdetname-set">
                                        <Image src={Doclist1} alt="Doclist" />
                                        <div className="docnameexp-set">
                                            <h5>Dr. Bruno Schaub<MdVerified /></h5>
                                            <p>Cardiologist</p>
                                            <h4>16 Years of Exp.</h4>
                                            <div className="docrate-set">
                                                <AiFillStar />
                                                <AiFillStar />
                                                <AiFillStar />
                                                <AiFillStar />
                                                <AiFillStar />
                                                <span>(58)</span>
                                            </div>
                                            <h6><HiLocationMarker />Ho Chi Minh City</h6>
                                        </div>
                                    </div>
                                    <div className="doclang-set">
                                        <p><GrLanguage />English, Viet, Tay, Mon, Hmong</p>
                                    </div>
                                </div>
                                <div className="viewprobookap-btn">
                                    <Button className='viewpro-btn'>View Profile</Button>
                                    <Button className='bookapp-btn' onClick={handleBookappmodel} variant="link">Book Appointment</Button>
                                </div>
                            </div>
                        </div>

                        <div className="col-lg-4 col-md-6">
                            <div className="docdetlist-cover">
                                <div className="docdetlist-set">
                                    <div className="docdetname-set">
                                        <Image src={Doclist2} alt="Doclist" />
                                        <div className="docnameexp-set">
                                            <h5>Dr. Philippe Macaire</h5>
                                            <p>Cardiologist</p>
                                            <h4>12 Years of Exp.</h4>
                                            <div className="docrate-set">
                                                <AiFillStar />
                                                <AiFillStar />
                                                <AiFillStar />
                                                <AiFillStar />
                                                <AiFillStar />
                                                <span>(58)</span>
                                            </div>
                                            <h6><HiLocationMarker />Ho Chi Minh City</h6>
                                        </div>
                                    </div>
                                    <div className="doclang-set">
                                        <p><GrLanguage />English, Viet, Tay, Mon, Hmong</p>
                                    </div>
                                </div>
                                <div className="viewprobookap-btn">
                                    <Button className='viewpro-btn'>View Profile</Button>
                                    <Button className='bookapp-btn' onClick={handleBookappmodel} variant="link">Book Appointment</Button>
                                </div>
                            </div>
                        </div>

                        <div className="col-lg-4 col-md-6">
                            <div className="docdetlist-cover">
                                <div className="docdetlist-set">
                                    <div className="docdetname-set">
                                        <Image src={Doclist3} alt="Doclist" />
                                        <div className="docnameexp-set">
                                            <h5>Dr. Sergii Bukhtii</h5>
                                            <p>Cardiologist</p>
                                            <h4>3 Years of Exp.</h4>
                                            <div className="docrate-set">
                                                <AiFillStar />
                                                <AiFillStar />
                                                <AiFillStar />
                                                <AiFillStar />
                                                <AiFillStar />
                                                <span>(58)</span>
                                            </div>
                                            <h6><HiLocationMarker />Ho Chi Minh City</h6>
                                        </div>
                                    </div>
                                    <div className="doclang-set">
                                        <p><GrLanguage />English, Viet, Tay, Mon, Hmong</p>
                                    </div>
                                </div>
                                <div className="viewprobookap-btn">
                                    <Button className='viewpro-btn'>View Profile</Button>
                                    <Button className='bookapp-btn' onClick={handleBookappmodel} variant="link">Book Appointment</Button>
                                </div>
                            </div>
                        </div>

                    </div>

                    <div className="paginationlist-cover">
                        <div className="totalpaglist-set">
                            <p>Showing 1 to 12 of 84 entries</p>
                        </div>
                        <div className="pagelistnum-set">
                            <ul>
                                <li><a href="javasript:;"><BiChevronLeft /></a></li>
                                <li><a href="javasript:;" className='pageactive'>1</a></li>
                                <li><a href="javasript:;">2</a></li>
                                <li><a href="javasript:;">3</a></li>
                                <li><a href="javasript:;">4</a></li>
                                <li><a href="javasript:;">5</a></li>
                                <li><a href="javasript:;"><BiChevronRight /></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default DoctorsList
