Tên dự án: Ứng dụng bình chọn cầu thủ TOTY (Team of the Year) Loại ứng dụng: Windows Forms (.NET Framework) Ngôn ngữ lập trình: C# Thư viện JSON: Newtonsoft.Json Thư viện dữ liệu: Lib_CauThu (chứa lớp CauThu và CLB)

Chức năng chính:

Hiển thị danh sách cầu thủ từ file JSON

Hiển thị ảnh, tên, vị trí, quốc tịch, CLB

Người dùng chọn 1 cầu thủ yêu thích

Hiển thị thông tin cầu thủ đã chọn

Random kết quả TOTY

So sánh với lựa chọn người dùng

Hiển thị ảnh và thông tin người chiến thắng

Cấu trúc dữ liệu:

File JSON: DanhSachCauThu.json

Trường "Anh": đường dẫn tới ảnh trong thư mục Resources

Thư mục ảnh:

Đặt tại: WindowsFormsApp_CauThu\Resources

Tên ảnh: theo số áo (VD: 10.png, 7.png, ...)

Form chính:

Menu.cs: xử lý hiển thị và chọn cầu thủ

Champion.cs: hiển thị người thắng TOTY

Giới hạn:

Chỉ được chọn 1 cầu thủ duy nhất

Ảnh phải đúng tên và đúng thư mục
