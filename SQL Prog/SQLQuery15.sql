 /****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [FeeID]
      ,[CourseRegID]
      ,[TotalAmount]
      ,[MinPer]
      ,[PaidAmount]
      ,[BalAmount]
      ,[PaidDate]
  FROM [Institute Reg].[dbo].[TableFeeDetail]