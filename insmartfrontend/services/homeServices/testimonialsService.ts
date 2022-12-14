class testimonialsService {
    public async getAllTestimonials(): Promise<any> {
        return await fetch("http://3.110.54.49:81/api/v1/Testimonials/GetAllTestimonials").then((res) => res.json())
            .then((data) => {
                return data;
            });
    };
}

export default new testimonialsService();