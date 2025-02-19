<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Obat extends Model
{
    use HasFactory;

    protected $filelable = [
        'kd_obat',
        'nama_obat',
        'kd_kategori',
        'stok_obat',
        'harga_obat',
        'gambar_obat',
        'deskripsi_obat'
    ];
}
