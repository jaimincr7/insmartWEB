class specialitiesListService {
    public async getAllSpecialitiesList(): Promise<any> {
        return await fetch("http://3.110.54.49:81/api/v1/Specialities/GetAllSpecialities").then((res) => res.json())
            .then((data) => {
                return data;
            });
    };
}

export default new specialitiesListService();