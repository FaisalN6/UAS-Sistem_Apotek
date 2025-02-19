@extends('layout.app')

@section('contents')
    <h1 class="mb-0">Tambah Obat</h1>
    <hr />
    <div class="container">
        <div class="card p-0" style="width: 80%; margin: auto; border-top: 5px solid #218CFF;">
            <div class="card-body">
                <div class="form-group">
                    <h3 class="mb-0">Form tambah obat</h3>
                    <hr />
                    <form action="{{ route('obats.store') }}" method="POST" enctype="multipart/form-data">
                        @csrf
                        {{-- Kode Obat --}}
                        <div class="col mb-3">
                            <label for="kodeObat">Kode Obat</label>
                            <input type="text" name="kd_obat" id="kodeObat" class="form-control" placeholder="Kode Obat">
                        </div>
                        {{-- /Kode Obat --}}

                        {{-- Nama Obat --}}
                        <div class="col mb-3">
                            <label for="namaObat">Nama Obat</label>
                            <input type="text" name="nama_obat" id="namaObat" class="form-control" placeholder="Nama Obat">
                        </div>
                        {{-- /Nama Obat --}}

                        {{-- Kategori Obat --}}
                        <div class="col mb-3">
                            <label for="kd_kategori">Kode Kategori Obat</label>
                            <input type="text" name="kd_kategori" id="kd_kategori" class="form-control" placeholder="Kode Kategori">
                        </div>
                        {{-- /Kategori Obat --}}

                        {{-- Kode Suplier --}}
                        <div class="col mb-3">
                            <label for="kd_suplier">Kode Suplier</label>
                            <input type="text" name="kd_suplier" id="kd_suplier" class="form-control" placeholder="Kode Suplier">
                        </div>
                        {{-- /Kode Suplier --}}

                        {{-- jenis Obat --}}
                        <div class="col mb-3">
                            <label for="jenis_obat">Jenis Obat</label>
                            <input type="text" name="jenis_obat" id="jenis_obat" class="form-control" placeholder="Jenis Obat">
                        </div>
                        {{-- /Jenis Obat --}}

                        {{-- Stok Obat --}}
                        <div class="col mb-3">
                            <label for="stokObat">Stok Obat</label>
                            <input type="number" name="stock" id="stokObat" class="form-control" placeholder="Stok Obat">
                        </div>
                        {{-- /Stok Obat --}}

                        {{-- Harga Obat --}}
                        <div class="col mb-3">
                            <label for="hargaObat">Harga Obat</label>
                            <input type="text" name="harga" id="hargaObat" class="form-control" placeholder="Harga Obat">
                        </div>
                        {{-- /Harga Obat --}}

                        {{-- Input Gambar --}}
                        <div class="col mb-3">
                            <label for="gambarObat">Gambar Obat</label>
                            <div class="col m-0 p-0 form-control">
                                <div class="form-group">
                                    <input type="file" class="form-control-file" id="gambarObat" name="image_path">
                                </div>
                            </div>
                        </div>
                        {{-- /Input Gambar --}}

                        {{-- Deskripsi --}}
                        <div class="col mb-3">
                            <label for="deskripsiObat">Deskripsi</label>
                            <textarea class="form-control" name="description" id="deskripsiObat" placeholder="Deskripsi"></textarea>
                        </div>
                        {{-- /Deskripsi --}}

                        <div class="col text-right">
                            <a href="{{ route('obats') }}" type="button" class="btn btn-secondary">Batal</a>
                            <button type="submit" class="btn btn-primary">Submit</button>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
@endsection
