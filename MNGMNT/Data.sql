USE [CRMS]
GO
SET IDENTITY_INSERT [dbo].[tblEmployee] ON 

INSERT [dbo].[tblEmployee] ([EmployeeID], [EmployeeName], [Designation]) VALUES (1, N'Jhon Wick', N'Analysis / Developer')
INSERT [dbo].[tblEmployee] ([EmployeeID], [EmployeeName], [Designation]) VALUES (2, N'J Kerr', N'Tech Lead')
SET IDENTITY_INSERT [dbo].[tblEmployee] OFF
SET IDENTITY_INSERT [dbo].[tblProduct] ON 

INSERT [dbo].[tblProduct] ([PortfolioID], [ProductOwner], [NameofProduct], [LaunchedDate], [AnalysisID], [ProductStatus], [ProductDuration], [CancledReason], [ProductLifeCycle], [Description]) VALUES (1, N'dfd', N'dfd', CAST(0x0000AA13009CFB1C AS DateTime), N'1', N'1', N'fdf', N'N/A', N'fdf', N'df')
SET IDENTITY_INSERT [dbo].[tblProduct] OFF
SET IDENTITY_INSERT [dbo].[tblProductStatus] ON 

INSERT [dbo].[tblProductStatus] ([ProductStatus], [StatusId]) VALUES (N'Started', 1)
INSERT [dbo].[tblProductStatus] ([ProductStatus], [StatusId]) VALUES (N'Pending', 2)
INSERT [dbo].[tblProductStatus] ([ProductStatus], [StatusId]) VALUES (N'Finished', 3)
INSERT [dbo].[tblProductStatus] ([ProductStatus], [StatusId]) VALUES (N'On Implementation', 4)
SET IDENTITY_INSERT [dbo].[tblProductStatus] OFF
