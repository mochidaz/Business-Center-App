CREATE DATABASE penjualan_db

go

USE penjualan_db

go

CREATE TABLE [dbo].[tbl_user] (
    [uid]      INT           IDENTITY (1, 1) NOT NULL,
    [fullname] VARCHAR (50)  NULL,
    [username] VARCHAR (50)  NULL,
    [password] VARCHAR (255) NULL,
    [status]   VARCHAR (5)   NULL,
    CONSTRAINT [PK_tbl_user] PRIMARY KEY CLUSTERED ([uid] ASC)
);

CREATE TABLE [dbo].[tbl_barang] (
    [id_barang]   INT          IDENTITY (1, 1) NOT NULL,
    [nama_barang] VARCHAR (50) NOT NULL,
    [harga_beli]  INT          NOT NULL,
    [harga_jual]  INT          NOT NULL,
    [stok]        INT          NOT NULL,
    CONSTRAINT [PK_tbl_barangs] PRIMARY KEY CLUSTERED ([id_barang] ASC)
);

CREATE TABLE [dbo].[tbl_barang_keluar] (
    [no_nota_keluar] VARCHAR (50)  NOT NULL,
    [id_barang]      INT           NOT NULL,
    [harga_beli]     INT           NOT NULL,
    [harga_jual]     INT           NOT NULL,
    [jumlah]         INT           NOT NULL,
    [subtotal]       INT           NOT NULL,
    [tanggal]        date          NOT NULL,
    [jam]            time (0)      NOT NULL,
    [uid]            INT           NOT NULL,
    [keuntungan]     INT           NOT NULL,
    [kerugian]       INT           NOT NULL,
    CONSTRAINT [PK_tbl_barang_keluar] PRIMARY KEY CLUSTERED ([no_nota_keluar] ASC),
    CONSTRAINT [FK_tbl_barang_keluar_tbl_user] FOREIGN KEY ([uid]) REFERENCES [dbo].[tbl_user] ([uid]),
    CONSTRAINT [FK_tbl_barang_keluar_tbl_barang] FOREIGN KEY ([id_barang]) REFERENCES [dbo].[tbl_barang] ([id_barang])
);

go