drop schema if exists CSKH;
CREATE DATABASE CSKH;
USE CSKH;
 
-- Bảng nhomKH (Customer Groups)
CREATE TABLE nhomKH (
    MaNhomKH VARCHAR(50) PRIMARY KEY, 
    TenNhomKH ENUM('Khách hàng thân thiết', 'Khách hàng tiềm năng'),
    MoTa TEXT
);
 
-- Bảng loaiSP (Product Categories)
CREATE TABLE loaiSP (
    MaLoaiSP VARCHAR(50) PRIMARY KEY, 
    TenLoaiSP ENUM(
        'Laptop', 'Điện thoại di động', 'Máy tính bảng', 
        'Máy tính để bàn', 'Linh kiện máy tính', 
        'Phụ kiện công nghệ', 'Thiết bị mạng', 
        'Máy ảnh & Thiết bị quay phim', 'Thiết bị lưu trữ', 
        'Màn hình & Máy chiếu', 'Đồng hồ thông minh', 'Đồ gia dụng'
    ),
    MoTa TEXT
);
 
-- Bảng khachhang (Customers)
CREATE TABLE khachhang (
    MaKhachHang VARCHAR(50) PRIMARY KEY,
    TenKhachHang VARCHAR(255),
    Email VARCHAR(255),
    SoDienThoai VARCHAR(20),
    DiaChi VARCHAR(255),
    MaNhomKH VARCHAR(50), 
    DiemTichLuy INT,
    NgaySinh DATE,
    GioiTinh VARCHAR(10),
    CapDoThanhVien ENUM('Đồng', 'Bạc', 'Vàng', 'Platinum'),
    FOREIGN KEY (MaNhomKH) REFERENCES nhomKH(MaNhomKH)
);
 
-- Bảng nhanvienhotro (Support Staff)
CREATE TABLE nhanvienhotro (
    MaNhanVien VARCHAR(50) PRIMARY KEY,
    HoTen VARCHAR(255),
    Email VARCHAR(255),
    SoDienThoai VARCHAR(20),
    ViTri ENUM('Nhân viên', 'Trưởng nhóm', 'Quản lý'),
    NgayBatDau DATETIME,
    TinhTrang TINYINT
);
 
-- Bảng sanpham (Products)
CREATE TABLE sanpham (
    MaSanPham VARCHAR(50) PRIMARY KEY,
    TenSanPham VARCHAR(255),
    MoTa TEXT,
    Gia DECIMAL(10,2),
    MaPhanLoai VARCHAR(50), 
    FOREIGN KEY (MaPhanLoai) REFERENCES loaiSP(MaLoaiSP)
);
 
-- Bảng hoadon (Invoices)
CREATE TABLE hoadon (
    MaHoaDon VARCHAR(50) PRIMARY KEY,
    MaKhachHang VARCHAR(50),
    NgayXuatHoaDon DATETIME,
    TongTien DECIMAL(10,2),
    PhuongThucThanhToan ENUM('Tiền mặt', 'Thẻ tín dụng', 'Chuyển khoản'),
    TinhTrangThanhToan ENUM('Đã thanh toán', 'Chưa thanh toán'),
    FOREIGN KEY (MaKhachHang) REFERENCES khachhang(MaKhachHang)
);
 
-- Bảng chitiethoadon (Invoice Details)
CREATE TABLE chitiethoadon (
    MaHoaDon VARCHAR(50),
    MaSanPham VARCHAR(50),
    SoLuong INT,
    MaKhuyenMai VARCHAR(50),
    TongTien DECIMAL(10,2),
    FOREIGN KEY (MaHoaDon) REFERENCES hoadon(MaHoaDon),
    FOREIGN KEY (MaSanPham) REFERENCES sanpham(MaSanPham)
);
 

 
-- Bảng phieubaohanh (Warranty Slips)
CREATE TABLE phieubaohanh (
    MaBaoHanh VARCHAR(50) PRIMARY KEY,
    MaSanPham VARCHAR(50),
    MoTa TEXT,
    ThoiHan varchar(50),
    FOREIGN KEY (MaSanPham) REFERENCES sanpham(MaSanPham)
);

-- Bảng lichsubaohanh (Warranty History)
CREATE TABLE lichsubaohanh (
    MaBaoHanh VARCHAR(50),
    MaKhachHang VARCHAR(50),
    NgayKichHoat DATETIME,
    MoTa TEXT,
    TinhTrangBaoHanh ENUM('Đang bảo hành', 'Kết thúc'),
    NgayHetHan DATETIME,
    FOREIGN KEY (MaBaoHanh) REFERENCES phieubaohanh(MaBaoHanh),
    FOREIGN KEY (MaKhachHang) REFERENCES khachhang(MaKhachHang)
);
 
-- Bảng lichsutuvan (Consultation History)
CREATE TABLE lichsutuvan (
    MaKhachHang VARCHAR(50),
    PhuongThucLienHe ENUM('Gọi điện', 'Email', 'Trực Tiếp'),
    NoiDungTuVan TEXT,
    ThoiGian DATETIME,
    NoiDungPhanHoi TEXT,
    MaNhanVien VARCHAR(50),
    FOREIGN KEY (MaKhachHang) REFERENCES khachhang(MaKhachHang),
    FOREIGN KEY (MaNhanVien) REFERENCES nhanvienhotro(MaNhanVien)
);
 
-- Bảng khieunai (Complaints)
CREATE TABLE khieunai (
    MaKhieuNai VARCHAR(50) PRIMARY KEY,
    MaKhachHang VARCHAR(50),
    MaNhanVien VARCHAR(50),
    NgayKhieuNai DATETIME,
    TinhTrang ENUM('Đang xử lý', 'Đã xử lý'),
    NoiDungKhieuNai TEXT,
    PhanHoiKhieuNai TEXT,
    FOREIGN KEY (MaKhachHang) REFERENCES khachhang(MaKhachHang),
    FOREIGN KEY (MaNhanVien) REFERENCES nhanvienhotro(MaNhanVien)
);
 
-- Bảng phanhoi (Feedback)
CREATE TABLE phanhoi (
    MaPhanHoi VARCHAR(50) PRIMARY KEY,
    MaKhachHang VARCHAR(50),
    MaSanPham VARCHAR(50),
    NgayPhanHoi DATETIME,
    MucDoHaiLong varchar(50),
    NoiDung TEXT,
    FOREIGN KEY (MaKhachHang) REFERENCES khachhang(MaKhachHang),
    FOREIGN KEY (MaSanPham) REFERENCES sanpham(MaSanPham)
);
 
-- Bảng yeucautuvan (Consultation Requests)
CREATE TABLE yeucautuvan (
    MaYeuCau VARCHAR(50) PRIMARY KEY,
    MaKhachHang VARCHAR(50),
    MaNhanVien VARCHAR(50),
    NgayGui DATETIME,
    NoiDungYeuCau TEXT,
    TrangThai ENUM('Chưa giải quyết', 'Đang giải quyết', 'Đã giải quyết', 'Đóng yêu cầu'),
    FOREIGN KEY (MaKhachHang) REFERENCES khachhang(MaKhachHang),
    FOREIGN KEY (MaNhanVien) REFERENCES nhanvienhotro(MaNhanVien)
);
 
-- Bảng vanchuyen (Shipping)
CREATE TABLE vanchuyen (
    MaVanDon VARCHAR(50) PRIMARY KEY,
    MaHoaDon VARCHAR(50),
    NgayVanChuyen DATETIME,
    TrangThaiVanChuyen ENUM('Đang giao', 'Đã giao', 'Hoãn giao'),
    PhuongThucVanChuyen ENUM('Giao hàng nhanh', 'Giao thường', 'Tự nhận hàng'),
    FOREIGN KEY (MaHoaDon) REFERENCES hoadon(MaHoaDon)
);
 
-- Bảng taikhoan (Accounts)
CREATE TABLE taikhoan (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    TenDangNhap VARCHAR(50),
    MatKhau VARCHAR(255)
);

-- select * from loaiSP;

