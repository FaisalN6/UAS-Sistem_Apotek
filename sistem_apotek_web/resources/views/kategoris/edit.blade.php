@extends('layout.app')
  
{{-- @section('title', 'Edit Product') --}}
  
@section('contents')
    <h1 class="mb-0">Ubah Kategori</h1>
    <hr />
    <div class="container">
        <div class="card p-0" style="width: 80%; margin: auto; border-top: 5px solid #218CFF;">
            <div class="card-body">
                <div class="form-group">
                    <h3 class="mb-0">Form edit kategori</h3>
                    <hr />
                    <form action="{{ route('kategoris.update', $kategori->kd_kategori) }}" method="POST">
                        @csrf      
                        @method('PUT')
                        
                        {{-- Nama Obat --}}
                        <div class="col mb-3">
                            <label for="nama_kategori">Nama Kategori</label>
                            <input type="text" name="nama_kategori" id="nama_kategori" class="form-control" placeholder="Nama Kategori" value="{{ $kategori->nama_kategori }}">
                        </div>
                        {{-- /Nama Obat --}}
    
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