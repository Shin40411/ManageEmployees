/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ID_Staff]
      ,[FullName]
      ,[Email]
      ,[Address]
      ,[Phone]
  FROM [StaffsMangement].[dbo].[Staffs]