-- Thêm data
INSERT INTO nhomKH (MaNhomKH, TenNhomKH, MoTa) VALUES
('NKH01', 'Khách hàng thân thiết', 'Nhóm khách hàng trung thành, thường xuyên mua hàng.'),
('NKH02', 'Khách hàng tiềm năng', 'Nhóm khách hàng mới, có tiềm năng trở thành khách hàng trung thành.');

INSERT INTO loaiSP (MaLoaiSP, TenLoaiSP, MoTa) VALUES
('L01', 'Laptop', 'Máy tính xách tay dùng cho công việc và giải trí, cấu hình mạnh mẽ'),
('L02', 'Điện thoại di động', 'Các loại điện thoại thông minh với nhiều tính năng nổi bật'),
('L03', 'Máy tính bảng', 'Thiết bị di động với màn hình lớn, thích hợp cho công việc và giải trí'),
('L04', 'Máy tính để bàn', 'Máy tính để bàn cấu hình cao, sử dụng cho công việc văn phòng và chơi game'),
('L05', 'Linh kiện máy tính', 'Các thành phần như CPU, RAM, ổ cứng, bo mạch chủ dùng để lắp ráp máy tính'),
('L06', 'Phụ kiện công nghệ', 'Các phụ kiện như bàn phím, chuột, tai nghe, pin sạc cho thiết bị công nghệ'),
('L07', 'Thiết bị mạng', 'Router, switch, modem và các thiết bị khác phục vụ kết nối mạng'),
('L08', 'Máy ảnh & Thiết bị quay phim', 'Máy ảnh kỹ thuật số và các thiết bị hỗ trợ quay phim chuyên nghiệp'),
('L09', 'Thiết bị lưu trữ', 'Ổ cứng di động, thẻ nhớ, USB phục vụ lưu trữ dữ liệu'),
('L10', 'Màn hình & Máy chiếu', 'Màn hình máy tính và máy chiếu phục vụ cho công việc và giải trí'),
('L11', 'Đồng hồ thông minh', 'Các loại đồng hồ thông minh phục vụ theo dõi sức khỏe và kết nối với điện thoại'),
('L12', 'Đồ gia dụng', 'Các thiết bị gia dụng như máy hút bụi, nồi cơm điện, và các thiết bị điện tử khác');

INSERT INTO khachhang (MaKhachHang, TenKhachHang, Email, SoDienThoai, DiaChi, MaNhomKH, DiemTichLuy, NgaySinh, GioiTinh, CapDoThanhVien) VALUES
('KH001', 'Nguyễn Văn Anh', 'nguyenvananh@gmail.com', '0901234567', '123 Đường Hoàng Quốc Việt, Hà Nội', 'NKH01', 1500, '1990-01-15', 'Nam', 'Vàng'),
('KH002', 'Trần Thị Buôn', 'tranthibuon@yahoo.com', '0912345678', '456 Đường Nguyễn Trãi, Hà Nội', 'NKH02', 500, '1985-05-22', 'Nữ', 'Bạc'),
('KH003', 'Lê Minh Chí', 'leminhchi@hotmail.com', '0923456789', '789 Đường Láng, Hà Nội', 'NKH01', 2000, '1992-07-10', 'Nam', 'Platinum'),
('KH004', 'Phan Thị Duyên', 'phanthiduyen@outlook.com', '0934567890', '321 Đường Cầu Giấy, Hà Nội', 'NKH02', 800, '1988-03-12', 'Nữ', 'Đồng'),
('KH005', 'Đoàn Quang Minh', 'doanquangminh@mail.com', '0945678901', '654 Đường Nguyễn Du, Hà Nội', 'NKH01', 3000, '1995-12-05', 'Nam', 'Vàng'),
('KH006', 'Vũ Thị Hà', 'vuthiha@gmail.com', '0956789012', '987 Đường Phố Huế, Hà Nội', 'NKH02', 600, '1987-08-20', 'Nữ', 'Bạc'),
('KH007', 'Ngô Hoàng Gia Bảo', 'ngohoanggiabao@yahoo.com', '0967890123', '654 Đường Kim Mã, Hà Nội', 'NKH01', 1200, '1991-11-14', 'Nam', 'Vàng'),
('KH008', 'Bùi Quế Hải', 'buiquehai@hotmail.com', '0978901234', '159 Đường Xã Đàn, Hà Nội', 'NKH02', 1000, '1993-06-25', 'Nữ', 'Platinum'),
('KH009', 'Lý Hải Hà', 'lyhaiha@outlook.com', '0989012345', '753 Đường Trần Hưng Đạo, Hà Nội', 'NKH01', 400, '1989-04-10', 'Nam', 'Đồng'),
('KH010', 'Hoàng Minh Trí', 'hoangminhtri@mail.com', '0990123456', '852 Đường Bạch Mai, Hà Nội', 'NKH01', 2500, '1994-09-18', 'Nam', 'Vàng'),
('KH011', 'Phan Quý Khải', 'phanquykhai@yahoo.com', '0912345678', '123 Đường Giải Phóng, Hà Nội', 'NKH02', 1500, '1987-02-10', 'Nam', 'Platinum'),
('KH012', 'Trịnh Lê Mai', 'trinhlemai@gmail.com', '0923456789', '456 Đường Nguyễn Đình Chiểu, Hà Nội', 'NKH01', 700, '1991-07-22', 'Nữ', 'Bạc'),
('KH013', 'Nguyễn Nhật Minh', 'nguyennhatminh@outlook.com', '0934567890', '789 Đường Đại Cồ Việt, Hà Nội', 'NKH02', 1200, '1992-11-05', 'Nam', 'Vàng'),
('KH014', 'Lê Khánh Oanh', 'lekhanhoanh@gmail.com', '0945678901', '321 Đường Tây Sơn, Hà Nội', 'NKH01', 800, '1990-03-15', 'Nữ', 'Đồng'),
('KH015', 'Trần Tuyết Phong', 'trantuyetphong@mail.com', '0956789012', '654 Đường Trần Phú, Hà Nội', 'NKH02', 900, '1985-12-30', 'Nữ', 'Bạc');

INSERT INTO nhanvienhotro (MaNhanVien, HoTen, Email, SoDienThoai, ViTri, NgayBatDau, TinhTrang) VALUES
('NV01', 'Bùi Văn Nguyên', 'NV01.buivannguyen@nan.gmail.com', '0901234567', 'Nhân viên', '2020-03-01 08:00:00', 1),
('NV02', 'Trần Thị Hà', 'NV02.tranthiha@nan.gmail.com', '0912345678', 'Nhân viên', '2019-05-15 09:00:00', 1),
('NV03', 'Lê Minh Ngọc', 'NV03.leminhngoc@nan.gmail.com', '0923456789', 'Quản lý', '2018-07-01 10:00:00', 1),
('NV04', 'Phan Thị Dung', 'NV04.phanthidung@nan.gmail.com', '0934567890', 'Nhân viên', '2021-01-10 08:30:00', 1),
('NV05', 'Đoàn Quang Huy', 'NV05.doanquanghuy@nan.gmail.com', '0945678901', 'Nhân viên', '2020-11-25 09:00:00', 1),
('NV06', 'Vũ Thị Loan', 'NV06.vuthiloan@nan.gmail.com', '0956789012', 'Nhân viên', '2022-04-20 08:45:00', 1),
('NV07', 'Ngô Hoàng Minh Anh', 'NV07.ngohoangminhanh@nan.gmail.com', '0967890123', 'Nhân viên', '2021-06-15 09:30:00', 1),
('NV08', 'Trần Xuân Sơn', 'NV08.tranxuanson@nan.gmail.com', '0978901234', 'Nhân viên', '2022-09-10 08:00:00', 1),
('NV09', 'Lý Hải Vân', 'NV09.lyhaivan@nan.gmail.com', '0989012345', 'Nhân viên', '2019-02-25 10:15:00', 1),
('NV10', 'Hoàng Bùi Anh Thư', 'NV10.hoangbuianhthu@nan.gmail.com', '0990123456', 'Nhân viên', '2023-05-17 08:30:00', 1);

