import React from 'react'
import Modal from 'react-bootstrap/Modal';
import Datetimeslot from '../../Datetimeslot';

function bookappmodel(props: { show: boolean, onHide: any }) {
    return (
        <Modal
            {...props}
            backdrop="static"
            keyboard={false}
            centered
            className='bookappointmodMain'
        >
            <Modal.Header closeButton>
                <h5>Book an appointment for Consultation</h5>
            </Modal.Header>
            <Modal.Body>
                <div className="bookapp-consult">
                    <Datetimeslot />
                </div>
            </Modal.Body>
        </Modal>
    )
}

export default bookappmodel