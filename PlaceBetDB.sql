CREATE DATABASE PlaceBetDB
ON PRIMARY
(
    NAME = PlaceBetData1,
    FILENAME = 'C:\Users\Public\PlaceBetData1.mdf',
    SIZE = 50 MB,
    MAXSIZE = Unlimited,
    FILEGROWTH = 10%
)
FILEGROUP Secondary
(
    NAME = PlaceBetData2,
    FILENAME = 'C:\Users\Public\PlaceBetData2.mdf',
    SIZE = 20 MB,
    MAXSIZE = 10 GB,
    FILEGROWTH = 10%
)
LOG ON
(
    NAME = PlaceBetLog,
    FILENAME = 'C:\Users\Public\PlaceBetLog.mdf',
    SIZE = 10 MB,
    MAXSIZE = 1 GB,
    FILEGROWTH 5 MB
)
USE PlaceBetDB
CREATE TABLE PlaceBet
{
    PlaceBetID CHAR(8) PRIMARY,
    BetAmount MONEY,
    Payout MONEY,
    Spin SMALLINT
}