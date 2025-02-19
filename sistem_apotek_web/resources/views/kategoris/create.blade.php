@extends('layout.app')
  
{{-- @section('title', 'Tambah Obat') --}}

@section('contents')
    <h1 class="mb-0">Tambah Kategori</h1>
    <hr />
    <div class="container">
    <div class="card p-0" style="width: 80%; margin: auto; border-top: 5px solid #218CFF;">
        <div class="card-body">
            <div class="form-group">
                <h3 class="mb-0">Form tambah kategori</h3>
                <hr />
                <form action="{{ route('kategoris.store') }}" method="POST" enctype="multipart/form-data">
                    @csrf      
                    {{-- Nama Obat --}}
                    <div class="col mb-3">
                        <label for="kdKategori">Kode Kategori</label>
                        <input type="text" name="kd_kategori" id="kdKategori" class="form-control" placeholder="Kode Kategori">
                    </div>
                    <div class="col mb-3">
                        <label for="namaKategori">Nama Kategori</label>
                        <input type="text" name="nama_kategori" id="namaKategori" class="form-control" placeholder="Nama Kategori">
                    </div>
                    {{-- /Nama Obat --}}

                    {{-- /Deskripsi --}}
                        <div class="col text-right">
                            {{-- <button type="submit" class="btn btn-secondary">Batal</button> --}}
                            <a href="{{ route('kategori') }}" type="button" class="btn btn-secondary">Batal</a>
                            <button type="submit" class="btn btn-primary">Submit</button>
                        </div>
                </form>
            </div>
        </div>
    </div>
    </div>
@endsection