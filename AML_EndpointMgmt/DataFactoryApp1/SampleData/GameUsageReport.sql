SET ANSI_NULLS ON
GO;

SET QUOTED_IDENTIFIER ON
GO;

SET ANSI_PADDING ON
GO;

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'GameUsageReportSqlToBlob')
DROP TABLE [dbo].[GameUsageReportSqlToBlob];
GO;

CREATE TABLE [dbo].[GameUsageReportSqlToBlob](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [ProfileID] [varchar](256) NOT NULL,
    [SessionStart] [varchar](256) NOT NULL,
    [Duration] [varchar](256) NOT NULL,
    [State] [varchar](256) NOT NULL,
    [SrcIPAddress] [varchar](256) NOT NULL,
    [GameType] [varchar](256) NOT NULL,
    [Multiplayer] [varchar](256) NOT NULL,
    [EndRank] [varchar](256) NOT NULL,
    [WeaponsUsed] [varchar](256) NOT NULL,
    [UsersInteractedWith] [varchar](256) NOT NULL,
    CONSTRAINT [PK_GameUsageReportSqlToBlob] PRIMARY KEY CLUSTERED 
	(
	    [Id] ASC
	)
 )
GO;


INSERT [dbo].[GameUsageReportSqlToBlob] ([ProfileID], [SessionStart], [Duration], [State], [SrcIPAddress], [GameType], [Multiplayer], [EndRank], [WeaponsUsed], [UsersInteractedWith]) VALUES (N'2274', N'2014-05-04 07:51:20.3520000', N'10', N'Tennessee', N'77.143.3.', N'KingHill', N'true', N'15', N'4', N'2215'),
 ( N'2130', N'2015-05-04 22:15:25.1250000', N'13', N'New Mexico', N'215.83.253.', N'CaptureFlag', N'true', N'20', N'2', N'2160'),
 ( N'1809', N'2015-05-04 12:04:25.3470000', N'14', N'South Carolina', N'221.117.223.', N'CaptureFlag', N'true', N'1', N'3', N'1575'),
 ( N'1809', N'2015-05-04 12:04:25.3470000', N'14', N'South Carolina', N'221.117.223.', N'CaptureFlag', N'true', N'1', N'3', N'1575'),
 ( N'1638', N'2015-05-04 20:01:30.2290000', N'9', N'California', N'225.97.195.', N'CaptureFlag', N'true', N'4', N'2', N'1608'),
 ( N'1638', N'2015-05-04 20:01:30.2290000', N'9', N'California', N'225.97.195.', N'CaptureFlag', N'true', N'4', N'2', N'1608'),
 ( N'2082', N'2015-05-04 17:20:54.2260000', N'107', N'California', N'230.197.22.', N'KingHill', N'true', N'23', N'4', N'2096-2292'),
 ( N'2082', N'2015-05-04 17:20:54.2260000', N'107', N'California', N'230.197.22.', N'KingHill', N'true', N'23', N'4', N'2096-2292'),
 ( N'1865', N'2015-05-04 02:32:31.1050000', N'115', N'North Carolina', N'238.24.113.', N'CaptureFlag', N'true', N'14', N'5', N'1896-1742'),
 ( N'1865', N'2015-05-04 02:32:31.1050000', N'115', N'North Carolina', N'238.24.113.', N'CaptureFlag', N'true', N'14', N'5', N'1896-1742'),
 ( N'2191', N'2015-05-04 12:40:31.0190000', N'22', N'Pennsylvania', N'238.81.242.', N'KingHill', N'true', N'21', N'1', N'2065-1907'),
 ( N'2191', N'2015-05-04 12:40:31.0190000', N'22', N'Pennsylvania', N'238.81.242.', N'KingHill', N'true', N'21', N'1', N'2065-1907'),
 ( N'1986', N'2015-05-04 13:33:29.0150000', N'206', N'Maryland', N'239.123.23.', N'KingHill', N'true', N'16', N'6', N'1984-1926-1947-1956-1999'),
 ( N'1986', N'2015-05-04 13:33:29.0150000', N'206', N'Maryland', N'239.123.23.', N'KingHill', N'true', N'16', N'6', N'1984-1926-1947-1956-1999'),
 ( N'2079', N'2015-05-04 21:03:36.1360000', N'23', N'North Carolina', N'244.140.79.', N'KingHill', N'true', N'9', N'5', N'2277-2100'),
 ( N'2079', N'2015-05-04 21:03:36.1360000', N'23', N'North Carolina', N'244.140.79.', N'KingHill', N'true', N'9', N'5', N'2277-2100'),
 ( N'1821', N'2015-05-04 16:45:44.3740000', N'204', N'West Virginia', N'251.248.211.', N'CaptureFlag', N'true', N'19', N'1', N'2029-1955-1811-1971-1968'),
 ( N'1821', N'2015-05-04 16:45:44.3740000', N'204', N'West Virginia', N'251.248.211.', N'CaptureFlag', N'true', N'19', N'1', N'2029-1955-1811-1971-1968'),
 ( N'1913', N'2015-05-04 02:20:56.4630000', N'5', N'Georgia', N'253.190.51.', N'CaptureFlag', N'true', N'18', N'6', N'1900'),
 ( N'1913', N'2015-05-04 02:20:56.4630000', N'5', N'Georgia', N'253.190.51.', N'CaptureFlag', N'true', N'18', N'6', N'1900'),
 ( N'1735', N'2015-05-04 03:22:16.3630000', N'19', N'Michigan', N'45.155.142.', N'KingHill', N'true', N'19', N'6', N'1834-1812'),
 ( N'1735', N'2015-05-04 03:22:16.3630000', N'19', N'Michigan', N'45.155.142.', N'KingHill', N'true', N'19', N'6', N'1834-1812'),
 ( N'1876', N'2015-05-04 07:39:07.3300000', N'61', N'South Dakota', N'47.121.206.', N'CaptureFlag', N'true', N'16', N'2', N'2052-1927'),
 ( N'1876', N'2015-05-04 07:39:07.3300000', N'61', N'South Dakota', N'47.121.206.', N'CaptureFlag', N'true', N'16', N'2', N'2052-1927'),
 ( N'2166', N'2015-05-04 07:10:38.3430000', N'77', N'Texas', N'49.210.243.', N'KingHill', N'true', N'23', N'4', N'2278-2253'),
 ( N'2166', N'2015-05-04 07:10:38.3430000', N'77', N'Texas', N'49.210.243.', N'KingHill', N'true', N'23', N'4', N'2278-2253'),
 ( N'1866', N'2015-05-04 16:21:27.4680000', N'22', N'Arizona', N'66.246.194.', N'CaptureFlag', N'true', N'11', N'4', N'1823-1852'),
 ( N'1373', N'2015-05-03 17:18:47.0690000', N'4', N'Oregon', N'154.86.111.', N'CaptureFlag', N'true', N'67', N'3', N'1306'),
 ( N'1285', N'2015-05-03 19:27:12.4970000', N'198', N'Pennsylvania', N'158.204.88.', N'KingHill', N'true', N'59', N'6', N'1353-1392-1272-1326'),
 ( N'1285', N'2015-05-03 19:27:12.4970000', N'198', N'Pennsylvania', N'158.204.88.', N'KingHill', N'true', N'59', N'6', N'1353-1392-1272-1326'),
 ( N'1441', N'2015-05-03 07:22:00.2670000', N'88', N'North Carolina', N'159.44.207.', N'CaptureFlag', N'true', N'12', N'5', N'1490-1471'),
 ( N'1441', N'2015-05-03 07:22:00.2670000', N'88', N'North Carolina', N'159.44.207.', N'CaptureFlag', N'true', N'12', N'5', N'1490-1471'),
 ( N'1591', N'2015-05-03 01:16:37.0220000', N'13', N'Oregon', N'161.88.223.', N'CaptureFlag', N'true', N'17', N'4', N'1489'),
 ( N'1591', N'2015-05-03 01:16:37.0220000', N'13', N'Oregon', N'161.88.223.', N'CaptureFlag', N'true', N'17', N'4', N'1489'),
 ( N'1700', N'2015-05-03 10:56:40.4830000', N'221', N'District Of Columbia', N'163.183.28.', N'KingHill', N'true', N'10', N'2', N'1679-1609-1589-1706-1603'),
 ( N'1700', N'2015-05-03 10:56:40.4830000', N'221', N'District Of Columbia', N'163.183.28.', N'KingHill', N'true', N'10', N'2', N'1679-1609-1589-1706-1603'),
 ( N'1268', N'2015-05-03 20:33:35.0710000', N'119', N'Illinois', N'168.173.107.', N'CaptureFlag', N'true', N'137', N'1', N'1351-1361'),
 ( N'1268', N'2015-05-03 20:33:35.0710000', N'119', N'Illinois', N'168.173.107.', N'CaptureFlag', N'true', N'137', N'1', N'1351-1361'),
 ( N'1603', N'2015-05-03 15:53:15.3200000', N'13', N'Oklahoma', N'169.50.142.', N'KingHill', N'true', N'17', N'4', N'1698'),
 ( N'1603', N'2015-05-03 15:53:15.3200000', N'13', N'Oklahoma', N'169.50.142.', N'KingHill', N'true', N'17', N'4', N'1698'),
 ( N'1280', N'2015-05-03 09:25:31.2480000', N'205', N'South Dakota', N'170.130.16.', N'KingHill', N'true', N'199', N'1', N'1115-1388-1256-1306-1122'),
 ( N'1280', N'2015-05-03 09:25:31.2480000', N'205', N'South Dakota', N'170.130.16.', N'KingHill', N'true', N'199', N'1', N'1115-1388-1256-1306-1122'),
 ( N'1333', N'2015-05-03 17:50:33.1920000', N'77', N'Massachusetts', N'170.252.77.', N'KingHill', N'true', N'37', N'2', N'1452-1540'),
 ( N'1333', N'2015-05-03 17:50:33.1920000', N'77', N'Massachusetts', N'170.252.77.', N'KingHill', N'true', N'37', N'2', N'1452-1540'),
 ( N'1125', N'2015-05-03 17:17:07.3510000', N'214', N'Connecticut', N'174.102.240.', N'KingHill', N'true', N'115', N'5', N'1118-1377-1208-1200-1254'),
 ( N'1125', N'2015-05-03 17:17:07.3510000', N'214', N'Connecticut', N'174.102.240.', N'KingHill', N'true', N'115', N'5', N'1118-1377-1208-1200-1254'),
 ( N'1613', N'2015-05-03 09:44:56.3490000', N'204', N'Utah', N'174.106.175.', N'KingHill', N'true', N'22', N'3', N'1617-1719-1732-1535-1612'),
 ( N'873', N'2015-05-02 16:49:12.4400000', N'6', N'Iowa', N'182.74.94.', N'CaptureFlag', N'true', N'51', N'6', N'832'),
 ( N'815', N'2015-05-02 10:21:03.0120000', N'19', N'West Virginia', N'185.15.136.', N'CaptureFlag', N'true', N'42', N'3', N'673-621'),
 ( N'815', N'2015-05-02 10:21:03.0120000', N'19', N'West Virginia', N'185.15.136.', N'CaptureFlag', N'true', N'42', N'3', N'673-621'),
 ( N'682', N'2015-05-02 14:00:10.3320000', N'16', N'District Of Columbia', N'186.186.98.', N'KingHill', N'true', N'122', N'5', N'866'),
 ( N'682', N'2015-05-02 14:00:10.3320000', N'16', N'District Of Columbia', N'186.186.98.', N'KingHill', N'true', N'122', N'5', N'866'),
 ( N'1003', N'2015-05-02 07:33:24.4810000', N'88', N'Wisconsin', N'188.161.28.', N'KingHill', N'true', N'165', N'1', N'886-884'),
 ( N'1003', N'2015-05-02 07:33:24.4810000', N'88', N'Wisconsin', N'188.161.28.', N'KingHill', N'true', N'165', N'1', N'886-884'),
 ( N'1214', N'2015-05-02 15:30:15.3890000', N'14', N'Minnesota', N'189.192.6.', N'CaptureFlag', N'true', N'84', N'5', N'1032'),
 ( N'1214', N'2015-05-02 15:30:15.3890000', N'14', N'Minnesota', N'189.192.6.', N'CaptureFlag', N'true', N'84', N'5', N'1032'),
 ( N'656', N'2015-05-02 14:33:11.2710000', N'33', N'Maryland', N'193.188.36.', N'KingHill', N'true', N'35', N'2', N'777-817'),
 ( N'656', N'2015-05-02 14:33:11.2710000', N'33', N'Maryland', N'193.188.36.', N'KingHill', N'true', N'35', N'2', N'777-817'),
 ( N'832', N'2015-05-02 01:10:27.0240000', N'206', N'Iowa', N'199.30.46.', N'CaptureFlag', N'true', N'165', N'3', N'820-946-808-755-807'),
 ( N'832', N'2015-05-02 01:10:27.0240000', N'206', N'Iowa', N'199.30.46.', N'CaptureFlag', N'true', N'165', N'3', N'820-946-808-755-807'),
 ( N'1033', N'2015-05-02 15:56:12.2650000', N'205', N'Maryland', N'206.32.152.', N'KingHill', N'true', N'102', N'3', N'849-789-808-966-935'),
 ( N'1033', N'2015-05-02 15:56:12.2650000', N'205', N'Maryland', N'206.32.152.', N'KingHill', N'true', N'102', N'3', N'849-789-808-966-935'),
 ( N'802', N'2015-05-02 01:32:43.4100000', N'13', N'New Hampshire', N'207.125.1.', N'CaptureFlag', N'true', N'12', N'4', N'705'),
 ( N'802', N'2015-05-02 01:32:43.4100000', N'13', N'New Hampshire', N'207.125.1.', N'CaptureFlag', N'true', N'12', N'4', N'705'),
 ( N'863', N'2015-05-02 22:36:33.4260000', N'24', N'Connecticut', N'210.222.58.', N'KingHill', N'true', N'89', N'6', N'730-896'),
 ( N'863', N'2015-05-02 22:36:33.4260000', N'24', N'Connecticut', N'210.222.58.', N'KingHill', N'true', N'89', N'6', N'730-896'),
 ( N'782', N'2015-05-02 21:57:13.3170000', N'28', N'Michigan', N'214.94.222.', N'CaptureFlag', N'true', N'113', N'2', N'778-706'),
 ( N'460', N'2015-05-01 10:57:17.0040000', N'5', N'Nebraska', N'67.217.232.', N'CaptureFlag', N'true', N'112', N'6', N'309'),
 ( N'463', N'2015-05-01 08:56:24.2410000', N'14', N'Utah', N'78.149.188.', N'CaptureFlag', N'true', N'98', N'4', N'334'),
 ( N'463', N'2015-05-01 08:56:24.2410000', N'14', N'Utah', N'78.149.188.', N'CaptureFlag', N'true', N'98', N'4', N'334'),
 ( N'368', N'2015-05-01 13:02:45.2580000', N'120', N'New Hampshire', N'101.140.197.', N'KingHill', N'true', N'10', N'6', N'331-310'),
 ( N'368', N'2015-05-01 13:02:45.2580000', N'120', N'New Hampshire', N'101.140.197.', N'KingHill', N'true', N'10', N'6', N'331-310'),
 ( N'477', N'2015-05-01 14:44:56.3170000', N'6', N'Vermont', N'109.231.196.', N'CaptureFlag', N'true', N'24', N'2', N'530'),
 ( N'477', N'2015-05-01 14:44:56.3170000', N'6', N'Vermont', N'109.231.196.', N'CaptureFlag', N'true', N'24', N'2', N'530'),
 ( N'425', N'2015-05-01 16:45:53.2590000', N'2', N'Kentucky', N'121.102.220.', N'KingHill', N'true', N'182', N'1', N'499'),
 ( N'425', N'2015-05-01 16:45:53.2590000', N'2', N'Kentucky', N'121.102.220.', N'KingHill', N'true', N'182', N'1', N'499'),
 ( N'544', N'2015-05-01 12:08:05.0460000', N'207', N'Michigan', N'129.180.152.', N'KingHill', N'true', N'180', N'1', N'541-733-576-745-655'),
 ( N'544', N'2015-05-01 12:08:05.0460000', N'207', N'Michigan', N'129.180.152.', N'KingHill', N'true', N'180', N'1', N'541-733-576-745-655'),
 ( N'237', N'2015-05-01 03:43:31.1460000', N'200', N'Texas', N'137.112.221.', N'KingHill', N'true', N'42', N'2', N'217-366-471-251'),
 ( N'237', N'2015-05-01 03:43:31.1460000', N'200', N'Texas', N'137.112.221.', N'KingHill', N'true', N'42', N'2', N'217-366-471-251'),
 ( N'562', N'2015-05-01 21:37:04.1990000', N'20', N'North Carolina', N'150.119.214.', N'KingHill', N'true', N'144', N'5', N'637-652'),
 ( N'562', N'2015-05-01 21:37:04.1990000', N'20', N'North Carolina', N'150.119.214.', N'KingHill', N'true', N'144', N'5', N'637-652'),
 ( N'152', N'2015-05-01 22:51:37.0810000', N'10', N'Oklahoma', N'157.132.215.', N'KingHill', N'true', N'194', N'3', N'94'),
 ( N'152', N'2015-05-01 22:51:37.0810000', N'10', N'Oklahoma', N'157.132.215.', N'KingHill', N'true', N'194', N'3', N'94'),
 ( N'730', N'2015-05-01 09:21:43.0010000', N'21', N'Colorado', N'158.109.114.', N'KingHill', N'true', N'120', N'2', N'671-500'),
 ( N'730', N'2015-05-01 09:21:43.0010000', N'21', N'Colorado', N'158.109.114.', N'KingHill', N'true', N'120', N'2', N'671-500'),
 ( N'470', N'2015-05-01 12:39:29.1720000', N'10', N'Florida', N'169.164.197.', N'CaptureFlag', N'true', N'42', N'6', N'330'),
 ( N'470', N'2015-05-01 12:39:29.1720000', N'10', N'Florida', N'169.164.197.', N'CaptureFlag', N'true', N'42', N'6', N'330'),
 ( N'323', N'2015-05-01 22:53:22.1150000', N'38', N'Alabama', N'170.243.155.', N'KingHill', N'true', N'66', N'2', N'280-295'),
 ( N'323', N'2015-05-01 22:53:22.1150000', N'38', N'Alabama', N'170.243.155.', N'KingHill', N'true', N'66', N'2', N'280-295'),
 ( N'157', N'2015-05-01 21:21:04.0690000', N'3', N'Hawaii', N'177.139.125.', N'KingHill', N'true', N'36', N'5', N'429'),
 ( N'157', N'2015-05-01 21:21:04.0690000', N'3', N'Hawaii', N'177.139.125.', N'KingHill', N'true', N'36', N'5', N'429'),
 ( N'669', N'2015-05-01 01:45:07.4380000', N'92', N'Maine', N'184.121.198.', N'KingHill', N'true', N'79', N'1', N'759-557'),
 ( N'669', N'2015-05-01 01:45:07.4380000', N'92', N'Maine', N'184.121.198.', N'KingHill', N'true', N'79', N'1', N'759-557'),
 ( N'494', N'2015-05-01 05:38:46.2810000', N'82', N'Pennsylvania', N'189.254.140.', N'CaptureFlag', N'true', N'98', N'6', N'597-411'),
 ( N'494', N'2015-05-01 05:38:46.2810000', N'82', N'Pennsylvania', N'189.254.140.', N'CaptureFlag', N'true', N'98', N'6', N'597-411'),
 ( N'279', N'2015-05-01 20:42:52.4430000', N'24', N'Alaska', N'201.228.190.', N'KingHill', N'true', N'101', N'3', N'149-118'),
 ( N'279', N'2015-05-01 20:42:52.4430000', N'24', N'Alaska', N'201.228.190.', N'KingHill', N'true', N'101', N'3', N'149-118'),
 ( N'743', N'2015-05-01 16:08:29.0010000', N'20', N'Pennsylvania', N'208.233.180.', N'KingHill', N'true', N'172', N'5', N'552-714'),
 ( N'743', N'2015-05-01 16:08:29.0010000', N'20', N'Pennsylvania', N'208.233.180.', N'KingHill', N'true', N'172', N'5', N'552-714'),
 ( N'317', N'2015-05-01 13:24:33.3550000', N'12', N'Wisconsin', N'214.134.254.', N'KingHill', N'true', N'58', N'6', N'397'),
 ( N'317', N'2015-05-01 13:24:33.3550000', N'12', N'Wisconsin', N'214.134.254.', N'KingHill', N'true', N'58', N'6', N'397'),
 ( N'500', N'2015-05-01 02:34:48.0220000', N'204', N'Alabama', N'217.131.139.', N'CaptureFlag', N'true', N'24', N'5', N'389-442-506-361-538'),
 ( N'500', N'2015-05-01 02:34:48.0220000', N'204', N'Alabama', N'217.131.139.', N'CaptureFlag', N'true', N'24', N'5', N'389-442-506-361-538'),
 ( N'466', N'2015-05-01 18:22:38.0260000', N'3', N'New Hampshire', N'230.205.240.', N'KingHill', N'true', N'36', N'1', N'658'),
 ( N'466', N'2015-05-01 18:22:38.0260000', N'3', N'New Hampshire', N'230.205.240.', N'KingHill', N'true', N'36', N'1', N'658'),
 ( N'224', N'2015-05-01 01:05:31.4630000', N'214', N'Georgia', N'237.220.252.', N'KingHill', N'true', N'23', N'6', N'286-374-418-426-403'),
 ( N'224', N'2015-05-01 01:05:31.4630000', N'214', N'Georgia', N'237.220.252.', N'KingHill', N'true', N'23', N'6', N'286-374-418-426-403'),
 ( N'230', N'2015-05-01 02:45:58.0350000', N'218', N'Indiana', N'242.228.246.', N'KingHill', N'true', N'137', N'1', N'189-254-211-278-257'),
 ( N'230', N'2015-05-01 02:45:58.0350000', N'218', N'Indiana', N'242.228.246.', N'KingHill', N'true', N'137', N'1', N'189-254-211-278-257'),
 ( N'513', N'2015-05-01 20:13:36.3850000', N'197', N'Tennessee', N'254.221.232.', N'KingHill', N'true', N'60', N'1', N'466-496-608-601'),
 ( N'513', N'2015-05-01 20:13:36.3850000', N'197', N'Tennessee', N'254.221.232.', N'KingHill', N'true', N'60', N'1', N'466-496-608-601')
SET IDENTITY_INSERT [dbo].[GameUsageReportSqlToBlob] OFF
