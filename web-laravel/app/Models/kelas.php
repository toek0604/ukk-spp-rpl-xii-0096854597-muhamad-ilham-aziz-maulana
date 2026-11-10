<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class kelas extends Model
{
    protected $fillable = [
        'id_kelas',
        'nama_kelas',
        'kompetensi_keahlian',
        'created_at',
        'updated_at'

    ];
}
