CREATE TABLE [dbo].[Crop] (
    [CropName]    VARCHAR (20) NOT NULL,
    [Price]       FLOAT(3)         NULL,
    [Quantity]    INT          NULL,
    [Fertilizer ] VARCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([CropName] ASC)
);


GO
