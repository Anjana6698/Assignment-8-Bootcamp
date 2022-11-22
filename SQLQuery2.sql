drop table Registration;
CREATE TABLE [dbo].[Registration] (
    [Id]      INT          IDENTITY (1, 1) NOT NULL,
    [name]    VARCHAR (50) NULL,
    [address] VARCHAR (50) NULL,
    [email]   VARCHAR (50) NULL,
    [phone]   VARCHAR (50) NULL,
    [gender]  VARCHAR (50) NULL,
    [uId] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
select * from Registration;