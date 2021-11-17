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

INSERT INTO tbl_user (fullname, username, password, status) VALUES ("Admin", "admin", "0192023a7bbd73250516f069df18b500", "admin")

CREATE TABLE [dbo].[tbl_barang] (
    [id_barang]   INT          IDENTITY (1, 1) NOT NULL,
    [nama_barang] VARCHAR (50) NOT NULL,
    [harga_beli]  INT          NOT NULL,
    [harga_jual]  INT          NOT NULL,
    [stok]        INT          NOT NULL,
    CONSTRAINT [PK_tbl_barangs] PRIMARY KEY CLUSTERED ([id_barang] ASC)
);

CREATE TABLE [dbo].[tbl_barang_keluar] (
    [no_nota_keluar] VARCHAR (50) NOT NULL,
    [id_barang]      INT          NOT NULL,
    [jumlah]         INT          NOT NULL,
    [subtotal]       INT          NOT NULL,
    [tanggal]        DATE         NOT NULL,
    [uid]            INT          NOT NULL,
    [keuntungan]     INT          NOT NULL,
    [kerugian]       INT          NOT NULL,
    [jam]            TIME (0)     NOT NULL,
    [harga_beli]     INT          NOT NULL,
    [harga_jual]     INT          NOT NULL,
    CONSTRAINT [FK_tbl_barang_keluar_tbl_user] FOREIGN KEY ([uid]) REFERENCES [dbo].[tbl_user] ([uid]),
    CONSTRAINT [FK_tbl_barang_keluar_tbl_barang] FOREIGN KEY ([id_barang]) REFERENCES [dbo].[tbl_barang] ([id_barang])
);

CREATE TABLE [dbo].[tbl_log] (
    [id_log]          INT        IDENTITY (1, 1) NOT NULL,
    [id_user]         INT                        NOT NULL,
    [id_objek]  VARCHAR(100)                NOT NULL,
    [tanggal_berubah] DATETIME                   NOT NULL,
    [kegiatan]  VARCHAR(20)                      NOT NULL,
    [mengedit] VARCHAR(20)                      NOT NULL,
    CONSTRAINT [FK_tbl_log_id_user] FOREIGN KEY ([id_user]) REFERENCES [dbo].[tbl_user] ([uid])
);

go