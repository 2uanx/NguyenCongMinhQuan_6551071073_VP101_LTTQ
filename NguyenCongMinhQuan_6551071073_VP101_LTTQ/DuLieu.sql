
CREATE DATABASE DuLieu;
GO

USE DuLieu;
GO

CREATE TABLE CongViec (
    MaCongViec NVARCHAR(10) NOT NULL PRIMARY KEY,
    TenCongViec NTEXT NOT NULL,
    LuongThang NVARCHAR(8) NOT NULL
);
GO

INSERT INTO CongViec (MaCongViec, TenCongViec, LuongThang) VALUES 
(N'cv1', N'Bán hàng', N'5000000'),
(N'cv2', N'Vệ sinh', N'2500000');
GO

SELECT * FROM CongViec;
GO