INSERT INTO sanpham (MaSanPham, TenSanPham, MoTa, Gia, MaPhanLoai) VALUES
('SP01', 'Laptop Dell Inspiron 15', 'Laptop Dell Inspiron 15 inch, Core i5, 8GB RAM', 15000.00, 'L01'),
('SP02', 'Laptop HP Pavilion 14', 'Laptop HP Pavilion 14 inch, Core i7, 16GB RAM', 18000.00, 'L01'),
('SP03', 'Điện thoại Samsung Galaxy S22', 'Điện thoại Samsung Galaxy S22, màn hình 6.1 inch, camera 50MP', 12000.00, 'L02'),
('SP04', 'Điện thoại iPhone 13', 'Điện thoại iPhone 13, màn hình 6.1 inch, camera 12MP', 16000.00, 'L02'),
('SP05', 'Máy tính bảng iPad Air', 'Máy tính bảng iPad Air 10.9 inch, chip M1, 64GB', 14000.00, 'L03'),
('SP06', 'Máy tính bảng Samsung Galaxy Tab S7', 'Máy tính bảng Samsung Galaxy Tab S7, 11 inch, 128GB', 13000.00, 'L03'),
('SP07', 'Máy tính để bàn HP EliteOne 800', 'Máy tính để bàn HP EliteOne 800, Core i7, 16GB RAM', 22000.00, 'L04'),
('SP08', 'Máy tính để bàn Dell XPS 8940', 'Máy tính để bàn Dell XPS 8940, Core i9, 32GB RAM', 25000.00, 'L04'),
('SP09', 'Linh kiện máy tính SSD Samsung 970 Evo', 'Ổ cứng SSD Samsung 970 Evo, 1TB, tốc độ cao', 5000.00, 'L05'),
('SP10', 'Linh kiện máy tính RAM Corsair Vengeance', 'RAM Corsair Vengeance LPX, 16GB, DDR4', 2000.00, 'L05'),
('SP11', 'Chuột Logitech MX Master 3', 'Chuột không dây Logitech MX Master 3, dành cho công việc văn phòng', 1500.00, 'L06'),
('SP12', 'Bàn phím cơ Razer Huntsman', 'Bàn phím cơ Razer Huntsman, switch quang học, đèn RGB', 3000.00, 'L06'),
('SP13', 'Router TP-Link Archer AX6000', 'Router TP-Link Archer AX6000, Wi-Fi 6, tốc độ 6000Mbps', 4000.00, 'L07'),
('SP14', 'Máy ảnh Canon EOS 90D', 'Máy ảnh Canon EOS 90D, cảm biến CMOS 32.5MP, quay video 4K', 22000.00, 'L08'),
('SP15', 'Máy chiếu Epson EH-TW7100', 'Máy chiếu Epson EH-TW7100, độ phân giải 4K, 3000 lumen', 28000.00, 'L10');

INSERT INTO hoadon (MaHoaDon, MaKhachHang, NgayXuatHoaDon, TongTien, PhuongThucThanhToan, TinhTrangThanhToan) VALUES
('HD001', 'KH001', '2024-12-01 10:00:00', 15000.00, 'Tiền mặt', 'Đã thanh toán'),
('HD002', 'KH002', '2024-12-01 11:00:00', 5000.00, 'Chuyển khoản', 'Đã thanh toán'),
('HD003', 'KH003', '2024-12-02 09:30:00', 12000.00, 'Thẻ tín dụng', 'Đã thanh toán'),
('HD004', 'KH004', '2024-12-02 14:15:00', 8000.00, 'Tiền mặt', 'Chưa thanh toán'),
('HD005', 'KH005', '2024-12-03 16:00:00', 25000.00, 'Chuyển khoản', 'Đã thanh toán'),
('HD006', 'KH006', '2024-12-04 08:45:00', 9000.00, 'Thẻ tín dụng', 'Đã thanh toán'),
('HD007', 'KH007', '2024-12-04 10:30:00', 14000.00, 'Tiền mặt', 'Đã thanh toán'),
('HD008', 'KH008', '2024-12-05 12:00:00', 18000.00, 'Chuyển khoản', 'Chưa thanh toán'),
('HD009', 'KH009', '2024-12-06 13:45:00', 5000.00, 'Thẻ tín dụng', 'Đã thanh toán'),
('HD010', 'KH010', '2024-12-06 15:30:00', 22000.00, 'Tiền mặt', 'Đã thanh toán'),
('HD011', 'KH011', '2024-12-07 17:00:00', 3000.00, 'Chuyển khoản', 'Đã thanh toán'),
('HD012', 'KH012', '2024-12-08 10:15:00', 10000.00, 'Thẻ tín dụng', 'Chưa thanh toán'),
('HD013', 'KH013', '2024-12-08 12:45:00', 12000.00, 'Tiền mặt', 'Đã thanh toán'),
('HD014', 'KH014', '2024-12-09 14:30:00', 8000.00, 'Chuyển khoản', 'Chưa thanh toán'),
('HD015', 'KH015', '2024-12-10 16:45:00', 15000.00, 'Thẻ tín dụng', 'Đã thanh toán');

INSERT INTO chitiethoadon (MaHoaDon, MaSanPham, SoLuong, MaKhuyenMai, TongTien) VALUES
('HD001', 'SP01', 1, 'KM01', 15000.00),
('HD002', 'SP03', 2, 'KM02', 24000.00),
('HD003', 'SP05', 1, 'KM03', 14000.00),
('HD004', 'SP02', 1, 'KM04', 18000.00),
('HD005', 'SP07', 1, NULL, 22000.00),
('HD006', 'SP09', 2, 'KM05', 10000.00),
('HD007', 'SP11', 3, 'KM06', 4500.00),
('HD008', 'SP04', 1, NULL, 16000.00),
('HD009', 'SP12', 1, 'KM07', 3000.00),
('HD010', 'SP08', 1, 'KM08', 25000.00),
('HD011', 'SP06', 2, NULL, 26000.00),
('HD012', 'SP10', 4, 'KM09', 8000.00),
('HD013', 'SP13', 1, NULL, 4000.00),
('HD014', 'SP14', 1, 'KM10', 22000.00),
('HD015', 'SP15', 1, NULL, 28000.00);


INSERT INTO phieubaohanh (MaBaoHanh, MaSanPham, MoTa, ThoiHan) VALUES
('BH01', 'SP01', 'Bảo hành 12 tháng cho các lỗi phần cứng không do người dùng gây ra', '12 tháng'),
('BH02', 'SP02', 'Bảo hành 14 tháng với chính sách đổi mới trong 30 ngày đầu tiên', '14 tháng'),
('BH03', 'SP03', 'Bảo hành 18 tháng cho lỗi sản xuất, không áp dụng rơi vỡ hoặc vào nước', '18 tháng'),
('BH04', 'SP04', 'Bảo hành 24 tháng bao gồm cả thay thế linh kiện chính hãng', '24 tháng'),
('BH05', 'SP05', 'Bảo hành 36 tháng với chính sách hỗ trợ kỹ thuật trực tuyến 24/7', '36 tháng'),
('BH06', 'SP06', 'Bảo hành 12 tháng, đổi mới nếu lỗi do nhà sản xuất', '12 tháng'),
('BH07', 'SP07', 'Bảo hành 14 tháng, áp dụng cho tất cả các lỗi phần cứng', '14 tháng'),
('BH08', 'SP08', 'Bảo hành 24 tháng, hỗ trợ sửa chữa tận nơi cho khách hàng', '24 tháng'),
('BH09', 'SP09', 'Bảo hành 18 tháng với lỗi phần cứng, không bao gồm hao mòn vật lý', '18 tháng'),
('BH10', 'SP10', 'Bảo hành 36 tháng, đổi mới trong 7 ngày đầu nếu phát sinh lỗi', '36 tháng'),
('BH11', 'SP11', 'Bảo hành 12 tháng áp dụng toàn quốc với các sản phẩm chính hãng', '12 tháng'),
('BH12', 'SP12', 'Bảo hành 24 tháng, hỗ trợ sửa chữa tại các trung tâm chính hãng', '24 tháng'),
('BH13', 'SP13', 'Bảo hành 14 tháng cho tất cả lỗi sản xuất, không áp dụng rơi vỡ', '14 tháng'),
('BH14', 'SP14', 'Bảo hành 36 tháng, đổi trả miễn phí trong 15 ngày đầu tiên', '36 tháng'),
('BH15', 'SP15', 'Bảo hành 18 tháng, hỗ trợ bảo trì và sửa chữa với chi phí thấp', '18 tháng');

