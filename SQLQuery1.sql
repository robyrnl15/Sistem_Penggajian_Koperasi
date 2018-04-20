SELECT        Penggajian.id_transaksi, Penggajian.tgl_gajian, Penggajian.gaji_bersih, Anggota.namakk, Gaji.jlh_Gaji, Admin.nama
FROM            Penggajian INNER JOIN
                         Gaji ON Penggajian.Id_gaji = Gaji.Id_gaji INNER JOIN
                         Anggota ON Penggajian.Id_anggota = Anggota.Id_anggota INNER JOIN
                         Admin ON Penggajian.Id_admin = Admin.Id_admin