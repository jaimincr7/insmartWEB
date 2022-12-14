class promotionalsService {
  public async getAllPromotionals(): Promise<any> {
    return await fetch("https://localhost:44368/api/v1/Promotionals/GetAllPromotionals").then((res) => res.json())
      .then((data) => {
        return data;
      });
  };
}

export default new promotionalsService();