INSERT INTO lichsubaohanh (MaBaoHanh, MaKhachHang, NgayKichHoat, MoTa, TinhTrangBaoHanh, NgayHetHan) VALUES
('BH01', 'KH001', '2023-01-15 09:00:00', 'Kích hoạt bảo hành sản phẩm Laptop Dell Inspiron 15', 'Kết thúc', '2024-01-15 23:59:59'),
('BH02', 'KH002', '2023-02-20 10:00:00', 'Kích hoạt bảo hành sản phẩm Laptop HP Pavilion 14', 'Đang bảo hành', '2024-04-20 23:59:59'),
('BH03', 'KH003', '2023-03-05 11:00:00', 'Kích hoạt bảo hành sản phẩm Điện thoại Samsung Galaxy S22', 'Đang bảo hành', '2024-09-05 23:59:59'),
('BH04', 'KH004', '2022-12-12 08:00:00', 'Kích hoạt bảo hành sản phẩm Điện thoại iPhone 13', 'Kết thúc', '2024-12-12 23:59:59'),
('BH05', 'KH005', '2023-06-15 15:00:00', 'Kích hoạt bảo hành sản phẩm iPad Air', 'Đang bảo hành', '2026-06-15 23:59:59'),
('BH06', 'KH006', '2023-08-25 14:00:00', 'Kích hoạt bảo hành sản phẩm Samsung Galaxy Tab S7', 'Đang bảo hành', '2024-08-25 23:59:59'),
('BH07', 'KH007', '2023-09-10 09:00:00', 'Kích hoạt bảo hành sản phẩm Máy tính để bàn HP EliteOne 800', 'Đang bảo hành', '2024-11-10 23:59:59'),
('BH08', 'KH008', '2022-10-01 16:00:00', 'Kích hoạt bảo hành sản phẩm Máy tính để bàn Dell XPS 8940', 'Kết thúc', '2024-10-01 23:59:59'),
('BH09', 'KH009', '2023-04-20 13:00:00', 'Kích hoạt bảo hành sản phẩm SSD Samsung 970 Evo', 'Đang bảo hành', '2024-10-20 23:59:59'),
('BH10', 'KH010', '2023-05-15 11:00:00', 'Kích hoạt bảo hành sản phẩm RAM Corsair Vengeance', 'Đang bảo hành', '2026-05-15 23:59:59'),
('BH11', 'KH011', '2023-03-01 12:00:00', 'Kích hoạt bảo hành sản phẩm Chuột Logitech MX Master 3', 'Kết thúc', '2024-03-01 23:59:59'),
('BH12', 'KH012', '2023-07-22 10:00:00', 'Kích hoạt bảo hành sản phẩm Bàn phím cơ Razer Huntsman', 'Đang bảo hành', '2025-07-22 23:59:59'),
('BH13', 'KH013', '2023-08-05 09:30:00', 'Kích hoạt bảo hành sản phẩm Router TP-Link Archer AX6000', 'Đang bảo hành', '2024-10-05 23:59:59'),
('BH14', 'KH014', '2023-02-14 14:30:00', 'Kích hoạt bảo hành sản phẩm Máy ảnh Canon EOS 90D', 'Kết thúc', '2026-02-14 23:59:59'),
('BH15', 'KH015', '2023-06-30 17:00:00', 'Kích hoạt bảo hành sản phẩm Máy chiếu Epson EH-TW7100', 'Đang bảo hành', '2024-12-30 23:59:59');

INSERT INTO lichsutuvan (MaKhachHang, PhuongThucLienHe, NoiDungTuVan, ThoiGian, NoiDungPhanHoi, MaNhanVien) VALUES
('KH001', 'Gọi điện', 'Hỏi về các dòng laptop có cấu hình cao cho công việc văn phòng', '2023-01-20 10:00:00', 'Đề xuất Laptop Dell Inspiron 15 với cấu hình i5, 8GB RAM', 'NV01'),
('KH002', 'Email', 'Tư vấn các mẫu điện thoại giá rẻ, màn hình đẹp', '2023-02-25 12:00:00', 'Giới thiệu điện thoại Samsung Galaxy S22, giá hợp lý', 'NV02'),
('KH003', 'Trực Tiếp', 'Cần tư vấn về sản phẩm máy tính bảng dùng cho học tập và giải trí', '2023-03-15 14:30:00', 'Gợi ý sản phẩm iPad Air với chip M1, 64GB', 'NV03'),
('KH004', 'Gọi điện', 'Thắc mắc về bảo hành của sản phẩm laptop', '2023-04-01 09:30:00', 'Cung cấp thông tin bảo hành cho Laptop HP Pavilion 14', 'NV04'),
('KH005', 'Email', 'Hỏi về các sản phẩm máy tính để bàn cho dân văn phòng', '2023-05-10 11:45:00', 'Giới thiệu Máy tính để bàn HP EliteOne 800', 'NV05'),
('KH006', 'Trực Tiếp', 'Tư vấn về các sản phẩm máy tính bảng và linh kiện nâng cấp máy tính', '2023-06-18 13:00:00', 'Tư vấn Máy tính bảng Samsung Galaxy Tab S7 và SSD Samsung 970 Evo', 'NV06'),
('KH007', 'Gọi điện', 'Hỏi về các loại chuột không dây cho công việc văn phòng', '2023-07-25 15:30:00', 'Giới thiệu chuột Logitech MX Master 3', 'NV07'),
('KH008', 'Email', 'Tư vấn sản phẩm máy ảnh cho nhiếp ảnh gia', '2023-08-12 10:00:00', 'Khuyên dùng máy ảnh Canon EOS 90D', 'NV08'),
('KH009', 'Trực Tiếp', 'Thắc mắc về các phụ kiện cho máy tính xách tay', '2023-09-05 16:45:00', 'Đề xuất bàn phím cơ Razer Huntsman', 'NV09'),
('KH010', 'Gọi điện', 'Tư vấn về các sản phẩm linh kiện máy tính', '2023-10-20 17:00:00', 'Giới thiệu RAM Corsair Vengeance LPX', 'NV10'),
('KH011', 'Email', 'Cần biết thêm thông tin về sản phẩm máy chiếu', '2023-11-01 13:15:00', 'Đề xuất máy chiếu Epson EH-TW7100', 'NV01'),
('KH012', 'Trực Tiếp', 'Tư vấn về sản phẩm lưu trữ dữ liệu cho người dùng doanh nghiệp', '2023-12-10 14:00:00', 'Khuyên dùng ổ cứng SSD Samsung 970 Evo', 'NV02'),
('KH013', 'Gọi điện', 'Cần tư vấn về các dòng điện thoại thông minh cao cấp', '2023-12-15 09:30:00', 'Giới thiệu điện thoại iPhone 13 và Samsung Galaxy S22', 'NV03'),
('KH014', 'Email', 'Tư vấn về các sản phẩm màn hình cho dân văn phòng', '2023-12-18 11:00:00', 'Đề xuất màn hình máy tính từ Dell và LG', 'NV04'),
('KH015', 'Trực Tiếp', 'Tư vấn về các loại thiết bị mạng cho doanh nghiệp', '2023-12-22 08:30:00', 'Giới thiệu router TP-Link Archer AX6000', 'NV05');

