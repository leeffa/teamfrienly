INSERT INTO [QLTV_teamfriendly].[dbo].[LoaiSach]           ([Ma]           ,[Ten]) 
    VALUES (N'STK' , N'Sách Tham Khảo')
INSERT INTO [QLTV_teamfriendly].[dbo].[LoaiSach]           ([Ma]           ,[Ten]) 
    VALUES (N'VHDG' , N', Văn học dân gian')
INSERT INTO [QLTV_teamfriendly].[dbo].[LoaiSach]           ([Ma]           ,[Ten]) 
    VALUES (N'TTHCM' , N'Tư tưởng HCM')
INSERT INTO [QLTV_teamfriendly].[dbo].[LoaiSach]           ([Ma]           ,[Ten]) 
    VALUES (N'PL' , N'Sách pháp luật')



INSERT INTO [QLTV_teamfriendly].[dbo].[LoaiThe]           ([Ma]           ,[TenLoai])
     VALUES(
	N'HS', N'Học Sinh'
	)
INSERT INTO [QLTV_teamfriendly].[dbo].[LoaiThe]           ([Ma]           ,[TenLoai])
     VALUES(
	N'GV', N'Giáo Viên'
	)

INSERT INTO [QLTV_teamfriendly].[dbo].[NgonNgu]           ([Ma]           ,[Ten])
     VALUES
           (N'ENG'
           ,N'Tiêng Anh')
INSERT INTO [QLTV_teamfriendly].[dbo].[NgonNgu]           ([Ma]           ,[Ten])
     VALUES
           (N'ENG'
           ,N'Tiêng Anh')
INSERT INTO [QLTV_teamfriendly].[dbo].[NgonNgu]           ([Ma]           ,[Ten])
     VALUES
           (N'VIE'
           ,N'Tiêng Việt')
INSERT INTO [QLTV_teamfriendly].[dbo].[NgonNgu]           ([Ma]           ,[Ten])
     VALUES
           (N'FRA'
           ,N'Tiêng Pháp')

INSERT INTO [QLTV_teamfriendly].[dbo].[NhaXB]           ([Ma]           ,[Ten])
     VALUES
           (N'KD'
           ,N'Kim Đồng')
INSERT INTO [QLTV_teamfriendly].[dbo].[NhaXB]           ([Ma]           ,[Ten])
     VALUES
           (N'NXB GD'
           ,N'Nhà XB Giáo Dục')
INSERT INTO [QLTV_teamfriendly].[dbo].[NhaXB]           ([Ma]           ,[Ten])
     VALUES
           (N'LDXH'
           ,N'Nàh XB Lao Động xã hội')


INSERT INTO [QLTV_teamfriendly].[dbo].[TacGia]           ([Ma]           ,[Ten]           ,[NgaySinh])
     VALUES
           (
	'0001',N'Ngưyễn Hưng','1/2/1988'
)
INSERT INTO [QLTV_teamfriendly].[dbo].[TacGia]           ([Ma]           ,[Ten]           ,[NgaySinh])
     VALUES
           (
	'0002',N'Ngưyễn Tuấn cảnh', '1/2/1988'
)
INSERT INTO [QLTV_teamfriendly].[dbo].[TacGia]           ([Ma]           ,[Ten]           ,[NgaySinh])
     VALUES
           (
	'0003',N'Kim Dung','1/2/1988'
)


INSERT INTO [QLTV_teamfriendly].[dbo].[Sach]
           ([Ma]
           ,[Ten]
           ,[LoaiSach]
           ,[TacGia]
           ,[Gia]
           ,[NgonNgu]
           ,[NhaXB])
     VALUES
           ('00001'
           ,N'Lập trinh C'
           ,N'STK' 
           ,'0002'
           ,100000
           ,'VIE'
           ,'NSX GD'

)INSERT INTO [QLTV_teamfriendly].[dbo].[Sach]
           ([Ma]
           ,[Ten]
           ,[LoaiSach]
           ,[TacGia]
           ,[Gia]
           ,[NgonNgu]
           ,[NhaXB])
     VALUES
           ('00004'
           ,N'Lập trinh C++'
           ,N'STK' 
           ,'0002'
           ,100000
           ,'VIE'
           ,'NSX GD'

)
INSERT INTO [QLTV_teamfriendly].[dbo].[Sach]
           ([Ma]
           ,[Ten]
           ,[LoaiSach]
           ,[TacGia]
           ,[Gia]
           ,[NgonNgu]
           ,[NhaXB])
     VALUES
           ('00005'
           ,N'Lập trinh VB.NET'
           ,N'STK' 
           ,'0002'
           ,100000
           ,'VIE'
           ,'NSX GD'

)


INSERT INTO [QLTV_teamfriendly].[dbo].[The]
           ([Ma]
           ,[LoaiThe]
           ,[NgayCap]
           ,[NgayHetHan]
           ,[TenDocGia]
           ,[NgaySinh])
     VALUES
           (N'The_0001'
           ,'GV'
           ,'1/2/2009'
           ,'12/2/2009'
           ,N'Nguyễn sinh '
           ,'2/3/1988')
INSERT INTO [QLTV_teamfriendly].[dbo].[The]
           ([Ma]
           ,[LoaiThe]
           ,[NgayCap]
           ,[NgayHetHan]
           ,[TenDocGia]
           ,[NgaySinh])
     VALUES
           (N'The_0006'
           ,'GV'
           ,'1/2/2009'
           ,'12/2/2009'
           ,N'Nguyễn Hồng Nhanh '
           ,'2/3/1988')
INSERT INTO [QLTV_teamfriendly].[dbo].[The]
           ([Ma]
           ,[LoaiThe]
           ,[NgayCap]
           ,[NgayHetHan]
           ,[TenDocGia]
           ,[NgaySinh])
     VALUES
           (N'The_00032'
           ,'HS'
           ,'1/2/2009'
           ,'12/2/2009'
           ,N'Phạm Tuấn Cảnh '
           ,'2/3/1978')
