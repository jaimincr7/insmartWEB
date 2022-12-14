class symptomsListService {
    public async getAllSymptomsList(): Promise<any> {
        return await fetch("http://3.110.54.49:81/api/v1/Symptoms/GetAllSymptoms").then((res) => res.json())
            .then((data) => {
                return data;
            });
    };
}

export default new symptomsListService();