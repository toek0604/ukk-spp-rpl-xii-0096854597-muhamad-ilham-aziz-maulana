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
        Schema::create('siswas', function (Blueprint $table) {
            $table->id('nisn')-> CHAR(10);
            $table->id('nis')-> INT(8)-> NOTNULL();
            $table->string('nama')-> VARCHAR(50);
            $table->string('id_kelas')-> INT()-> NOTNULL();
            $table->string('alamat')-> TEXT();
            $table->string('no_telp')-> VARCHAR(15);
            $table->id('id_spp')-> INT()-> NOTNULL();
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('siswas');
    }
};
