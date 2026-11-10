<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

return new class extends Migration
{
    /**
     * Run the migrations.
     */
    public function up(): void
    {
        Schema::create('pembayarans', function (Blueprint $table) {
            $table->id('id_pembayaran')-> INT();
            $table->id('id_petugas')-> VARCHAR(30);
            $table->string('bulan_bayar')-> VARCHAR(15);
            $table->string('tahun_bayar')-> VARCHAR(4);
            $table->id('id_spp')-> INT()-> NOTNULL();
            $table->id('jumlah_bayar')-> INT()-> NOTNULL();
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('pembayarans');
    }
};