INSERT INTO khieunai (MaKhieuNai, MaKhachHang, MaNhanVien, NgayKhieuNai, TinhTrang, NoiDungKhieuNai, PhanHoiKhieuNai) VALUES
('KN001', 'KH001', 'NV01', '2023-01-10 10:00:00', 'Đang xử lý', 'Khách hàng phàn nàn về chất lượng sản phẩm Laptop Dell Inspiron 15', 'Đang tiến hành kiểm tra chất lượng sản phẩm'),
('KN002', 'KH002', 'NV02', '2023-02-15 11:30:00', 'Đã xử lý', 'Khách hàng khiếu nại về việc giao hàng chậm', 'Đã giải quyết, bồi thường 10% giá trị đơn hàng'),
('KN003', 'KH003', 'NV03', '2023-03-20 14:00:00', 'Đang xử lý', 'Khách hàng không hài lòng về độ phân giải màn hình của Laptop HP Pavilion 14', 'Đang kiểm tra lại sản phẩm'),
('KN004', 'KH004', 'NV04', '2023-04-01 09:15:00', 'Đã xử lý', 'Khách hàng phàn nàn về sản phẩm không còn bảo hành', 'Đã giải thích về chính sách bảo hành'),
('KN005', 'KH005', 'NV05', '2023-05-25 16:45:00', 'Đang xử lý', 'Khách hàng khiếu nại về chất lượng của ổ cứng SSD Samsung 970 Evo', 'Đang yêu cầu sản phẩm kiểm tra lại'),
('KN006', 'KH006', 'NV06', '2023-06-30 13:20:00', 'Đã xử lý', 'Khách hàng không hài lòng với sự chậm trễ trong dịch vụ tư vấn', 'Đã xin lỗi và đưa ra lời giải thích hợp lý'),
('KN007', 'KH007', 'NV07', '2023-07-12 11:00:00', 'Đã xử lý', 'Khách hàng khiếu nại về việc máy tính để bàn Dell XPS 8940 bị lỗi phần cứng', 'Đã đổi trả sản phẩm và hoàn tiền'),
('KN008', 'KH008', 'NV08', '2023-08-01 15:30:00', 'Đang xử lý', 'Khách hàng phàn nàn về việc máy ảnh Canon EOS 90D bị hỏng khi sử dụng', 'Đang tiến hành kiểm tra bảo hành'),
('KN009', 'KH009', 'NV09', '2023-09-05 14:00:00', 'Đã xử lý', 'Khách hàng phàn nàn về sản phẩm không đủ các phụ kiện đi kèm', 'Đã gửi phụ kiện thiếu cho khách hàng'),
('KN010', 'KH010', 'NV10', '2023-10-02 10:00:00', 'Đang xử lý', 'Khách hàng khiếu nại về sản phẩm máy chiếu Epson EH-TW7100 không tương thích với thiết bị khác', 'Đang kiểm tra khả năng tương thích sản phẩm'),
('KN011', 'KH011', 'NV01', '2023-11-18 09:30:00', 'Đã xử lý', 'Khách hàng không hài lòng về thời gian phản hồi qua email', 'Đã xin lỗi và đưa ra cam kết cải thiện'),
('KN012', 'KH012', 'NV02', '2023-12-05 13:45:00', 'Đang xử lý', 'Khách hàng khiếu nại về sự cố mất kết nối với router TP-Link Archer AX6000', 'Đang kiểm tra thiết bị và cung cấp hướng dẫn sửa lỗi'),
('KN013', 'KH013', 'NV03', '2023-12-10 08:30:00', 'Đã xử lý', 'Khách hàng không hài lòng với chính sách bảo hành của sản phẩm iPhone 13', 'Đã giải thích rõ về chính sách bảo hành và chấp nhận yêu cầu đổi sản phẩm'),
('KN014', 'KH014', 'NV04', '2023-12-15 11:00:00', 'Đang xử lý', 'Khách hàng phàn nàn về sản phẩm RAM Corsair Vengeance không nhận được', 'Đang điều tra vấn đề giao hàng'),
('KN015', 'KH015', 'NV05', '2023-12-20 12:30:00', 'Đã xử lý', 'Khách hàng khiếu nại về vấn đề với bàn phím cơ Razer Huntsman', 'Đã đề nghị đổi mới sản phẩm và hoàn tiền');

INSERT INTO phanhoi (MaPhanHoi, MaKhachHang, MaSanPham, NgayPhanHoi, MucDoHaiLong, NoiDung) VALUES
('PH001', 'KH001', 'SP01', '2023-01-15 10:00:00', '4 sao', 'Sản phẩm rất tốt, đáp ứng đủ nhu cầu sử dụng của tôi, sẽ tiếp tục mua lần sau.'),
('PH002', 'KH002', 'SP02', '2023-02-20 11:30:00', '5 sao', 'Chất lượng tuyệt vời, rất hài lòng với sản phẩm và dịch vụ giao hàng nhanh chóng.'),
('PH003', 'KH003', 'SP03', '2023-03-25 14:00:00', '3 sao', 'Sản phẩm tốt nhưng cần cải thiện thêm về thiết kế để dễ sử dụng hơn.'),
('PH004', 'KH004', 'SP04', '2023-04-10 09:45:00', '2 sao', 'Sản phẩm không như mong đợi, tôi gặp vấn đề về hiệu suất sử dụng.'),
('PH005', 'KH005', 'SP05', '2023-05-05 16:30:00', '1 sao', 'Sản phẩm bị lỗi ngay khi sử dụng lần đầu, tôi cảm thấy rất thất vọng.'),
('PH006', 'KH006', 'SP06', '2023-06-15 13:20:00', '4 sao', 'Tôi hài lòng với sản phẩm, nhưng dịch vụ hỗ trợ khách hàng cần cải thiện thêm.'),
('PH007', 'KH007', 'SP07', '2023-07-12 12:00:00', '5 sao', 'Sản phẩm quá tuyệt vời, tôi sẽ giới thiệu cho bạn bè và người thân.'),
('PH008', 'KH008', 'SP08', '2023-08-01 17:00:00', '3 sao', 'Sản phẩm không có nhiều tính năng như tôi mong đợi, nhưng vẫn khá ổn.'),
('PH009', 'KH009', 'SP09', '2023-09-05 14:30:00', '4 sao', 'Máy chạy rất mượt mà, tuy nhiên tôi nghĩ rằng giá sản phẩm có thể thấp hơn một chút.'),
('PH010', 'KH010', 'SP10', '2023-10-20 11:15:00', '2 sao', 'Chất lượng sản phẩm không giống như quảng cáo, tôi khá thất vọng.'),
('PH011', 'KH011', 'SP11', '2023-11-18 10:00:00', '3 sao', 'Sản phẩm ổn, nhưng cần thêm tính năng bảo mật tốt hơn cho người dùng.'),
('PH012', 'KH012', 'SP12', '2023-12-05 14:45:00', '4 sao', 'Chất lượng sản phẩm rất tốt, tôi đã sử dụng nhiều lần và cảm thấy hài lòng.'),
('PH013', 'KH013', 'SP13', '2023-12-12 09:30:00', '5 sao', 'Sản phẩm hoạt động tốt hơn tôi tưởng, hoàn toàn hài lòng với sự lựa chọn này.'),
('PH014', 'KH014', 'SP14', '2023-12-15 15:00:00', '2 sao', 'Sản phẩm không đạt yêu cầu, tôi gặp phải một số vấn đề kỹ thuật khi sử dụng.'),
('PH015', 'KH015', 'SP15', '2023-12-20 12:30:00', '4 sao', 'Sản phẩm khá tốt, giá cả hợp lý và chức năng đầy đủ, tuy nhiên có thể cải tiến về độ bền.');

