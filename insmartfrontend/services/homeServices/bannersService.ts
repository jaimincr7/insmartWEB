class bannersService {
    public async getAllBanners(): Promise<any> {
        return await fetch("http://3.110.54.49:81/api/v1/Banners/GetAllBanners").then((res) => res.json())
            .then((data) => {
                return data;
            });
    };
}

export default new bannersService();