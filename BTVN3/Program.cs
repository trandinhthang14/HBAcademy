using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN3
{
    internal class Program
    {

        struct CityPopulation //kieu du lieu tu dinh nghia
        {
            public string City;
            public int Year1940;
            public int Population1940;
            public int Year1950;
            public int Population1950;
        }
        static void Main(string[] args)
        {
            
                CityPopulation[] cities = new CityPopulation[4];//khai báo một mảng cities gồm bốn đối tượng CityPopulation.


            //khởi tạo các đối tượng CityPopulation cho từng thành phố và gán giá trị cho từng thuộc tính.
                cities[0] = new CityPopulation { City = "Los Angeles", Year1940 = 1940, Population1940 = 1504277, Year1950 = 1950, Population1950 = 1970358 };
                cities[1] = new CityPopulation { City = "New York", Year1940 = 1940, Population1940 = 7454995, Year1950 = 1950, Population1950 = 7891957 };
                cities[2] = new CityPopulation { City = "Chicago", Year1940 = 1940, Population1940 = 3396888, Year1950 = 1950, Population1950 = 3620962 };
                cities[3] = new CityPopulation { City = "Detroit", Year1940 = 1940, Population1940 = 1623452, Year1950 = 1950, Population1950 = 1849568 };

                Console.WriteLine("{0,-15} {1,-4} {2,-10} {3,-4} {4,-10} {5,-10}", "City", "Year", "Population", "Year", "Population", "Change (%)");


            /*Vòng lặp foreach này duyệt qua từng đối tượng CityPopulation trong mảng cities.
            Trong mỗi lần lặp, dòng double changePercentage = ((double)(city.Population1950 - city.Population1940) / city.Population1940) * 100; 
            tính toán phần trăm thay đổi dân số giữa năm 1950 và 1940. Kết quả được lưu vào biến changePercentage.
            Console.WriteLine sau đó in ra thông tin của từng thành phố, bao gồm tên thành phố, năm, dân số trong hai năm, và phần trăm thay đổi dân số.
            Các ký tự định dạng {0,-15}, {1,-4}, v.v. giúp định dạng và căn lề các cột trong bảng. 
            :N0 định dạng số nguyên không có phần thập phân, và :N1 định dạng số thực với một chữ số sau dấu phẩy thập phân.*/
            foreach (var city in cities)
                {
                    double changePercentage = ((double)(city.Population1950 - city.Population1940) / city.Population1940) * 100;
                    Console.WriteLine("{0,-15} {1,-4} {2,-10:N0} {3,-4} {4,-10:N0} {5,-10:N1}%",
                                      city.City,
                                      city.Year1940,
                                      city.Population1940,
                                      city.Year1950,
                                      city.Population1950,
                                      changePercentage);
                }
            
        }

    }
}