INSERT INTO yeucautuvan (MaYeuCau, MaKhachHang, MaNhanVien, NgayGui, NoiDungYeuCau, TrangThai) VALUES
('YC001', 'KH001', 'NV01', '2023-01-10 09:00:00', 'Tôi muốn biết thêm về tính năng của sản phẩm SP001.', 'Đang giải quyết'),
('YC002', 'KH002', 'NV02', '2023-02-15 10:30:00', 'Sản phẩm SP002 của tôi bị lỗi, tôi cần hướng dẫn khắc phục.', 'Chưa giải quyết'),
('YC003', 'KH003', 'NV03', '2023-03-12 11:00:00', 'Tư vấn về cách sử dụng sản phẩm SP003 trong công việc hàng ngày.', 'Đang giải quyết'),
('YC004', 'KH004', 'NV04', '2023-04-01 14:00:00', 'Tôi cần hỗ trợ về thanh toán sản phẩm SP004 trên website.', 'Đã giải quyết'),
('YC005', 'KH005', 'NV05', '2023-05-05 15:30:00', 'Sản phẩm SP005 không thể kết nối với thiết bị của tôi, xin hỗ trợ.', 'Chưa giải quyết'),
('YC006', 'KH006', 'NV06', '2023-06-10 16:00:00', 'Hướng dẫn lắp đặt sản phẩm SP006 đúng cách.', 'Đang giải quyết'),
('YC007', 'KH007', 'NV07', '2023-07-05 17:00:00', 'Tôi muốn đổi trả sản phẩm SP007 do lỗi kỹ thuật.', 'Đã giải quyết'),
('YC008', 'KH008', 'NV08', '2023-08-20 13:15:00', 'Tư vấn về các sản phẩm thay thế cho SP008, tôi chưa hài lòng với hiệu quả sử dụng.', 'Chưa giải quyết'),
('YC009', 'KH009', 'NV09', '2023-09-18 10:30:00', 'Sản phẩm SP009 của tôi hết bảo hành, tôi muốn mua thêm dịch vụ bảo hành mở rộng.', 'Đang giải quyết'),
('YC010', 'KH010', 'NV10', '2023-10-25 11:45:00', 'Cần giúp đỡ trong việc xác nhận lại đơn hàng SP010.', 'Chưa giải quyết'),
('YC011', 'KH011', 'NV09', '2023-11-02 08:00:00', 'Tôi gặp vấn đề về phần mềm đi kèm với sản phẩm SP011, cần hỗ trợ khắc phục.', 'Đang giải quyết'),
('YC012', 'KH012', 'NV07', '2023-12-01 14:00:00', 'Tôi muốn được tư vấn về cách tăng hiệu quả sử dụng sản phẩm SP012 trong công việc.', 'Đã giải quyết'),
('YC013', 'KH013', 'NV06', '2023-12-08 09:30:00', 'Tôi cần thông tin về chế độ bảo hành của sản phẩm SP013.', 'Chưa giải quyết'),
('YC014', 'KH014', 'NV05', '2023-12-14 16:45:00', 'Tư vấn về tính năng đặc biệt của sản phẩm SP014, tôi không tìm thấy hướng dẫn sử dụng trong tài liệu.', 'Đang giải quyết'),
('YC015', 'KH015', 'NV03', '2023-12-18 10:15:00', 'Hướng dẫn sử dụng các tính năng nâng cao của sản phẩm SP015.', 'Đã giải quyết');

INSERT INTO vanchuyen (MaVanDon, MaHoaDon, NgayVanChuyen, TrangThaiVanChuyen, PhuongThucVanChuyen) VALUES
('VD001', 'HD001', '2023-01-15 10:00:00', 'Đang giao', 'Giao hàng nhanh'),
('VD002', 'HD002', '2023-02-18 12:30:00', 'Hoãn giao', 'Giao thường'),
('VD003', 'HD003', '2023-03-22 14:00:00', 'Đã giao', 'Tự nhận hàng'),
('VD004', 'HD004', '2023-04-05 09:30:00', 'Đang giao', 'Giao hàng nhanh'),
('VD005', 'HD005', '2023-05-10 11:00:00', 'Hoãn giao', 'Giao thường'),
('VD006', 'HD006', '2023-06-14 13:00:00', 'Đã giao', 'Tự nhận hàng'),
('VD007', 'HD007', '2023-07-20 15:00:00', 'Đang giao', 'Giao hàng nhanh'),
('VD008', 'HD008', '2023-08-25 16:30:00', 'Hoãn giao', 'Giao thường'),
('VD009', 'HD009', '2023-09-12 10:15:00', 'Đã giao', 'Tự nhận hàng'),
('VD010', 'HD010', '2023-10-01 09:00:00', 'Đang giao', 'Giao hàng nhanh'),
('VD011', 'HD011', '2023-11-07 11:30:00', 'Hoãn giao', 'Giao thường'),
('VD012', 'HD012', '2023-12-05 14:45:00', 'Đã giao', 'Tự nhận hàng'),
('VD013', 'HD013', '2023-12-10 16:00:00', 'Đang giao', 'Giao hàng nhanh'),
('VD014', 'HD014', '2023-12-18 09:30:00', 'Hoãn giao', 'Giao thường'),
('VD015', 'HD015', '2023-12-21 10:30:00', 'Đã giao', 'Tự nhận hàng');

DROP TABLE IF EXISTS taikhoan;
 
-- Tạo bảng taikhoan
CREATE TABLE taikhoan (
    TenDangNhap Varchar(50) PRIMARY KEY, 
    MaNhanVien VARCHAR(50),           -- Mã nhân viên (khóa ngoại)
    MatKhau VARCHAR(255) NOT NULL,    -- Mật khẩu đăng nhập
    FOREIGN KEY (MaNhanVien) REFERENCES nhanvienhotro(MaNhanVien) -- Khóa ngoại liên kết với bảng nhanvienhotro
);                                                  
  INSERT INTO taikhoan (TenDangNhap, MaNhanVien, MatKhau) VALUES
('NV01.bvn', 'NV01', 'BVN123456'),
('NV02.thh', 'NV02', 'THH789012'),
('NV03.lmn', 'NV03', 'LMN345678'),
('NV04.ptd', 'NV04', 'PTD567890'),
('NV05.dqh', 'NV05', 'DQH234567'),
('NV06.vtl', 'NV06', 'VTL890123'),
('NV07.ngma', 'NV07', 'NGMA456789'),
('NV08.txn', 'NV08', 'TXN901234'),
('NV09.lhv', 'NV09', 'LHV678901'),
('NV10.hba', 'NV10', 'HBA234567');




drop tables if exists khuyenmai;
CREATE TABLE KhuyenMai (
    MaKhuyenMai VARCHAR(10) PRIMARY KEY,
    TenKhuyenMai VARCHAR(100) NOT NULL,
    MoTa TEXT,
    NgayBatDau DATETIME,
    NgayKetThuc DATETIME,
    MucGiamGia FLOAT,
    TinhTrang INT,
    MaSanPham VARCHAR(10),
    DiemCanDoi INT DEFAULT 0,
    FOREIGN KEY (MaSanPham) REFERENCES sanpham(MaSanPham)
);
 
