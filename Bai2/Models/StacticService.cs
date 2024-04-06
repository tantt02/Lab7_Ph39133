namespace Bai2.Models
{
    public static class StaticService
    {
        public static List<Products> listProducts = new List<Products>() {
           new Products() { Name = "Iphone 15 Promax",Price = 15000000 , Img = "img/iphone-15-pro-max_3.webp" },
           new Products() { Name = "Iphone Nubia Neo 5G",Price = 24400000 , Img = "img/nubia-neo-5g_2_1.webp" },
           new Products() { Name = "Iphone Oppo Reno 11",Price = 19400000 , Img = "img/oppo-reno-11-f-xanh-2.webp"} ,
           new Products() { Name = "Iphone Samsung Galaxy z flip",Price = 13400000 , Img = "img/samsung-galaxy-z-flip-5-256gb_1_5.webp"} ,
           new Products() { Name = "Iphone Tecno Pova",Price = 14900000 , Img = "img/tecno-pova-5_2_.webp"} ,
           new Products() { Name = "Iphone Xiami Redmi Note 12",Price = 243000000 , Img = "img/xiaomi-redmi-note-12-pro-5g.webp" },
        };


    }
}
