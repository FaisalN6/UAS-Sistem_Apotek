<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\AuthController;
use App\Http\Controllers\dashboardController;
use App\Http\Controllers\userController;
use App\Http\Controllers\roleController;
use App\Http\Controllers\ObatController;
use App\Http\Controllers\kategoriController;
use App\Http\Controllers\supplierController;

Route::get('/', function () {
    return view('auth\login');
});

Route::controller(AuthController::class)->group(function () {

    Route::get('login', 'login')->name('login');
    Route::post('logins', 'loginAction')->name('login.action');
  
    Route::get('logout', 'logout')->middleware('auth')->name('logout');
});


Route::get('/profile', [App\Http\Controllers\AuthController::class, 'profile'])->name('profile');

Route::controller(dashboardController::class)->group(function(){
    Route::get('dashboard', 'tblVwObat')->name('dashboard');
});

Route::controller(ObatController::class)->prefix('obats')->group(function(){
    Route::get('', 'index')->name('obats');
    Route::get('create', 'create')->name('obats.create');
    Route::post('store', 'store')->name('obats.store');
    Route::get('{kd_obat}/edit', 'edit')->name('obats.edit');
    Route::post('{kd_obat}/update', 'update')->name('obats.update');
    Route::delete('{id}/destroy', 'destroy')->name('obats.destroy');
});

Route::controller(kategoriController::class)->prefix('kategori')->group(function(){
    Route::get('', 'index')->name('kategori');
    Route::get('create', 'create')->name('kategoris.create');
    Route::post('store', 'store')->name('kategoris.store');
    Route::get('{kd_kategori}/edit', 'edit')->name('kategoris.edit');
    Route::put('{kd_kategori}/update', 'update')->name('kategoris.update');
    Route::delete('{id}/destroy', 'destroy')->name('kategoris.destroy');
});

Route::controller(supplierController::class)->prefix('supplier')->group(function(){
    Route::get('', 'index')->name('supplier');
    Route::get('create', 'create')->name('suppliers.create');
    Route::post('store', 'store')->name('suppliers.store');
    Route::get('{kd_suplier}/edit', 'edit')->name('suppliers.edit');
    Route::put('{kd_suplier}/update', 'update')->name('suppliers.update');
    Route::delete('{id}/destroy', 'destroy')->name('suppliers.destroy');
});

Route::controller(userController::class)->group(function () {
    Route::get('user', 'VWuser')->name('user.view');
    Route::get('user/create', 'createUser')->name('user.create');
    Route::post('user/store', 'storeUser')->name('user.store');
    Route::get('user/edit/{id}', 'editUser')->name('user.edit');
    Route::post('user/strore/{id}', 'updateUser')->name('user.update');
    Route::delete('user/destroy/{id}', 'destroyUser')->name('user.destroy');
});