-- Thêm dữ liệu mẫu cho KhuyenMai
INSERT INTO KhuyenMai (MaKhuyenMai, TenKhuyenMai, MoTa, NgayBatDau, NgayKetThuc, MucGiamGia, TinhTrang, MaSanPham, DiemCanDoi) VALUES
('KM01', 'Khuyến mãi Laptop Dell', 'Giảm giá đặc biệt cho Laptop Dell Inspiron 15', '2024-12-01 00:00:00', '2024-12-31 23:59:59', 10.00, 1, 'SP01', 0),
('KM02', 'Voucher 100k', 'Đổi 50 điểm để nhận voucher', '2024-12-05 00:00:00', '2024-12-25 23:59:59', 0.00, 1, NULL, 50),
('KM03', 'Giảm giá iPad Air', 'Khuyến mãi mùa lễ cho iPad Air', '2024-12-10 00:00:00', '2025-01-10 23:59:59', 15.00, 1, 'SP03', 0),
('KM04', 'Quà USB 16GB', 'Đổi 150 điểm nhận USB', '2024-11-20 00:00:00', '2024-12-15 23:59:59', 0.00, 1, NULL, 150),
('KM05', 'Giảm giá SSD Samsung 970 Evo', 'Giảm giá 10% cho ổ cứng SSD Samsung 970 Evo', '2024-12-15 00:00:00', '2025-01-15 23:59:59', 10.00, 1, 'SP05', 0),
('KM06', 'Voucher 500k', 'Đổi 200 điểm để nhận voucher 500k', '2024-12-01 00:00:00', '2024-12-31 23:59:59', 0.00, 1, NULL, 200),
('KM07', 'Giảm giá Samsung Galaxy S22', 'Giảm giá 20% cho Samsung Galaxy S22', '2024-12-20 00:00:00', '2025-01-31 23:59:59', 20.00, 1, 'SP07', 0),
('KM08', 'Phiếu quà tặng 300k', 'Đổi 100 điểm nhận phiếu quà tặng', '2024-12-05 00:00:00', '2024-12-20 23:59:59', 0.00, 1, NULL, 100),
('KM09', 'Giảm giá Tivi Sony 50"', 'Giảm giá 25% cho Tivi Sony 50"', '2024-12-15 00:00:00', '2025-01-10 23:59:59', 25.00, 1, 'SP09', 0),
('KM10', 'Quà tai nghe Bluetooth', 'Đổi 300 điểm nhận tai nghe Bluetooth', '2024-12-01 00:00:00', '2024-12-31 23:59:59', 0.00, 1, NULL, 300),
('KM11', 'Giảm giá điều hòa Daikin', 'Giảm giá 12% cho điều hòa Daikin', '2024-12-18 00:00:00', '2025-01-15 23:59:59', 12.00, 1, 'SP11', 0),
('KM12', 'Voucher 1 triệu', 'Đổi 400 điểm để nhận voucher 1 triệu', '2024-12-10 00:00:00', '2024-12-31 23:59:59', 0.00, 1, NULL, 400),
('KM13', 'Giảm giá máy giặt LG', 'Giảm giá 15% cho máy giặt LG', '2024-12-05 00:00:00', '2025-01-20 23:59:59', 15.00, 1, 'SP13', 0),
('KM14', 'Quà nồi cơm điện', 'Đổi 250 điểm nhận nồi cơm điện', '2024-12-02 00:00:00', '2024-12-25 23:59:59', 0.00, 1, NULL, 250),
('KM15', 'Giảm giá tủ lạnh Toshiba', 'Giảm giá 18% cho tủ lạnh Toshiba', '2024-12-15 00:00:00', '2025-01-30 23:59:59', 18.00, 1, 'SP15', 0);

CREATE TABLE CTKHthanthiet (
    MaChuongTrinh VARCHAR(50) PRIMARY KEY, 
    TenChuongTrinh VARCHAR(255) NOT NULL,  
    MaNhomKH VARCHAR(50), 
    ThoiGianBatDau DATE NOT NULL, 
    ThoiGianKetThuc DATE NOT NULL, 
    MoTa TEXT,
    FOREIGN KEY (MaNhomKH) REFERENCES nhomKH(MaNhomKH) 
);
-- Insert dữ liệu mẫu vào bảng ctkhthanthiet
INSERT INTO ctkhthanthiet (MaChuongTrinh, TenChuongTrinh, MaNhomKH, ThoiGianBatDau, ThoiGianKetThuc, MoTa)
VALUES 
('CT001', 'Khuyến mãi mùa hè', 'NKH01', '2024-06-01', '2024-06-30', 'Giảm giá 20% cho khách hàng thân thiết khi mua sản phẩm công nghệ.'),
('CT002', 'Giảm giá máy tính xách tay', 'NKH02', '2024-07-01', '2024-07-15', 'Ưu đãi 10% cho khách hàng tiềm năng mua laptop lần đầu.'),
('CT003', 'Tri ân khách hàng trung thành', 'NKH01', '2024-05-01', '2024-05-31', 'Tặng quà và ưu đãi cho khách hàng có lịch sử mua hàng lâu năm.'),
('CT004', 'Ưu đãi thiết bị mạng', 'NKH02', '2024-08-01', '2024-08-31', 'Giảm giá 15% cho thiết bị mạng khi đăng ký mua lần đầu.'),
('CT005', 'Mua điện thoại tặng tai nghe', 'NKH01', '2024-09-01', '2024-09-30', 'Khuyến mãi dành riêng cho khách hàng thân thiết khi mua điện thoại.'),
('CT006', 'Giảm giá phần mềm bảo mật', 'NKH01', '2024-10-01', '2024-10-31', 'Tặng mã giảm giá 30% cho phần mềm bảo mật khi mua sản phẩm.'),
('CT007', 'Chương trình giới thiệu bạn bè', 'NKH02', '2024-11-01', '2024-11-30', 'Tặng phiếu mua hàng cho khách hàng tiềm năng giới thiệu bạn bè.'),
('CT008', 'Ưu đãi lớn cuối năm', 'NKH01', '2024-12-01', '2024-12-31', 'Giảm giá 25% cho khách hàng thân thiết trong tháng cuối năm.'),
('CT009', 'Hội thảo công nghệ', 'NKH02', '2024-03-15', '2024-03-15', 'Mời khách hàng tiềm năng tham dự hội thảo giải pháp công nghệ.'),
('CT010', 'Quà tặng ngày công nghệ', 'NKH01', '2024-04-10', '2024-04-10', 'Phát quà miễn phí cho khách hàng thân thiết trong ngày kỷ niệm.');

ALTER TABLE hoadon
MODIFY COLUMN NgayXuatHoaDon DATE;
ALTER TABLE khieunai	
MODIFY COLUMN NgayKhieuNai DATE;
ALTER TABLE yeucautuvan
MODIFY COLUMN NgayGui DATE;
UPDATE yeucautuvan
SET 
    NoiDungYeuCau = 'Tôi muốn tư vấn iPhone XS Max',
    NgayGui = DATE_FORMAT(NgayGui, '%Y-%m-%d')
WHERE 
    MaYeuCau = 'YC001';
 
UPDATE yeucautuvan
SET 
    NoiDungYeuCau = 'Tôi có 5 triệu, mua được iPad loại nào?',
    NgayGui = DATE_FORMAT(NgayGui, '%Y-%m-%d')
WHERE 
    MaYeuCau = 'YC002';
 
UPDATE yeucautuvan
SET 
    NoiDungYeuCau = 'Tôi muốn tư vấn sản phẩm Samsung Galaxy S23',
    NgayGui = DATE_FORMAT(NgayGui, '%Y-%m-%d')
WHERE 
    MaYeuCau = 'YC003';
 
UPDATE yeucautuvan
SET 
    NoiDungYeuCau = 'Tôi cần tư vấn về MacBook Pro 14 inch',
    NgayGui = DATE_FORMAT(NgayGui, '%Y-%m-%d')
WHERE 
    MaYeuCau = 'YC004';
 
UPDATE yeucautuvan
SET 
    NoiDungYeuCau = 'Tôi muốn biết thêm về sản phẩm iPad Air 5',
    NgayGui = DATE_FORMAT(NgayGui, '%Y-%m-%d')
WHERE 
    MaYeuCau = 'YC005';
 
UPDATE yeucautuvan
SET 
    NoiDungYeuCau = 'Tư vấn về laptop Dell XPS 13',
    NgayGui = DATE_FORMAT(NgayGui, '%Y-%m-%d')
WHERE 
    MaYeuCau = 'YC006';
 
UPDATE yeucautuvan
SET 
    NoiDungYeuCau = 'Tôi muốn đổi trả sản phẩm Galaxy Tab S7',
    NgayGui = DATE_FORMAT(NgayGui, '%Y-%m-%d')
WHERE 
    MaYeuCau = 'YC007';
 
UPDATE yeucautuvan
SET 
    NoiDungYeuCau = 'Tôi cần tư vấn mua tai nghe Sony WH-1000XM5',
    NgayGui = DATE_FORMAT(NgayGui, '%Y-%m-%d')
WHERE 
    MaYeuCau = 'YC008';
 
UPDATE yeucautuvan
SET 
    NoiDungYeuCau = 'Tôi muốn biết thêm về các sản phẩm Apple Watch Series 8',
    NgayGui = DATE_FORMAT(NgayGui, '%Y-%m-%d')
WHERE 
    MaYeuCau = 'YC009';
 
UPDATE yeucautuvan
SET 
    NoiDungYeuCau = 'Tư vấn về sản phẩm máy tính bảng Microsoft Surface Pro 9',
    NgayGui = NgayGui
WHERE 
    MaYeuCau = 'YC010';
 
