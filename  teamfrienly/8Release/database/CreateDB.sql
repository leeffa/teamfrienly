USE [master]
GO
IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'QLTV_teamfriendly')
DROP  DATABASE   [QLTV_teamfriendly]
CREATE DATABASE [QLTV_teamfriendly]
