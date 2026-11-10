<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class petugas extends Model
{
    protected $fillable = [
        'id_petugas',
        'username',
        'password',
        'nama_petugas',
        'level',
        'created_at',
        'updated_at'
    ];
}