UPDATE yeucautuvan
SET 
    NoiDungYeuCau = 'Tôi muốn biết thêm về máy ảnh Canon EOS R6',
    NgayGui = NgayGui
WHERE 
    MaYeuCau = 'YC011';
 
UPDATE yeucautuvan
SET 
    NoiDungYeuCau = 'Tôi muốn mua máy chiếu Epson EH-TW7100, xin tư vấn',
    NgayGui = NgayGui
WHERE 
    MaYeuCau = 'YC012';
 
UPDATE yeucautuvan
SET 
    NoiDungYeuCau = 'Tư vấn về sản phẩm tai nghe Bose 700',
    NgayGui = NgayGui
WHERE 
    MaYeuCau = 'YC013';
 
UPDATE yeucautuvan
SET 
    NoiDungYeuCau = 'Tôi muốn biết thêm về sản phẩm điện thoại OnePlus 11',
    NgayGui = NgayGui
WHERE 
    MaYeuCau = 'YC014';
 
UPDATE yeucautuvan
SET 
    NoiDungYeuCau = 'Tư vấn về máy ảnh Sony Alpha A7 III',
    NgayGui = NgayGui
WHERE 
    MaYeuCau = 'YC015';
    
ALTER TABLE lichsutuvan
modify COLUMN ThoiGian DATE;

CREATE TABLE danhgiasaukhieunai (
    MaDanhGia INT AUTO_INCREMENT PRIMARY KEY,
    MaKhieuNai VARCHAR(50),
    DiemDanhGia INT CHECK (DiemDanhGia BETWEEN 1 AND 5), -- Thang điểm từ 1 đến 5
    BinhLuan TEXT,
    NgayDanhGia DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (MaKhieuNai) REFERENCES khieunai(MaKhieuNai) ON DELETE CASCADE
);
INSERT INTO danhgiasaukhieunai (MaKhieuNai, DiemDanhGia, BinhLuan)
VALUES
('KN001', 5, 'Dịch vụ rất tốt, nhân viên hỗ trợ nhiệt tình.'),
('KN002', 4, 'Quá trình xử lý ổn nhưng cần nhanh hơn.'),
('KN003', 3, 'Thời gian phản hồi chậm, cần cải thiện.'),
('KN004', 5, 'Rất hài lòng với cách xử lý vấn đề.'),
('KN005', 2, 'Không hài lòng, mất nhiều thời gian chờ đợi.'),
('KN006', 1, 'Quá tệ, vấn đề vẫn chưa được giải quyết.'),
('KN007', 4, 'Nhân viên hỗ trợ tốt nhưng cần thêm thông tin chi tiết.'),
('KN008', 3, 'Vấn đề được giải quyết nhưng mất nhiều công sức liên hệ.'),
('KN009', 5, 'Xử lý nhanh chóng, dịch vụ chuyên nghiệp.'),
('KN010', 2, 'Chưa thấy cải thiện sau khi khiếu nại.'),
('KN011', 4, 'Nhân viên dễ thương, hỗ trợ tận tình.'),
('KN012', 3, 'Chấp nhận được nhưng vẫn cần nâng cao chất lượng.'),
('KN013', 1, 'Không thấy phản hồi, rất thất vọng.'),
('KN014', 5, 'Rất tốt, hoàn toàn hài lòng với cách xử lý.'),
('KN015', 4, 'Dịch vụ khá ổn, vẫn có thể cải thiện thêm.')
;
ALTER TABLE danhgiasaukhieunai
ADD COLUMN TraLoiSauKhieuNai TEXT NULL;

UPDATE danhgiasaukhieunai
SET TraLoiSauKhieuNai = 
    CASE 
        WHEN MaDanhGia = 1 THEN 'Cảm ơn quý khách đã phản hồi tích cực!'
        WHEN MaDanhGia = 2 THEN 'Chúng tôi sẽ cải thiện thời gian xử lý.'
        WHEN MaDanhGia = 3 THEN 'Chân thành xin lỗi vì sự chậm trễ.'
        WHEN MaDanhGia = 4 THEN 'Cảm ơn quý khách đã tin tưởng dịch vụ của chúng tôi!'
        WHEN MaDanhGia = 5 THEN 'Chúng tôi đang làm việc để cải thiện hệ thống.'
        WHEN MaDanhGia = 6 THEN 'Rất xin lỗi, chúng tôi sẽ xử lý lại ngay.'
        WHEN MaDanhGia = 7 THEN 'Cảm ơn góp ý, chúng tôi sẽ cung cấp thêm thông tin chi tiết.'
        WHEN MaDanhGia = 8 THEN 'Chúng tôi sẽ cải thiện quá trình liên lạc.'
        WHEN MaDanhGia = 9 THEN 'Cảm ơn quý khách vì sự ủng hộ!'
        WHEN MaDanhGia = 10 THEN 'Chúng tôi rất tiếc, sẽ kiểm tra lại vấn đề này.'
        WHEN MaDanhGia = 11 THEN 'Cảm ơn phản hồi tích cực từ quý khách!'
        WHEN MaDanhGia = 12 THEN 'Chúng tôi ghi nhận và sẽ cải thiện hơn nữa.'
        WHEN MaDanhGia = 13 THEN 'Xin lỗi vì sự bất tiện, chúng tôi sẽ xử lý ngay.'
        WHEN MaDanhGia = 14 THEN 'Cảm ơn quý khách đã hài lòng với dịch vụ!'
        WHEN MaDanhGia = 15 THEN 'Chúng tôi sẽ cố gắng hoàn thiện dịch vụ hơn nữa.'
    END
WHERE MaDanhGia BETWEEN 1 AND 15;

ALTER TABLE danhgiasaukhieunai
modify COLUMN NgayDanhGia DATE;
ALTER TABLE phanhoi
modify COLUMN NgayPhanHoi DATE;
ALTER TABLE lichsubaohanh
modify COLUMN NgayKichHoat DATE;
alter table nhanvienhotro
modify column NgayBatDau date;

ALTER TABLE sanpham
MODIFY COLUMN gia INT UNSIGNED;


ALTER TABLE taikhoan ADD PhanQuyen VARCHAR(50);
UPDATE taikhoan SET PhanQuyen = 'Admin' WHERE TenDangNhap = 'NV03.lmn';
UPDATE taikhoan SET PhanQuyen = 'NhanVien' WHERE  TenDangNhap != 'NV03.lmn';

DROP TABLE IF EXISTS taikhoan;
-- Tạo bảng taikhoan
CREATE TABLE taikhoan (
    TenDangNhap Varchar(50) PRIMARY KEY, 
    MaNhanVien VARCHAR(50),           -- Mã nhân viên (khóa ngoại)
    MatKhau VARCHAR(255) NOT NULL,    -- Mật khẩu đăng nhập
    FOREIGN KEY (MaNhanVien) REFERENCES nhanvienhotro(MaNhanVien) -- Khóa ngoại liên kết với bảng nhanvienhotro
);                                                                                                                                         
INSERT INTO taikhoan (TenDangNhap, MaNhanVien, MatKhau) VALUES
('NV01.bvn', 'NV01', 'BVN123456'),
('NV02.thh', 'NV02', 'THH789012'),
('NV03.lmn', 'NV03', 'LMN345678'),
('NV04.ptd', 'NV04', 'PTD567890'),
('NV05.dqh', 'NV05', 'DQH234567'),
('NV06.vtl', 'NV06', 'VTL890123'),
('NV07.ngma', 'NV07', 'NGMA456789'),
('NV08.txn', 'NV08', 'TXN901234'),
('NV09.lhv', 'NV09', 'LHV678901'),
('NV10.hba', 'NV10', 'HBA234567');
ALTER TABLE taikhoan ADD COLUMN VaiTro ENUM('Admin', 'Staff') DEFAULT 'Staff';

-- Cập nhật vai trò cho tài khoản
UPDATE taikhoan SET VaiTro = 'Admin' WHERE TenDangNhap = 'NV03.lmn';
-- Những tài khoản còn lại là nhân viên
UPDATE taikhoan SET VaiTro = 'Staff' WHERE TenDangNhap != 'NV03.lmn';
