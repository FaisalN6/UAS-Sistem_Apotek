<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class supplier extends Model
{
    use HasFactory;
    
    protected $filelable = [
        'kd_suplier',
        'nama_suplier',
        'no_tlpn',
        'alamat',
        'perusahaan',
    ];
}
