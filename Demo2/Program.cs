using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class demo
{
    static void Main()
    {
        //cho phép Console hiển thị tiếng việt
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        //Console.WriteLine("Nhap vao thu nhap:");
        //string thunhap = Console.ReadLine();
        //double thuNhap = double.Parse(thunhap);
        //Console.WriteLine("Nhap vào so người phụ thuộc;");
        //int x = int.Parse(Console.ReadLine());
        //Console.WriteLine($"Thue Can Nop: {TinhThueTNCN(thuNhap, x)}");
        //Console.WriteLine("xin chao, this use snippet");

        Console.WriteLine("xin chao, this use snippet");
        Console.WriteLine("cái này update");


        #region lệnh if
        #region ví dụ 1
        //Console.WriteLine("Trời có mưa không?");
        //string? k = Console.ReadLine();
        //// kiểm tra giá trị vừa nhập, nếu là "không" thì rủ crush đi xem phim.
        //if (k == "không")
        //{
        //    Console.WriteLine("Rủ crush xem phim.");
        //}
        //Console.ReadKey();
        #endregion

        #region tính căn bậc 2 của số nhập vào
        //Console.WriteLine("Nhập số:");
        //string? input = Console.ReadLine();
        //int num = int.Parse(input);
        ////kiểm tra giá trị vừa nhập nếu > 0 thì tính căn bậc 2 và hiển thị ra màn hình
        //if (num >= 0)
        //{
        //    double sqrt = Math.Sqrt(num);
        //    Console.WriteLine($"Căn bậc 2 của {num} là: {sqrt}");
        //}
        //Console.ReadKey();
        #endregion
        #endregion

        #region lệnh if...else...
        //Console.WriteLine("Crush có đồng ý không?");
        //string? k = Console.ReadLine();
        //// kiểm tra giá trị vừa nhập, nếu là "không" thì rủ crush đi chơi
        //if (k == "có")
        //{
        //    Console.WriteLine("đặt 2 vé xem phim");
        //}
        //else
        //{
        //    Console.WriteLine("rủ bạn đi nhậu");
        //}
        //Console.ReadKey();
        #endregion
        #region nhiều lệnh if
        //Console.WriteLine("Crush có đồng ý không?");
        //string? k = Console.ReadLine();
        //// kiểm tra giá trị vừa nhập, nếu là "không" thì rủ crush đi chơi
        //if (k == "có")
        //{
        //    Console.WriteLine("Đặt 2 vé xem phim.");
        //}
        //else if(k =="không")
        //{
        //    Console.WriteLine("Rủ bạn đi nhậu.");
        //}
        //else
        //{
        //    Console.WriteLine("Chờ crush trả lời.");
        //}
        //Console.ReadKey();
        #endregion
        #region tính thuế thu nhập cá nhân

        ////nhập mức lương cần tính
        //Console.WriteLine("Thu nhập của bạn là bao nhiêu?");
        //string? input = Console.ReadLine();
        //double income;
        //double incometax = 0;
        //// kiểm tra dữ liệu đầu vào có đúng hay không?
        //if (double.TryParse(input, out income) && income>0)
        //{
        //    Console.WriteLine($" Thu nhập của bạn là: {income} đồng");
        //    if (income <= 9000000) // thu nhập <= 9 triệu 1 tháng
        //    {
        //        incometax = income * 0;
        //    }
        //    else if (income > 9000000 && income <= 15000000) // thu nhập từ trên 9 triệu đến 15 triệu
        //    {
        //        incometax = (income-9000000)*0.1;
        //    }else if (income > 15000000 && income <= 30000000) // thu nhập từ trên 15 triệu đến 30 triệu
        //    {
        //        incometax = 600000 + (income - 15000000) * 0.15;
        //    }else // thu nhập trên 30 triệu
        //    {
        //        incometax = 600000 + 2250000 + (income - 30000000) * 0.20;
        //    }

        //    Console.WriteLine($" Thuế thu nhập của bạn là: {incometax} đồng");
        //}
        //else
        //{
        //    Console.WriteLine("Dữ liệu nhập vào sai");
        //}

        //Console.ReadKey();
        #endregion
        #region tính thuế thu nhập cá nhân mới

        ////nhập mức lương cần tính
        //Console.WriteLine("Thu nhập:");
        //string? input = Console.ReadLine();
        //Console.WriteLine("Số người phụ thuộc?");
        //string? phuthuoc = Console.ReadLine();
        //int phuthuocNo = 0;
        //double income;
        //double incometax = 0;
        //double assessableIncometax = 0;
        //// kiểm tra dữ liệu đầu vào có đúng hay không?
        //if (double.TryParse(input, out income) && income > 0 && int.TryParse(phuthuoc, out phuthuocNo) && phuthuocNo >= 0)
        //{
        //    Console.WriteLine($" Thu nhập của bạn là: {income} đồng");
        //    Console.WriteLine($" Số người phụ thuộc: {phuthuocNo}");
        //    assessableIncometax = income- 11000000 - phuthuocNo * 4400000;
        //    Console.WriteLine($" Thu nhập tính thuế: {assessableIncometax} đồng");

        //    if(assessableIncometax <= 5000000)
        //    {
        //        incometax = assessableIncometax * 0.05;
        //    }


        //    Console.WriteLine($" Thuế thu nhập của bạn là: {incometax} đồng");
        //}
        //else
        //{
        //    Console.WriteLine("Dữ liệu nhập vào sai");
        //}

        //Console.ReadKey();
        #endregion

    }
    // Hàm tính thuế thu nhập cá nhân của Việt Nam
    // Tham số: thuNhap - thu nhập tính thuế (triệu đồng)
    // Tham số: soNguoiPhuThuoc - số người phụ thuộc
    // Trả về: thuế thu nhập cá nhân (triệu đồng)
    static double TinhThueTNCN(double thuNhap, int soNguoiPhuThuoc)
    {
        // Khai báo biến lưu thuế phải nộp
        double thue = 0;

        // Trừ đi số tiền giảm trừ gia cảnh cho bản thân và người phụ thuộc
        thuNhap -= 11 + 4.4 * soNguoiPhuThuoc;

        // Kiểm tra nếu thu nhập sau khi trừ giảm trừ nhỏ hơn hoặc bằng 0, thì trả về 0
        if (thuNhap <= 0)
        {
            return 0;
        }

        // Tính thuế phải nộp theo từng bậc tiền
        if (thuNhap > 80)
        {
            thue += 0.35 * (thuNhap - 80);
            thuNhap = 80;
        }
        if (thuNhap > 52)
        {
            thue += 0.3 * (thuNhap - 52);
            thuNhap = 52;
        }
        if (thuNhap > 32)
        {
            thue += 0.25 * (thuNhap - 32);
            thuNhap = 32;
        }  
        if (thuNhap > 18)
        {
            thue += 0.2 * (thuNhap - 18);
            thuNhap = 18;
        }
        if (thuNhap > 10)
        {
            thue += 0.15 * (thuNhap - 10);
            thuNhap = 10;
        }
        if (thuNhap > 5)
        {
            thue += 0.1 * (thuNhap - 5);
            thuNhap = 5;
        }
        thue += 0.05 * thuNhap;

        // Trả về kết quả
        return thue;
    }

}
