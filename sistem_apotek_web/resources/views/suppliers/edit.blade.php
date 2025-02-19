@extends('layout.app')
  
{{-- @section('title', 'Edit Product') --}}
  
@section('contents')
    <h1 class="mb-0">Ubah Supplier</h1>
    <hr />
    <div class="container">
        <div class="card p-0" style="width: 80%; margin: auto; border-top: 5px solid #218CFF;">
            <div class="card-body">
                <div class="form-group">
                    <h3 class="mb-0">Form edit supplier</h3>
                    <hr />
                    <form action="{{ route('suppliers.update', $supplier->kd_suplier) }}" method="POST" enctype="multipart/form-data">
                        @csrf      
                        @method('PUT')
                        {{-- Nama Obat --}}
                        <div class="col mb-3">
                            <label for="namaSupplier">Nama Supplier</label>
                            <input type="text" name="nama_supplier" id="namaSupplier" class="form-control" placeholder="Nama Supplier" value="{{ $supplier->nama_suplier }}">
                        </div>
                        {{-- /Nama Obat --}}
    
                        
                        {{-- Harga Obat --}}
                        <div class="col mb-3">
                            <label for="noTelp">No. Telepon</label>
                            <input type="text" name="no_tlpn" id="noTelp" class="form-control" placeholder="08XX-XXX" value="{{ $supplier->no_tlpn }}">
                        </div>

                        {{-- stok Obat --}}
                        <div class="col mb-3">
                            <label for="Alamat">Alamat</label>
                            <input type="text" name="alamat" id="Alamat" class="form-control" placeholder="Alamat" value="{{ $supplier->alamat }}">
                        </div>
                        {{-- /stok Obat --}}
                        
                        {{-- Harga Obat --}}
                        <div class="col mb-3">
                            <label for="Perusahaan">Perusahaan</label>
                            <input type="text" name="perusahaan" id="Perusahaan" class="form-control" placeholder="Perusahaan" value="{{ $supplier->perusahaan }}">
                        </div>
                        {{-- /Harga Obat --}}
    
                        {{-- /Deskripsi --}}
                            <div class="col text-right">
                                {{-- <button type="submit" class="btn btn-secondary">Batal</button> --}}
                                <a href="{{ route('supplier') }}" type="button" class="btn btn-secondary">Batal</a>
                                <button type="submit" class="btn btn-primary">Submit</button>
                            </div>
                    </form>
                </div>
            </div>
        </div>
        </div>
@endsection