USE [QLTV_teamfriendly]
GO
/****** Object:  StoredProcedure [dbo].[LaySTTSachMuon]    Script Date: 04/25/2009 10:44:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LaySTTSachMuon] 
	
AS
	select Max(STT)
	from SachMuon


GO
/****** Object:  StoredProcedure [dbo].[spDelete_MuonSach_Ma]    Script Date: 04/25/2009 10:44:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDelete_MuonSach_Ma]
	@MaMuonSach int
AS
	DELETE
	FROM
		[MuonSach]
	WHERE					
		[MaMuonSach]=@MaMuonSach


GO
/****** Object:  StoredProcedure [dbo].[spDelete_NgonNgu]    Script Date: 04/25/2009 10:45:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDelete_NgonNgu]
(
	@Ma nchar(10),
	@Ten nvarchar(50)
	)
AS
	DELETE
	FROM
		[NgoNgu]
	WHERE					
		[Ma]=@Ma



GO
/****** Object:  StoredProcedure [dbo].[spDelete_NhaXB]    Script Date: 04/25/2009 10:45:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDelete_NhaXB]
	(
	@Ma nchar(10),
	@Ten nvarchar(50)
	)
AS
	DELETE
	FROM
		[NhaXB]
	WHERE					
		[Ma]=@Ma

GO
/****** Object:  StoredProcedure [dbo].[spDelete_Sach_Ma]    Script Date: 04/25/2009 10:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDelete_Sach_Ma]
	@Ma nchar(10)
AS
	DELETE
	FROM
		[Sach]
	WHERE					
		[Ma]=@Ma


GO
/****** Object:  StoredProcedure [dbo].[spDelete_SachHong]    Script Date: 04/25/2009 10:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDelete_SachHong] 
	@MaSach int
AS
	DELETE
	FROM
		[SachHong]
	WHERE					
		[MaSach]=@MaSach


GO
/****** Object:  StoredProcedure [dbo].[spDelete_SachMat]    Script Date: 04/25/2009 10:45:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDelete_SachMat]
	
	
	@MaSach nchar(10)
	
	
AS
	DELETE
	FROM
		[SachMat]
	WHERE					
		[MaSach]=@MaSach


GO
/****** Object:  StoredProcedure [dbo].[spDelete_TacGia]    Script Date: 04/25/2009 10:46:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDelete_TacGia]
	(
	@Ma nchar(10),
	@Ten nvarchar(50),
	@NgaySinh datetime
	)
AS
	DELETE
	FROM
		[TacGia]
	WHERE					
		[Ma]=@Ma


GO
/****** Object:  StoredProcedure [dbo].[spDeleteDenBuByID]    Script Date: 04/25/2009 10:46:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDeleteDenBuByID]
	@STT int
AS
	DELETE
	FROM
		[DenBu]
	WHERE					
		[STT]=@STT



GO
/****** Object:  StoredProcedure [dbo].[spDeleteLoaiSachByID]    Script Date: 04/25/2009 10:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDeleteLoaiSachByID]
	@Ma nchar(10)
AS
	DELETE
	FROM
		[LoaiSach]
	WHERE					
		[Ma]=@Ma


GO
/****** Object:  StoredProcedure [dbo].[spDeletePhatByID]    Script Date: 04/25/2009 10:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDeletePhatByID]
	(
	@STT int ,
	@MaSachMuon int,
	@SoNgay int,
	@ThanhTien int
	)
AS
	DELETE
	FROM
		[Phat]
	WHERE					
		[STT]=@STT

GO
/****** Object:  StoredProcedure [dbo].[spDeleteSachMuonByID]    Script Date: 04/25/2009 10:46:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDeleteSachMuonByID]
	@MaMuonSach int
AS
	DELETE
	FROM
		[SachMuon]
	WHERE					
		[MaMuonSach]=@MaMuonSach

GO
/****** Object:  StoredProcedure [dbo].[spDeleteTheByID]    Script Date: 04/25/2009 10:46:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDeleteTheByID]
	@Ma nchar(10) 
AS
	DELETE
	FROM
		[The]
	WHERE					
		[Ma]=@Ma


GO
/****** Object:  StoredProcedure [dbo].[spInsert_MuonSach]    Script Date: 04/25/2009 10:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsert_MuonSach]
	@MaMuonSach int ,
	@MaSach nvarchar(10) ,
	@MaThe nvarchar(10) ,
	@NgayMuon datetime ,
	@NgayHenTra datetime,
	@NgayTra datetime 
AS
	INSERT INTO [MuonSach] (
		[MaMuonSach],
		[MaSach] ,
		[MaThe],
		[NgayMuon],
		[NgayHenTra],
		[NgayTra]		)
	VALUES					(
		@MaMuonSach,
		@MaSach ,
		@MaThe,
		@NgayMuon,
		@NgayHenTra,
		@NgayTra		)


GO
/****** Object:  StoredProcedure [dbo].[spInsert_NgonNgu]    Script Date: 04/25/2009 10:47:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsert_NgonNgu] 
	(
	@Ma nchar(10),
	@Ten nvarchar(50)
	)
AS
	INSERT INTO [NgonNgu](
		[Ma],
		[Ten] 
			)
	VALUES					(
		@Ma,
		@Ten
				)

GO
/****** Object:  StoredProcedure [dbo].[spInsert_NhaXB]    Script Date: 04/25/2009 10:47:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsert_NhaXB]
	
	(
	@Ma nchar(10),
	@Ten nvarchar(50)
	)
	
AS
	INSERT INTO [NhaXB](
		[Ma] ,[Ten]
				)
	VALUES					(
		@Ma,@Ten
			)

GO
/****** Object:  StoredProcedure [dbo].[spInsert_Sach]    Script Date: 04/25/2009 10:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsert_Sach] 
	@Ma nchar(10) ,
	@Ten nvarchar(50) ,
	@LoaiSach nchar(10) ,
	@TacGia nchar(10) ,
	@Gia int ,
	@NgonNgu nchar(10) ,
	@NhaXB nchar(10) 
AS
	INSERT INTO [Sach] (
		[Ma],
		[Ten] ,
		[LoaiSach],
		[TacGia],
		[Gia],
		[NgonNgu]	,
		[NhaXB]	)
	VALUES	(
		@Ma  ,
		@Ten  ,
		@LoaiSach ,
		@TacGia ,
		@Gia ,
		@NgonNgu ,
		@NhaXB     )



GO
/****** Object:  StoredProcedure [dbo].[spInsert_SachHong]    Script Date: 04/25/2009 10:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsert_SachHong]
	@MaSach nchar(10),
	@STT int
AS
	INSERT INTO [SachHong] (
		[MaSach],
		[STT] 	)
	VALUES	(
		@MaSach  ,
		@STT    )

GO
/****** Object:  StoredProcedure [dbo].[spInsert_SachMat]    Script Date: 04/25/2009 10:47:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsert_SachMat]
	
	(
	
	@MaSach nchar(10),
	@STT int 
	)
	
AS
	INSERT INTO [SachMat](
		[MaSach],
		[STT] 
			)
	VALUES					(
		@MaSach,
		@STT
				)

GO
/****** Object:  StoredProcedure [dbo].[spInsert_TacGia]    Script Date: 04/25/2009 10:47:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsert_TacGia]
	
	(
	@Ma nchar(10),
	@Ten nvarchar(50),
	@NgaySinh datetime
	)
	
AS
INSERT INTO [TacGia](
		[Ma],
		[Ten] ,[NgaySinh]
			)
	VALUES					(
		@Ma,
		@Ten,
		@NgaySinh
				)


GO
/****** Object:  StoredProcedure [dbo].[spInsertDenBu]    Script Date: 04/25/2009 10:47:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertDenBu]
	@STT int,
	@MaMuonSach int ,
	@SoTien int 
AS
	INSERT INTO [DenBu] (
		[STT],
		[MaMuonSach] ,
		[SoTien]   )
		
	VALUES	(
		@STT ,
	    @MaMuonSach  ,
	    @SoTien    )


GO
/****** Object:  StoredProcedure [dbo].[spInsertLoaiSach]    Script Date: 04/25/2009 10:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertLoaiSach]
	@Ma nchar(10) ,
	@Ten nvarchar(50) 
AS
	INSERT INTO [LoaiSach] (
		[Ma],
		[Ten] 	)
	VALUES	(
		@Ma  ,
		@Ten )

GO
/****** Object:  StoredProcedure [dbo].[spInsertLoaiThe]    Script Date: 04/25/2009 10:48:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertLoaiThe]
	
	(
	@Ma nchar(10) ,
	@TenLoai nvarchar(50) 
	)
	
AS
	INSERT INTO [LoaiThe](
		[Ma],
		[TenLoai] 
				)
	VALUES					(
		@Ma,
		@TenLoai 	)


GO
/****** Object:  StoredProcedure [dbo].[spInsertPhat]    Script Date: 04/25/2009 10:48:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertPhat]
	(
	@STT int ,
	@MaSachMuon int,
	@SoNgay int,
	@ThanhTien int
	)
	
AS
	INSERT INTO [Phat](
		[STT] ,[MaSachMuon],[SoNgay] ,[ThanhTien]
				)
	VALUES					(
		@STT,
		@MaSachMuon,
		@SoNgay,
		@ThanhTien
			)


GO
/****** Object:  StoredProcedure [dbo].[spInsertSachMuon]    Script Date: 04/25/2009 10:48:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertSachMuon] 
	@STT int,
	@MaMuonSach int
AS
	INSERT INTO [SachMuon](
		[STT],
		[MaMuonSach] 
				)
	VALUES					(
		@STT,
		@MaMuonSach
			)


GO
/****** Object:  StoredProcedure [dbo].[spInsertThe]    Script Date: 04/25/2009 10:48:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertThe]
	
	(
	@Ma nchar(10) ,
	@LoaiThe nchar(10) ,
	@NgayCap datetime ,
	@NgayHetHan datetime ,
	@TenDocGia nvarchar(50) ,
	@NgaySinh datetime 
	)
	
	
AS
	INSERT INTO [The](
		[Ma],
		[LoaiThe] ,
		[NgayCap],
		[NgayHetHan],
		[TenDocGia],
		[NgaySinh]		)
	VALUES					(
		@Ma,
		@LoaiThe ,
		@NgayCap,
		@NgayHetHan,
		@TenDocGia,
		@NgaySinh		)

GO
/****** Object:  StoredProcedure [dbo].[spIs_SachHong]    Script Date: 04/25/2009 10:48:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIs_SachHong] 
	@MaSach nchar(10)
AS
	SELECT     STT, MaSach
	FROM         SachHong
	WHERE     (MaSach = @MaSach)


GO
/****** Object:  StoredProcedure [dbo].[spIs_SachMat]    Script Date: 04/25/2009 10:49:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIs_SachMat] 
		@MaSach nchar(10)
AS
	select *
	from  SachMat sm
	where sm.MaSach=@MaSach


GO
/****** Object:  StoredProcedure [dbo].[spIs_SachMuon]    Script Date: 04/25/2009 10:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIs_SachMuon] 
	@MaSach nchar(10)
AS
	select *
	from MuonSach ms, SachMuon sm
	where ms.MaMuonSach= sm.MaMuonSach and 
			ms.MaSach=@MaSach
	

GO
/****** Object:  StoredProcedure [dbo].[spLatSTT_DenBu]    Script Date: 04/25/2009 10:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spLatSTT_DenBu]
 
AS
	select max(STT)
	from DenBu


GO
/****** Object:  StoredProcedure [dbo].[spLay_SachDangMuon_byDocGiaID]    Script Date: 04/25/2009 10:49:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spLay_SachDangMuon_byDocGiaID]
	
		@MaThe nchar(10)
	
AS
		select MuonSach.MaSach as MaSach, Sach.Ten as TenSach,MuonSach.NgayMuon as NgayMuon, MuonSach.NgayHenTra as NgayHenTra
	from MuonSach,Sach, SachMuon
	where MuonSach.MaSach= Sach.Ma and  MuonSach.MaThe=@MaThe
	and SachMuon.MaMuonSach= MuonSach.MaMuonSach


GO
/****** Object:  StoredProcedure [dbo].[spLayDS_SachMuon_byDocGiaID]    Script Date: 04/25/2009 10:49:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spLayDS_SachMuon_byDocGiaID]
	@MaThe nchar(10)
AS
	select MuonSach.MaSach as MaSach, Sach.Ten as TenSach,MuonSach.NgayMuon as NgayMuon, MuonSach.NgayHenTra as NgayHenTra
	from MuonSach,Sach
	where MuonSach.MaSach= Sach.Ma and  MuonSach.MaThe=@MaThe
	


GO
/****** Object:  StoredProcedure [dbo].[spLayMaMuonSach]    Script Date: 04/25/2009 10:49:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spLayMaMuonSach] 
AS
	select Max(MaMuonSach)
	from [MuonSach]


GO
/****** Object:  StoredProcedure [dbo].[spLayMuonSach_byMaSach]    Script Date: 04/25/2009 10:49:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spLayMuonSach_byMaSach]
	@MaSach nchar(10)
AS
	select ms.MaMuonSach, ms.MaSach,ms.MaThe,ms.NgayMuon, ms.NgayHenTra, ms.NgayTra
	from MuonSach ms , SachMuon sm
	where ms.MaMuonSach= sm.MaMuonSach 
		and ms.MaSach= @MaSach


GO
/****** Object:  StoredProcedure [dbo].[spLaySTT_Phat]    Script Date: 04/25/2009 10:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spLaySTT_Phat]	 
AS
	select max(STT)
	from Phat
	

GO
/****** Object:  StoredProcedure [dbo].[spLaySTT_SachMat]    Script Date: 04/25/2009 10:50:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spLaySTT_SachMat] 
	
AS
		select Max(STT)
	from SachMat


GO
/****** Object:  StoredProcedure [dbo].[spSelectCountSach]    Script Date: 04/25/2009 10:50:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectCountSach]
	
AS
	Select count(*) from [Sach]


GO
/****** Object:  StoredProcedure [dbo].[spSelectDenBuAll]    Script Date: 04/25/2009 10:50:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectDenBuAll]
	AS
		SELECT
		[STT],
		[MaMuonSach] ,
		[SoTien]
	FROM
		[DenBu]

GO
/****** Object:  StoredProcedure [dbo].[spSelectLoaiSachAll]    Script Date: 04/25/2009 10:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectLoaiSachAll] 
	AS
	SELECT
		[Ma],
		[Ten] 
	FROM
		[LoaiSach]

GO
/****** Object:  StoredProcedure [dbo].[spSelectLoaiTheAll]    Script Date: 04/25/2009 10:51:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectLoaiTheAll]
	
AS
	select * from [LoaiThe]



GO
/****** Object:  StoredProcedure [dbo].[spSelectLoaiTheByID]    Script Date: 04/25/2009 10:51:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectLoaiTheByID] 
	
	@Ma nchar(10) 

AS
	select * from [LoaiThe] where [ma]=@Ma

GO
/****** Object:  StoredProcedure [dbo].[spSelectMaDenBu]    Script Date: 04/25/2009 10:51:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectMaDenBu] 
	@MaMuonSach int
AS
	SELECT
		[STT],
		[MaMuonSach] ,
		[SoTien]
	FROM
		[DenBu]
	WHERE					
		[MaMuonSach]=@MaMuonSach


GO
/****** Object:  StoredProcedure [dbo].[spSelectMaLoaiSach]    Script Date: 04/25/2009 10:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectMaLoaiSach] 
	@Ma nchar(10)
AS
	SELECT
		*
	FROM
		[LoaiSach]
	WHERE					
		[Ma]=@Ma

GO
/****** Object:  StoredProcedure [dbo].[spSelectMaMuonSach]    Script Date: 04/25/2009 10:51:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectMaMuonSach]
	@MaMuonSach int 
AS
	SELECT
		[MaMuonSach],
		[MaSach] ,
		[MaThe],
		[NgayMuon],
		[NgayHenTra],
		[NgayTra]
	FROM
		[MuonSach]
	WHERE					
		[MaMuonSach]=@MaMuonSach


GO
/****** Object:  StoredProcedure [dbo].[spSelectMaMuonSachDenBu]    Script Date: 04/25/2009 10:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectMaMuonSachDenBu]
	@MaMuonSach int
AS
	SELECT
		*
	FROM
		[DenBu]
	WHERE					
		[MaMuonSach] =@MaMuonSach


GO
/****** Object:  StoredProcedure [dbo].[spSelectMaSach]    Script Date: 04/25/2009 10:51:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectMaSach]
	@Ma nchar(10)
AS
	SELECT
		[Ma],
		[Ten] ,
		[LoaiSach],
		[TacGia],
		[Gia],
		[NgonNgu]	,
		[NhaXB]	
	FROM
		[Sach]
	WHERE					
		[Ma]=@Ma


GO
/****** Object:  StoredProcedure [dbo].[spSelectMuonSachAll]    Script Date: 04/25/2009 10:52:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectMuonSachAll]

AS
		SELECT
		[MaMuonSach],
		[MaSach] ,
		[MaThe],
		[NgayMuon],
		[NgayHenTra],
		[NgayTra]	
	FROM
		[MuonSach]

GO
/****** Object:  StoredProcedure [dbo].[spSelectMuonSachByMaSach]    Script Date: 04/25/2009 10:52:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectMuonSachByMaSach]
	@MaSach nvarchar(10)
AS
	select * 
	from 
	[MuonSach]
	 where 
	 [MaSach]=@MaSach


GO
/****** Object:  StoredProcedure [dbo].[spSelectNgonNguAll]    Script Date: 04/25/2009 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectNgonNguAll]

AS
select * from [NgonNgu]



GO
/****** Object:  StoredProcedure [dbo].[spSelectNgonNguByID]    Script Date: 04/25/2009 10:52:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectNgonNguByID]
(
@Ma nchar(10)
)

AS
select * from [NgonNgu] where [Ma]=@Ma



GO
/****** Object:  StoredProcedure [dbo].[spSelectNhaXBAll]    Script Date: 04/25/2009 10:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectNhaXBAll]
	AS
	SELECT
		[Ma],
		[Ten] 
	FROM
		[NhaXB]

GO
/****** Object:  StoredProcedure [dbo].[spSelectNhaXBByID]    Script Date: 04/25/2009 10:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectNhaXBByID] 
	@Ma nchar(10)
AS
	SELECT
		[Ma],
		[Ten] 
	FROM
		[NhaXB]
	WHERE					
		[Ma]=@Ma

GO
/****** Object:  StoredProcedure [dbo].[spSelectPhatAll]    Script Date: 04/25/2009 10:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectPhatAll]
	AS
select * from [Phat]


GO
/****** Object:  StoredProcedure [dbo].[spSelectPhatByID]    Script Date: 04/25/2009 10:53:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectPhatByID]
	@STT int
AS
	SELECT
		*
	FROM
		[Phat]
	WHERE					
		[STT] =@STT

GO
/****** Object:  StoredProcedure [dbo].[spSelectSachAll]    Script Date: 04/25/2009 10:53:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectSachAll]
	
AS
	SELECT
		[Ma],
		[Ten] ,
		[LoaiSach],
		[TacGia],
		[Gia],
		[NgonNgu]	,
		[NhaXB]	
	FROM
		[Sach]

GO
/****** Object:  StoredProcedure [dbo].[spSelectSachHongAll]    Script Date: 04/25/2009 10:53:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectSachHongAll]
	AS
	SELECT
		[MaSach],
		[STT] 
	FROM
		[SachHong]

GO
/****** Object:  StoredProcedure [dbo].[spSelectSachHongByID]    Script Date: 04/25/2009 10:53:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectSachHongByID]
	@MaSach int
AS
	SELECT
	    [MaSach] ,
		[STT]
	FROM
		[SachHong]
	WHERE					
		[MaSach]=@MaSach



GO
/****** Object:  StoredProcedure [dbo].[spSelectSachMatAll]    Script Date: 04/25/2009 10:53:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectSachMatAll]
	AS
	SELECT
		[MaSach],
		[STT] 
	FROM
		[SachMat]

GO
/****** Object:  StoredProcedure [dbo].[spSelectSachMatByID]    Script Date: 04/25/2009 10:53:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectSachMatByID] 
	@MaSach nchar(10)
AS
	SELECT
		[MaSach],
		[STT] 
	FROM
		[SachMat]
	WHERE					
		[MaSach]=@MaSach

GO
/****** Object:  StoredProcedure [dbo].[spSelectSachMuonAll]    Script Date: 04/25/2009 10:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectSachMuonAll] 
	@MaMuonSach int
AS
	select * from [SachMuon]


GO
/****** Object:  StoredProcedure [dbo].[spSelectSachMuonByID]    Script Date: 04/25/2009 10:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectSachMuonByID] 
	@MaMuonSach int
AS
	select * 
	from 
	[SachMuon]
	 where 
	 [MaMuonSach]=@MaMuonSach

GO
/****** Object:  StoredProcedure [dbo].[spSelectTacgiaAll]    Script Date: 04/25/2009 10:54:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectTacgiaAll]

AS
select * from [TacGia]

GO
/****** Object:  StoredProcedure [dbo].[spSelectTacGiaByID]    Script Date: 04/25/2009 10:54:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectTacGiaByID]
@Ma nchar(10)
AS
select * from [TacGia] where [Ma]=@Ma


GO
/****** Object:  StoredProcedure [dbo].[spSelectTheAll]    Script Date: 04/25/2009 10:54:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectTheAll] 
	
AS
	select * from [The]

GO
/****** Object:  StoredProcedure [dbo].[spSelectTheByID]    Script Date: 04/25/2009 10:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectTheByID]
	@Ma nchar(10) 
AS
	select * from [The] where [ma]=@Ma


GO
/****** Object:  StoredProcedure [dbo].[spUpdate_MuonSach]    Script Date: 04/25/2009 10:54:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdate_MuonSach]
	@MaMuonSach int ,
	@MaSach nvarchar(10) ,
	@MaThe nvarchar(10) ,
	@NgayMuon datetime ,
	@NgayHenTra datetime,
	@NgayTra datetime 
AS
	UPDATE [MuonSach] 
	SET		
		[MaSach]=@MaSach ,
		[MaThe]=@MaThe,
		[NgayMuon]=@NgayMuon,
		[NgayHenTra]=@NgayHenTra,
		[NgayTra]=@NgayTra
	WHERE					
		[MaMuonSach]=@MaMuonSach


GO
/****** Object:  StoredProcedure [dbo].[spUpdate_NgonNgu]    Script Date: 04/25/2009 10:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdate_NgonNgu]
	(
	@Ma nchar(10),
	@Ten nvarchar(50)
	)
AS
	UPDATE [NgonNgu] 
	SET		
		
		[Ten]=@Ten
		
	WHERE					
		[Ma]=@Ma

GO
/****** Object:  StoredProcedure [dbo].[spUpdate_NhaXB]    Script Date: 04/25/2009 10:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdate_NhaXB]
	(
	@Ma nchar(10),
	@Ten nvarchar(50)
	)
AS
	UPDATE [NhaXB] 
	SET		
		
		[Ten]=@Ten
		
	WHERE					
		[Ma]=@Ma



GO
/****** Object:  StoredProcedure [dbo].[spUpdate_Sach]    Script Date: 04/25/2009 10:54:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdate_Sach] 
	@Ma nchar(10) ,
	@Ten nvarchar(50) ,
	@LoaiSach nchar(10) ,
	@TacGia nchar(10) ,
	@Gia int ,
	@NgonNgu nchar(10) ,
	@NhaXB nchar(10) 
AS
	UPDATE [Sach] 
	SET		
		[Ma]=@Ma ,
		[Ten]=@Ten,
		[LoaiSach]=@LoaiSach,
		[TacGia]=@TacGia,
		[Gia]=@Gia,
		[NgonNgu]=@NgonNgu,
		[NhaXB]=@NhaXB
	WHERE					
		[Ma]=@Ma


GO
/****** Object:  StoredProcedure [dbo].[spUpdate_SachHong]    Script Date: 04/25/2009 10:55:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdate_SachHong]
	(
	@MaSach nchar(10),
	@STT int )
AS
	UPDATE [SachHong] 
	SET		
		[MaSach]=@MaSach,
		[STT]=@STT
		
	WHERE					
		[MaSach]=@MaSach


GO
/****** Object:  StoredProcedure [dbo].[spUpdate_SachMat]    Script Date: 04/25/2009 10:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdate_SachMat]
	(
	
	@MaSach nchar(10),
	@STT int 
	)
AS
	UPDATE [SachMat] 
	SET		
		
		[MaSach]=@MaSach,
		[STT]=@STT 
		
	WHERE					
		[MaSach]=@MaSach


GO
/****** Object:  StoredProcedure [dbo].[spUpdate_TacGia]    Script Date: 04/25/2009 10:55:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdate_TacGia]
	(
	@Ma nchar(10),
	@Ten nvarchar(50),
	@NgaySinh datetime
	)
AS
	UPDATE [TacGia] 
	SET		
		
		[Ten]=@Ten,
		[NgaySinh]=@NgaySinh
		
	WHERE					
		[Ma]=@Ma

GO
/****** Object:  StoredProcedure [dbo].[spUpdateDenBu]    Script Date: 04/25/2009 10:55:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateDenBu]
	@STT int,
	@MaMuonSach int ,
	@SoTien int 
AS
	UPDATE [DenBu] 
	SET		
		[STT]=@STT ,
		[MaMuonSach]=@MaMuonSach,
		[SoTien]=@SoTien
		
	WHERE					
		[STT]=@STT


GO
/****** Object:  StoredProcedure [dbo].[spUpdateLoaiSach]    Script Date: 04/25/2009 10:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateLoaiSach] 
	@Ma nchar(10) ,
	@Ten nvarchar(50)
AS
	UPDATE [LoaiSach] 
	SET		
		[Ma]=@Ma ,
		[Ten]=@Ten
		
	WHERE					
		[Ma]=@Ma


GO
/****** Object:  StoredProcedure [dbo].[spUpdateLoaiThe]    Script Date: 04/25/2009 10:55:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateLoaiThe]
	
	(
	@Ma nchar(10) ,
	@TenLoai nvarchar(50) 
	)
	
AS
	UPDATE [LoaiThe] 
	SET		
		
		[TenLoai]=@TenLoai
		
	WHERE					
		[Ma]=@Ma

GO
/****** Object:  StoredProcedure [dbo].[spUpdatePhat]    Script Date: 04/25/2009 10:55:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdatePhat]
	(
	@STT int ,
	@MaSachMuon int,
	@SoNgay int,
	@ThanhTien int
	)
AS
	UPDATE [Phat] 
	SET		
		
		[STT]=@STT,
		[MaSachMuon]=@MaSachMuon,
		[SoNgay]=@SoNgay,
		[ThanhTien]=@ThanhTien
		
	WHERE					
		[STT]=@STT

GO
/****** Object:  StoredProcedure [dbo].[spUpdateSachMuon]    Script Date: 04/25/2009 10:55:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateSachMuon]
	@MaMuonSach int
AS
	UPDATE [SachMuon] 
	SET		
		
		[MaMuonSach]=@MaMuonSach
		
	WHERE					
		[MaMuonSach]=@MaMuonSach


GO
/****** Object:  StoredProcedure [dbo].[spUpdateThe]    Script Date: 04/25/2009 10:55:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateThe]
	(
	@Ma nchar(10) ,
	@LoaiThe nchar(10) ,
	@NgayCap datetime ,
	@NgayHetHan datetime ,
	@TenDocGia nvarchar(50) ,
	@NgaySinh datetime 
	)
AS
	UPDATE [The] 
	SET		
		
		[LoaiThe]=@LoaiThe,
		[NgayCap]=@NgayCap,
		[NgayHetHan]=@NgayHetHan,
		[TenDocGia]=@TenDocGia,
		[NgaySinh]=@NgaySinh
	WHERE					
		[Ma]=@Ma


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectMuonSach_MaSach] 
	@MaSach nchar(10) 
AS
	SELECT
		
		[MaSach] 
		
	FROM
		[MuonSach]
	WHERE					
		[MaSach]=@MaSach

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectCheckLoaiSach]
	@LoaiSach nchar(10)
AS
	SELECT
		
		[LoaiSach]
		
	FROM
		[Sach]
	WHERE					
		[LoaiSach]=@LoaiSach

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectSachByLoaiSach]
	@LoaiSach nchar(10)
AS
	SELECT
		[Ma],
		[Ten] ,
		[LoaiSach],
		[TacGia],
		[Gia],
		[NgonNgu]	,
		[NhaXB]	
	FROM
		[Sach]
	WHERE					
		[LoaiSach]=@LoaiSach

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectTheByLoaiThe] 
(
@Ma nchar(10) 
)

AS
select * from [The]
where [LoaiThe]=@Ma 


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[spSelectSTTDenBu] 
	@STT nchar(10)
AS
	select *
	from DenBu
	Where MaMuonSach=STT
	
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDeleteLoaiTheByID]
	(
	@Ma nchar(10)
	)
AS
	DELETE
	FROM
		[LoaiThe]
	WHERE					
		[Ma]=@Ma
