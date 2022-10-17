# Bill-Management using C#
Chương trình quản lý hóa đơn danh sách tiền điện của khách hàng đơn giản.
 - Thông tin bao gồm các loại khách hàng:
  + Khách hàng Việt Nam: mã KH, tên, địa chỉ, đối tượng(sinh hoạt, kinh doanh, sản xuất), số kw tiêu thụ, đơn giá, định mức.
      + Thành tiền: số lượng kw <= định mức : thành tiền = số lượng kw * đơn giá.
      + Ngược lại thì: thành tiền = số lượng kw * đơn giá * định mức + số lượng KW vượt định mức * Đơn giá * 2.5.
  + Khách hàng nước ngoài: mã khách hàng, họ tên, địa chỉ, quốc tịch, số lượng, đơn giá. Thành tiền được tính = số lượng * đơn giá.

Các yêu cầu:
  - Xây dựng các lớp với chức năng kế thừa.
  - Nhập xuất danh sách khách hàng.
  - Tính tổng số lượng KW tiêu thụ cho từng loại khách hàng.
  - Tính trung bình thành tiền của từng khách hàng.


